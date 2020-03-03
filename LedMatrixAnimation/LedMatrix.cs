using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LedMatrixAnimation
{
    public partial class LedMatrix : UserControl
    {
        private byte[,] _matrix = new byte[8, 8];
        private bool _mouseDown = false, _mouseIn = false;
        private int _previousCol, _previousRow;
        private int _actionButtonsPanelHeight = 24;
        private int _actionButtonSize = 16;

        #region Event Handlers
        public event EventHandler<EventArgs> LedMatrixCopy;
        public event EventHandler<EventArgs> LedMatrixPaste;
        public event EventHandler<EventArgs> LedMatrixDelete;
        public event EventHandler<LedMatrixMoveEventArgs> LedMatrixMove;
        #endregion

        #region Designer Properties
        [Category("Behavior"), Description("Allows to edit the matrix content")]
        public bool ReadOnly { get; set; }

        [Category("Behavior"), Description("Allows to make some actions to the matrix")]
        public bool ShowActionButtons { get; set; }
        #endregion

        #region Properties
        public byte[] Content
        {
            get
            {
                byte[] result = new byte[8];

                for (int r = 0; r < 8; r++)
                {
                    for (int c = 0; c < 8; c++)
                    {
                        result[r] |= (byte)(_matrix[r, c] << (7 - c));
                    }
                }

                return result;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Matrix content cannot be null");
                }

                if (value.Length != 8)
                {
                    throw new ArgumentOutOfRangeException("Content length mismatch");
                }

                for (int i = 0; i < value.Length; i++)
                {
                    SetRow(i, value[i]);
                }

                Refresh();
            }
        }

        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                if (ShowActionButtons)
                {
                    base.Size = new Size(value.Width, value.Width + _actionButtonsPanelHeight);
                }
                else
                {
                    base.Size = new Size(value.Width, value.Width);
                }
            }
        }

        public new int Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;

                if (ShowActionButtons)
                {
                    base.Height = value + _actionButtonsPanelHeight;
                }
                else
                {
                    base.Height = value;
                }
            }
        }

        public new int Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Height = value;

                if (ShowActionButtons)
                {
                    base.Width = value - 24;
                }
                else
                {
                    base.Width = value;
                }
            }
        }
        #endregion

        public LedMatrix()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #region Content Operations
        public void SetContent(LedMatrix src)
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    _matrix[r, c] = src._matrix[r, c];
                }
            }

            Refresh();
        }

        private void SetRow(int rowIndex, byte rowContent)
        {
            for (int i = 0; i < 8; i++)
            {
                _matrix[rowIndex, 7 - i] = (byte)((rowContent >> i) & 1);
            }
        }

        public void Clean()
        {
            CleanInternal();
            this.Refresh();
        }

        private void CleanInternal()
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    _matrix[r, c] = 0;
                }
            }
        }
        #endregion

        #region Event Handler Methods
        private void Matrix8x8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Width, this.Width);

            float delta = this.Width / 8.0f;

            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (_matrix[row, col] == 1)
                    {
                        DrawTurnedOnLed(e.Graphics, col * delta + 1, row * delta + 1, delta - 3.0f, delta - 3.0f);
                    }
                    else
                    {
                        DrawTurnedOffLed(e.Graphics, col * delta + 1, row * delta + 1, delta - 3.0f, delta - 3.0f);
                    }
                }
            }

            if (_mouseIn)
            {
                DrawActionButtons(e.Graphics);
            }
            else
            {
                HideActionButtons(e.Graphics);
            }
        }

        private void Matrix8x8_MouseDown(object sender, MouseEventArgs e)
        {
            if (ReadOnly)
            {
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                CleanInternal();
                return;
            }

            _mouseDown = true;
            var g = this.CreateGraphics();

            float delta = this.Width / 8.0f;
            var col = (int)(e.X / delta);
            var row = (int)(e.Y / delta);

            _previousCol = col;
            _previousRow = row;

            DrawLed(row, col, delta, g);
        }

        private void Matrix8x8_MouseUp(object sender, MouseEventArgs e)
        {
            if (ReadOnly)
            {
                return;
            }

            _mouseDown = false;
        }

        private void Matrix8x8_MouseMove(object sender, MouseEventArgs e)
        {
            var g = this.CreateGraphics();

            if (ReadOnly)
            {
                return;
            }

            if (_mouseDown)
            {
                float delta = this.Width / 8.0f;
                var col = (int)(e.X / delta);
                var row = (int)(e.Y / delta);

                if (col != _previousCol || row != _previousRow)
                {
                    DrawLed(row, col, delta, g);
                    _previousRow = row;
                    _previousCol = col;
                }
            }
        }

        private void LedMatrix_MouseEnter(object sender, EventArgs e)
        {
            _mouseIn = true;
            var g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawActionButtons(g);
        }

        private void LedMatrix_MouseLeave(object sender, EventArgs e)
        {
            _mouseIn = false;
            var g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            HideActionButtons(g);
            Refresh();
        }

        private void LedMatrix_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Y > Width)
            {
                var iconWidth = 3 + _actionButtonSize;

                if (e.X >= 3 && e.X <= _actionButtonSize)
                {
                    LedMatrixMove?.Invoke(this, new LedMatrixMoveEventArgs(LedMatrixMovePosition.First));
                }
                else if (e.X >= iconWidth && e.X <= iconWidth + _actionButtonSize)
                {
                    LedMatrixMove?.Invoke(this, new LedMatrixMoveEventArgs(LedMatrixMovePosition.Left));
                }
                else if (e.X >= 2 * iconWidth && e.X <= 2 * iconWidth + _actionButtonSize)
                {
                    LedMatrixMove?.Invoke(this, new LedMatrixMoveEventArgs(LedMatrixMovePosition.Right));
                }
                else if (e.X >= 3 * iconWidth && e.X <= 3 * iconWidth + _actionButtonSize)
                {
                    LedMatrixMove?.Invoke(this, new LedMatrixMoveEventArgs(LedMatrixMovePosition.Last));
                }
                else if (e.X >= 5 * iconWidth && e.X <= 5 * iconWidth + _actionButtonSize)
                {
                    LedMatrixCopy?.Invoke(this, new EventArgs());
                }
                else if (e.X >= 6 * iconWidth && e.X <= 6 * iconWidth + _actionButtonSize)
                {
                    LedMatrixPaste?.Invoke(this, new EventArgs());
                }
                else if (e.X >= 7 * iconWidth && e.X <= 7 * iconWidth + _actionButtonSize)
                {
                    LedMatrixDelete?.Invoke(this, new EventArgs());
                }
            }
        }

        #endregion

        #region Utilities
        private void DrawLed(int row, int col, float delta, Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (col >= 0 && col < 8 && row >= 0 && row < 8)
            {
                if (_matrix[row, col] == 1)
                {
                    _matrix[row, col] = 0;
                    DrawTurnedOffLed(g, col * delta + 1, row * delta + 1, delta - 3, delta - 3);
                }
                else
                {
                    _matrix[row, col] = 1;
                    DrawTurnedOnLed(g, col * delta + 1, row * delta + 1, delta - 3, delta - 3);
                }
            }
        }

        private void DrawTurnedOnLed(Graphics g, float x, float y, float width, float height)
        {
            g.FillEllipse(Brushes.OrangeRed, x, y, width, height);
            /*g.FillEllipse(new SolidBrush(Color.FromArgb(255, 50, 0)), x + 2, y + 2, width - 2, height - 3);

            float startX = x + 2, startY = y + width / 2 - 5, w = width / 2.5f;
            int colorStep = (int)((255 - 50) / (w / 2)) - 1;
            int green = 50;

            for (int i = 0; i < w / 2; i++)
            {
                g.FillEllipse(new SolidBrush(Color.FromArgb(255, green, 0)), startX, startY + i,  w - 2 * i, w - 2 * i);
                green += colorStep;
            }*/
        }

        private void DrawTurnedOffLed(Graphics g, float x, float y, float width, float height)
        {
            g.FillEllipse(Brushes.LightGray, x, y, width, height);
        }

        private void DrawActionButtons(Graphics g)
        {
            if (!ShowActionButtons)
            {
                return;
            }

            g.FillRectangle(new SolidBrush(Color.FromArgb(150, 240, 240, 240)), 0, this.Width, this.Width, this.Height);
            g.DrawRectangle(new Pen(Color.FromArgb(150, 150, 150, 150)), 0, this.Width, this.Width - 1, this.Height - this.Width - 1);

            var iconWidth = 3 + _actionButtonSize;

            g.DrawImage(Icons.move_first_16, 3, Width + 3);
            g.DrawImage(Icons.move_left_16, 1 * iconWidth, Width + 3);
            g.DrawImage(Icons.move_right_16, 2 * iconWidth, Width + 3);
            g.DrawImage(Icons.move_last_16, 3 * iconWidth, Width + 3);
            g.DrawImage(Icons.copy_16,  5 * iconWidth, Width + 3);
            g.DrawImage(Icons.paste_16, 6 * iconWidth, Width + 3);
            g.DrawImage(Icons.delete_16, 7 * iconWidth, Width + 3);
            //g.DrawImage(Icons.menu_4_16, 8 * iconWidth, Width + 3);
        }

        private void HideActionButtons(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(70, 240, 240, 240)), 0, this.Width, this.Width, this.Height);
            g.DrawRectangle(new Pen(Color.FromArgb(70, 150, 150, 150)), 0, this.Width, this.Width - 1, this.Height - this.Width - 1);
        }
        #endregion
    }


    public enum LedMatrixMovePosition
    {
        Left = 0,
        Right,
        First,
        Last
    }

    public class LedMatrixMoveEventArgs : EventArgs
    {
        public LedMatrixMovePosition Position { get; private set; }

        public LedMatrixMoveEventArgs(LedMatrixMovePosition position)
        {
            Position = position;
        }
    }
}
