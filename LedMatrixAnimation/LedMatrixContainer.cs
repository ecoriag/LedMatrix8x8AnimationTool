using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LedMatrixAnimation
{
    public class LedMatrixContainer
    {
        private int _matrixSize = 8;
        private readonly List<LedMatrix> _content;
        private readonly byte[] _clipboard;

        public LedMatrixContainer()
        {
            _content = new List<LedMatrix>();
            _clipboard = new byte[_matrixSize];
        }
        public int Count
        {
            get
            {
                return _content.Count;
            }
        }

        public IEnumerable<LedMatrix> GetContent()
        {
            return _content.ToArray();
        }

        public LedMatrix GetAt(int index)
        {
            if (index < 0 || index >= _content.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            return _content[index];
        }

        public void Add(LedMatrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException();
            }

            matrix.LedMatrixCopy += OnLedMatrixCopy;
            matrix.LedMatrixPaste += OnLedMatrixPaste;
            matrix.LedMatrixMove += OnLedMatrixMove;
            matrix.LedMatrixDelete += OnLedMatrixDelete;
            _content.Add(matrix);
        }

        public void Remove(LedMatrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException();
            }

            matrix.LedMatrixCopy -= OnLedMatrixCopy;
            matrix.LedMatrixPaste -= OnLedMatrixPaste;
            _content.Remove(matrix);
        }

        public void RemoveLast()
        {
            if (_content.Count > 0)
            {
                var lastMatrix = _content[_content.Count - 1];
                lastMatrix.Parent = null;
                lastMatrix.LedMatrixCopy -= OnLedMatrixCopy;
                lastMatrix.LedMatrixPaste -= OnLedMatrixPaste;
                _content.Remove(lastMatrix);
            }
        }

        public void Clear()
        {
            foreach (var matrix in _content)
            {
                matrix.Parent = null;
                matrix.LedMatrixCopy -= OnLedMatrixCopy;
                matrix.LedMatrixPaste -= OnLedMatrixPaste;
            }

            _content.Clear();
        }

        #region Event Handlers
        private void OnLedMatrixCopy(object sender, EventArgs e)
        {
            var matrixContent = (sender as LedMatrix).Content;

            if (matrixContent != null && matrixContent.Length == _matrixSize)
            {
                for (int i = 0; i < _matrixSize; i++)
                {
                    _clipboard[i] = matrixContent[i];
                }
            }
        }

        private void OnLedMatrixPaste(object sender, EventArgs e)
        {
            (sender as LedMatrix).Content = _clipboard;
        }

        private void OnLedMatrixDelete(object sender, EventArgs e)
        {
            if (_content.Count <= 2)
            {
                MessageBox.Show("Animation must have at least 2 clips", "Delete Clip", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var dialogResult = MessageBox.Show("Are you sure you want to delete this clip?", "Delete Clip", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var matrix = (sender as LedMatrix);
                var index = _content.IndexOf(matrix);
                matrix.Parent = null;
                SlideRight(index);
                _content.Remove(matrix);
            }
        }

        private void OnLedMatrixMove(object sender, LedMatrixMoveEventArgs e)
        {
            var matrix = (sender as LedMatrix);

            if (e.Position == LedMatrixMovePosition.First)
            {
                var index = _content.IndexOf(matrix);

                if (index > 0)
                {
                    _content.Remove(matrix);
                    _content.Insert(0, matrix);
                    SlideLeft(index);
                }
            }
            else if (e.Position == LedMatrixMovePosition.Left)
            {
                var index = _content.IndexOf(matrix);

                if (index > 0)
                {
                    var content = _content[index - 1].Content;
                    _content[index - 1].Content = _content[index].Content;
                    _content[index].Content = content;
                }
            }
            else if (e.Position == LedMatrixMovePosition.Right)
            {
                var index = _content.IndexOf(matrix);

                if (index < _content.Count - 1)
                {
                    var content = _content[index + 1].Content;
                    _content[index + 1].Content = _content[index].Content;
                    _content[index].Content = content;
                }
            }
            else if (e.Position == LedMatrixMovePosition.Last)
            {
                var index = _content.IndexOf(matrix);

                if (index < _content.Count - 1)
                {
                    _content.Remove(matrix);
                    _content.Add(matrix);
                    SlideRight(index);
                }
            }
        }
        #endregion

        #region Utils
        private void SlideLeft(int index)
        {
            var firstLeft = _content[0].Left;

            for (int i = 0; i < index; i++)
            {
                _content[i].Left = _content[i + 1].Left;
            }

            _content[index].Left = firstLeft;
        }

        private void SlideRight(int index)
        {
            var lastLeft = _content[_content.Count - 1].Left;

            for (int i = _content.Count - 1; i > index; i--)
            {
                _content[i].Left = _content[i - 1].Left;
            }

            _content[index].Left = lastLeft;
        }
        #endregion
    }
}
