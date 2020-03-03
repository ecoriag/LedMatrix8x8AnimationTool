using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LedMatrixAnimation
{
    public partial class MainForm : Form
    {
        private LedMatrixContainer _clips = new LedMatrixContainer();
        private bool _isSimulating = false;
        private int _simulationInterval = 500; // 500ms
        private byte _simulationSpeed = 1;
        private readonly Timer _simulationTimer;
        private int _currentClipIndex;

        public MainForm()
        {
            InitializeComponent();
            
            AddClip();
            AddClip();

            _simulationTimer = new Timer();
            _simulationTimer.Tick += OnSimulationStep;
        }

        private void AddClip(LedMatrix clip = null)
        {
            if (clip == null)
            {
                clip = new LedMatrix();
            }

            clip.Top = 10;
            clip.ShowActionButtons = true;
            clip.Width = 170;
            clip.Left = (_clips.Count * (clip.Width + 10)) + 10;
            clip.Parent = ClipsContainer;

            _clips.Add(clip);
            ClipCountLabel.Text = _clips.Count.ToString();
        }

        private void AddClips(IEnumerable<LedMatrix> clips)
        {
            foreach (var clip in clips)
            {
                AddClip(clip);
                clip.Refresh();
            }
        }

        private void RemoveClip()
        {
            if (_clips.Count > 2)
            {
                _clips.RemoveLast();
            }

            ClipCountLabel.Text = _clips.Count.ToString();
        }

        private void AddClipButton_Click(object sender, EventArgs e)
        {
            AddClip();
        }

        private void RemoveClipButton_Click(object sender, EventArgs e)
        {
            RemoveClip();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            foreach (var clip in _clips.GetContent())
            {
                var clipContent = clip.Content;
                string formattedContent = string.Format(
                    "0x{0:X2}, 0x{1:X2}, 0x{2:X2}, 0x{3:X2}, 0x{4:X2}, 0x{5:X2}, 0x{6:X2}, 0x{7:X2},",
                    clipContent[0],
                    clipContent[1],
                    clipContent[2],
                    clipContent[3],
                    clipContent[4],
                    clipContent[5],
                    clipContent[6],
                    clipContent[7]);
                result.Append(formattedContent);
                result.Append(Environment.NewLine);
            }

            ResultTextbox.Text = result.ToString();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            foreach (var clip in _clips.GetContent())
            {
                clip.Clean();
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!_isSimulating)
            {
                StartSimulation();
            }
            else
            {
                StopSimulation();
            }
        }

        private void StartSimulation()
        {
            _isSimulating = true;
            _currentClipIndex = 0;
            SimulationMatrix.Clean();

            _simulationTimer.Interval = _simulationInterval / _simulationSpeed;
            _simulationTimer.Start();

            PlayButton.Image = Icons.stop_32;
            ToolTip.SetToolTip(PlayButton, "Stop Simulation");
        }

        private void StopSimulation()
        {
            _isSimulating = false;
            _simulationTimer.Stop();
            SimulationMatrix.Clean();

            PlayButton.Image = Icons.play_32;
            ToolTip.SetToolTip(PlayButton, "Start Simulation");
        }

        private void OnSimulationStep(object sender, EventArgs e)
        {
            if (_currentClipIndex >= _clips.Count)
            {
                _currentClipIndex = 0;
            }

            var currentClip = _clips.GetAt(_currentClipIndex);

            if (currentClip != null)
            {
                SimulationMatrix.SetContent(currentClip);
                _currentClipIndex++;
            }

            
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            var dialogResult = SaveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                new File().SaveToFile(_clips.GetContent(), SaveFileDialog.FileName);
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (_isSimulating)
            {
                StopSimulation();
            }

            var dialogResult = OpenFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                var loadedClips = new File().ReadFromFile(OpenFileDialog.FileName);
                _clips.Clear();

                AddClips(loadedClips);
            }
        }

        private void AddCopyButton_Click(object sender, EventArgs e)
        {
            var copyClip = new LedMatrix();
            copyClip.SetContent(_clips.GetAt(_clips.Count - 1));
            AddClip(copyClip);
        }

        private void SpeedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _simulationSpeed = byte.Parse((string)(sender as Control).Tag);
            _simulationTimer.Interval = _simulationInterval / _simulationSpeed;
        }
    }
}
