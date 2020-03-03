using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LedMatrixTextScroll
{
    public partial class MainForm : Form
    {
        private byte[,] _bigMatrix = new byte[8, 500];
        private Dictionary<char, byte[]> _charMappings = new Dictionary<char, byte[]>
        {
            { 'A', new byte[5] {0b0110, 0b1001, 0b1001, 0b1111, 0b1001 } },
            { 'C', new byte[5] {0b0111, 0b1000, 0b1000, 0b1000, 0b0111 } },
            { 'H', new byte[5] {0b1001, 0b1001, 0b1111, 0b1001, 0b1001 } },
            { 'L', new byte[5] {0b1000, 0b1000, 0b1000, 0b1000, 0b1111 } },
            { 'U', new byte[5] {0b1001, 0b1001, 0b1001, 0b1001, 0b0110 } },
            { 'W', new byte[5] {0b1001, 0b1001, 0b1011, 0b1111, 0b0101 } }
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputText.Text))
            {
                int currentColumn = 8;

                foreach (char character in InputText.Text)
                {
                    if (_charMappings.ContainsKey(character))
                    {
                        byte[] charRows = _charMappings[character];
                        int row = 3;

                        foreach (var charRow in charRows)
                        {
                            _bigMatrix[row, currentColumn] = (byte)(charRow >> 3);
                            _bigMatrix[row, currentColumn + 1] = (byte)((charRow & 0b0100) >> 2);
                            _bigMatrix[row, currentColumn + 2] = (byte)((charRow & 0b0010) >> 1);
                            _bigMatrix[row, currentColumn + 3] = (byte)(charRow & 0b0001);
                            row++;
                        }

                        currentColumn += 5;
                    }
                }

                byte[] currentScreen = new byte[8];

                for (int c = 0; c < currentColumn; c++)
                {
                    for (int r = 0; r < 8; r++)
                    {
                        currentScreen[r] = 0;

                        for (int cc = 0; cc < 8; cc++)
                        {
                            currentScreen[r] |= (byte)(_bigMatrix[r, cc + c] << (7 - cc));
                        }
                    }

                    string formattedScreen = string.Format(
                        "0x{0:X2}, 0x{1:X2}, 0x{2:X2}, 0x{3:X2}, 0x{4:X2}, 0x{5:X2}, 0x{6:X2}, 0x{7:X2},",
                        currentScreen[0],
                        currentScreen[1],
                        currentScreen[2],
                        currentScreen[3],
                        currentScreen[4],
                        currentScreen[5],
                        currentScreen[6],
                        currentScreen[7]);

                    ResultTextBox.Text += Environment.NewLine + formattedScreen;
                }
            }
        }
    }
}
