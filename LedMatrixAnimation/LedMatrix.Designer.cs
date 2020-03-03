namespace LedMatrixAnimation
{
    partial class LedMatrix
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LedMatrix
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LedMatrix";
            this.Size = new System.Drawing.Size(320, 344);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Matrix8x8_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LedMatrix_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Matrix8x8_MouseDown);
            this.MouseEnter += new System.EventHandler(this.LedMatrix_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LedMatrix_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Matrix8x8_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Matrix8x8_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
