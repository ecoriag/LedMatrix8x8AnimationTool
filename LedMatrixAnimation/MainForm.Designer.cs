namespace LedMatrixAnimation
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.AddCopyButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.GenerateCodeButton = new System.Windows.Forms.Button();
            this.RemoveClipButton = new System.Windows.Forms.Button();
            this.AddClipButton = new System.Windows.Forms.Button();
            this.ClipCountLabel = new System.Windows.Forms.Label();
            this.ClipCountLabelLabel = new System.Windows.Forms.Label();
            this.ClipsContainer = new System.Windows.Forms.Panel();
            this.ResultsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GeneratedCodePanel = new System.Windows.Forms.Panel();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.SimulationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SimulationMatrixPanel = new System.Windows.Forms.Panel();
            this.SimulationMatrix = new LedMatrixAnimation.LedMatrix();
            this.SimulationSpeedPanel = new System.Windows.Forms.Panel();
            this.EightSpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.QuadSpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.DoubleSpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.NormalSpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.GeneratedCodePanel.SuspendLayout();
            this.SimulationPanel.SuspendLayout();
            this.SimulationMatrixPanel.SuspendLayout();
            this.SimulationSpeedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.ActionsPanel, 0, 0);
            this.MainPanel.Controls.Add(this.ClipsContainer, 0, 1);
            this.MainPanel.Controls.Add(this.ResultsPanel, 0, 2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 3;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Size = new System.Drawing.Size(1146, 795);
            this.MainPanel.TabIndex = 5;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.BackColor = System.Drawing.Color.LightBlue;
            this.ActionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionsPanel.Controls.Add(this.AddCopyButton);
            this.ActionsPanel.Controls.Add(this.OpenFileButton);
            this.ActionsPanel.Controls.Add(this.SettingsButton);
            this.ActionsPanel.Controls.Add(this.SaveFileButton);
            this.ActionsPanel.Controls.Add(this.PlayButton);
            this.ActionsPanel.Controls.Add(this.CleanButton);
            this.ActionsPanel.Controls.Add(this.GenerateCodeButton);
            this.ActionsPanel.Controls.Add(this.RemoveClipButton);
            this.ActionsPanel.Controls.Add(this.AddClipButton);
            this.ActionsPanel.Controls.Add(this.ClipCountLabel);
            this.ActionsPanel.Controls.Add(this.ClipCountLabelLabel);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsPanel.Location = new System.Drawing.Point(3, 3);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(1140, 54);
            this.ActionsPanel.TabIndex = 8;
            // 
            // AddCopyButton
            // 
            this.AddCopyButton.BackColor = System.Drawing.Color.Honeydew;
            this.AddCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCopyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCopyButton.Image = global::LedMatrixAnimation.Icons.plus_copy_32;
            this.AddCopyButton.Location = new System.Drawing.Point(344, 4);
            this.AddCopyButton.Name = "AddCopyButton";
            this.AddCopyButton.Size = new System.Drawing.Size(44, 44);
            this.AddCopyButton.TabIndex = 14;
            this.ToolTip.SetToolTip(this.AddCopyButton, "Add copy of last clip");
            this.AddCopyButton.UseVisualStyleBackColor = false;
            this.AddCopyButton.Click += new System.EventHandler(this.AddCopyButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.Honeydew;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Image = global::LedMatrixAnimation.Icons.folder_4_32;
            this.OpenFileButton.Location = new System.Drawing.Point(148, 4);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(44, 44);
            this.OpenFileButton.TabIndex = 13;
            this.ToolTip.SetToolTip(this.OpenFileButton, "Open File");
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.BackColor = System.Drawing.Color.Honeydew;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Image = global::LedMatrixAnimation.Icons.settings_24_32;
            this.SettingsButton.Location = new System.Drawing.Point(1091, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(44, 44);
            this.SettingsButton.TabIndex = 12;
            this.ToolTip.SetToolTip(this.SettingsButton, "Settings");
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.Honeydew;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Image = global::LedMatrixAnimation.Icons.save_32;
            this.SaveFileButton.Location = new System.Drawing.Point(198, 4);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(44, 44);
            this.SaveFileButton.TabIndex = 11;
            this.ToolTip.SetToolTip(this.SaveFileButton, "Save File");
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Honeydew;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Image = global::LedMatrixAnimation.Icons.play_32;
            this.PlayButton.Location = new System.Drawing.Point(578, 4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(44, 44);
            this.PlayButton.TabIndex = 10;
            this.ToolTip.SetToolTip(this.PlayButton, "Start Simulation");
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.BackColor = System.Drawing.Color.Honeydew;
            this.CleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanButton.Image = global::LedMatrixAnimation.Icons.blank_file_32;
            this.CleanButton.Location = new System.Drawing.Point(444, 4);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(44, 44);
            this.CleanButton.TabIndex = 9;
            this.ToolTip.SetToolTip(this.CleanButton, "Clean all Clips");
            this.CleanButton.UseVisualStyleBackColor = false;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // GenerateCodeButton
            // 
            this.GenerateCodeButton.BackColor = System.Drawing.Color.Honeydew;
            this.GenerateCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateCodeButton.Image = global::LedMatrixAnimation.Icons.code_32;
            this.GenerateCodeButton.Location = new System.Drawing.Point(628, 4);
            this.GenerateCodeButton.Name = "GenerateCodeButton";
            this.GenerateCodeButton.Size = new System.Drawing.Size(44, 44);
            this.GenerateCodeButton.TabIndex = 8;
            this.ToolTip.SetToolTip(this.GenerateCodeButton, "Generate Code");
            this.GenerateCodeButton.UseVisualStyleBackColor = false;
            this.GenerateCodeButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RemoveClipButton
            // 
            this.RemoveClipButton.BackColor = System.Drawing.Color.Honeydew;
            this.RemoveClipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveClipButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveClipButton.Image = global::LedMatrixAnimation.Icons.minus_2_32;
            this.RemoveClipButton.Location = new System.Drawing.Point(394, 4);
            this.RemoveClipButton.Name = "RemoveClipButton";
            this.RemoveClipButton.Size = new System.Drawing.Size(44, 44);
            this.RemoveClipButton.TabIndex = 7;
            this.ToolTip.SetToolTip(this.RemoveClipButton, "Delete Last Clip");
            this.RemoveClipButton.UseVisualStyleBackColor = false;
            this.RemoveClipButton.Click += new System.EventHandler(this.RemoveClipButton_Click);
            // 
            // AddClipButton
            // 
            this.AddClipButton.BackColor = System.Drawing.Color.Honeydew;
            this.AddClipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClipButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClipButton.Image = global::LedMatrixAnimation.Icons.plus_new_32;
            this.AddClipButton.Location = new System.Drawing.Point(294, 4);
            this.AddClipButton.Name = "AddClipButton";
            this.AddClipButton.Size = new System.Drawing.Size(44, 44);
            this.AddClipButton.TabIndex = 4;
            this.ToolTip.SetToolTip(this.AddClipButton, "Add empty clip");
            this.AddClipButton.UseVisualStyleBackColor = false;
            this.AddClipButton.Click += new System.EventHandler(this.AddClipButton_Click);
            // 
            // ClipCountLabel
            // 
            this.ClipCountLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClipCountLabel.Location = new System.Drawing.Point(9, 4);
            this.ClipCountLabel.Name = "ClipCountLabel";
            this.ClipCountLabel.Size = new System.Drawing.Size(35, 44);
            this.ClipCountLabel.TabIndex = 6;
            this.ClipCountLabel.Text = "2";
            this.ClipCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClipCountLabelLabel
            // 
            this.ClipCountLabelLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClipCountLabelLabel.Location = new System.Drawing.Point(50, 4);
            this.ClipCountLabelLabel.Name = "ClipCountLabelLabel";
            this.ClipCountLabelLabel.Size = new System.Drawing.Size(92, 44);
            this.ClipCountLabelLabel.TabIndex = 5;
            this.ClipCountLabelLabel.Text = "Clips";
            this.ClipCountLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClipsContainer
            // 
            this.ClipsContainer.AutoScroll = true;
            this.ClipsContainer.BackColor = System.Drawing.Color.LightBlue;
            this.ClipsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClipsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClipsContainer.Location = new System.Drawing.Point(3, 63);
            this.ClipsContainer.Name = "ClipsContainer";
            this.ClipsContainer.Size = new System.Drawing.Size(1140, 224);
            this.ClipsContainer.TabIndex = 9;
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.ColumnCount = 2;
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultsPanel.Controls.Add(this.GeneratedCodePanel, 1, 0);
            this.ResultsPanel.Controls.Add(this.SimulationPanel, 0, 0);
            this.ResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsPanel.Location = new System.Drawing.Point(0, 290);
            this.ResultsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.RowCount = 1;
            this.ResultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultsPanel.Size = new System.Drawing.Size(1146, 505);
            this.ResultsPanel.TabIndex = 10;
            // 
            // GeneratedCodePanel
            // 
            this.GeneratedCodePanel.Controls.Add(this.ResultTextbox);
            this.GeneratedCodePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratedCodePanel.Location = new System.Drawing.Point(363, 3);
            this.GeneratedCodePanel.Name = "GeneratedCodePanel";
            this.GeneratedCodePanel.Size = new System.Drawing.Size(780, 499);
            this.GeneratedCodePanel.TabIndex = 1;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextbox.Location = new System.Drawing.Point(0, 0);
            this.ResultTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.ResultTextbox.Multiline = true;
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(780, 499);
            this.ResultTextbox.TabIndex = 0;
            // 
            // SimulationPanel
            // 
            this.SimulationPanel.ColumnCount = 1;
            this.SimulationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SimulationPanel.Controls.Add(this.SimulationMatrixPanel, 0, 0);
            this.SimulationPanel.Controls.Add(this.SimulationSpeedPanel, 0, 1);
            this.SimulationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationPanel.Location = new System.Drawing.Point(3, 3);
            this.SimulationPanel.Name = "SimulationPanel";
            this.SimulationPanel.RowCount = 2;
            this.SimulationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.SimulationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SimulationPanel.Size = new System.Drawing.Size(354, 499);
            this.SimulationPanel.TabIndex = 2;
            // 
            // SimulationMatrixPanel
            // 
            this.SimulationMatrixPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimulationMatrixPanel.Controls.Add(this.SimulationMatrix);
            this.SimulationMatrixPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationMatrixPanel.Location = new System.Drawing.Point(0, 0);
            this.SimulationMatrixPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SimulationMatrixPanel.Name = "SimulationMatrixPanel";
            this.SimulationMatrixPanel.Size = new System.Drawing.Size(354, 360);
            this.SimulationMatrixPanel.TabIndex = 0;
            // 
            // SimulationMatrix
            // 
            this.SimulationMatrix.Content = new byte[] {
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0))};
            this.SimulationMatrix.Location = new System.Drawing.Point(17, 17);
            this.SimulationMatrix.Margin = new System.Windows.Forms.Padding(0);
            this.SimulationMatrix.Name = "SimulationMatrix";
            this.SimulationMatrix.ReadOnly = true;
            this.SimulationMatrix.ShowActionButtons = false;
            this.SimulationMatrix.Size = new System.Drawing.Size(320, 320);
            this.SimulationMatrix.TabIndex = 0;
            // 
            // SimulationSpeedPanel
            // 
            this.SimulationSpeedPanel.Controls.Add(this.EightSpeedRadioButton);
            this.SimulationSpeedPanel.Controls.Add(this.QuadSpeedRadioButton);
            this.SimulationSpeedPanel.Controls.Add(this.DoubleSpeedRadioButton);
            this.SimulationSpeedPanel.Controls.Add(this.NormalSpeedRadioButton);
            this.SimulationSpeedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationSpeedPanel.Location = new System.Drawing.Point(3, 363);
            this.SimulationSpeedPanel.Name = "SimulationSpeedPanel";
            this.SimulationSpeedPanel.Size = new System.Drawing.Size(348, 133);
            this.SimulationSpeedPanel.TabIndex = 1;
            // 
            // EightSpeedRadioButton
            // 
            this.EightSpeedRadioButton.AutoSize = true;
            this.EightSpeedRadioButton.Location = new System.Drawing.Point(205, 14);
            this.EightSpeedRadioButton.Name = "EightSpeedRadioButton";
            this.EightSpeedRadioButton.Size = new System.Drawing.Size(58, 29);
            this.EightSpeedRadioButton.TabIndex = 3;
            this.EightSpeedRadioButton.TabStop = true;
            this.EightSpeedRadioButton.Tag = "8";
            this.EightSpeedRadioButton.Text = "8x";
            this.EightSpeedRadioButton.UseVisualStyleBackColor = true;
            this.EightSpeedRadioButton.CheckedChanged += new System.EventHandler(this.SpeedRadioButton_CheckedChanged);
            // 
            // QuadSpeedRadioButton
            // 
            this.QuadSpeedRadioButton.AutoSize = true;
            this.QuadSpeedRadioButton.Location = new System.Drawing.Point(141, 14);
            this.QuadSpeedRadioButton.Name = "QuadSpeedRadioButton";
            this.QuadSpeedRadioButton.Size = new System.Drawing.Size(58, 29);
            this.QuadSpeedRadioButton.TabIndex = 2;
            this.QuadSpeedRadioButton.TabStop = true;
            this.QuadSpeedRadioButton.Tag = "4";
            this.QuadSpeedRadioButton.Text = "4x";
            this.QuadSpeedRadioButton.UseVisualStyleBackColor = true;
            this.QuadSpeedRadioButton.CheckedChanged += new System.EventHandler(this.SpeedRadioButton_CheckedChanged);
            // 
            // DoubleSpeedRadioButton
            // 
            this.DoubleSpeedRadioButton.AutoSize = true;
            this.DoubleSpeedRadioButton.Location = new System.Drawing.Point(77, 14);
            this.DoubleSpeedRadioButton.Name = "DoubleSpeedRadioButton";
            this.DoubleSpeedRadioButton.Size = new System.Drawing.Size(58, 29);
            this.DoubleSpeedRadioButton.TabIndex = 1;
            this.DoubleSpeedRadioButton.TabStop = true;
            this.DoubleSpeedRadioButton.Tag = "2";
            this.DoubleSpeedRadioButton.Text = "2x";
            this.DoubleSpeedRadioButton.UseVisualStyleBackColor = true;
            this.DoubleSpeedRadioButton.CheckedChanged += new System.EventHandler(this.SpeedRadioButton_CheckedChanged);
            // 
            // NormalSpeedRadioButton
            // 
            this.NormalSpeedRadioButton.AutoSize = true;
            this.NormalSpeedRadioButton.Checked = true;
            this.NormalSpeedRadioButton.Location = new System.Drawing.Point(14, 14);
            this.NormalSpeedRadioButton.Name = "NormalSpeedRadioButton";
            this.NormalSpeedRadioButton.Size = new System.Drawing.Size(58, 29);
            this.NormalSpeedRadioButton.TabIndex = 0;
            this.NormalSpeedRadioButton.TabStop = true;
            this.NormalSpeedRadioButton.Tag = "1";
            this.NormalSpeedRadioButton.Text = "1x";
            this.NormalSpeedRadioButton.UseVisualStyleBackColor = true;
            this.NormalSpeedRadioButton.CheckedChanged += new System.EventHandler(this.SpeedRadioButton_CheckedChanged);
            // 
            // ToolTip
            // 
            this.ToolTip.IsBalloon = true;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "mtx";
            this.SaveFileDialog.Filter = "Matrix Files (*.mtx)|*.mtx";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "mtx";
            this.OpenFileDialog.Filter = "Matrix Files (*.mtx)|*.mtx";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1146, 795);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.ResultsPanel.ResumeLayout(false);
            this.GeneratedCodePanel.ResumeLayout(false);
            this.GeneratedCodePanel.PerformLayout();
            this.SimulationPanel.ResumeLayout(false);
            this.SimulationMatrixPanel.ResumeLayout(false);
            this.SimulationSpeedPanel.ResumeLayout(false);
            this.SimulationSpeedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.Button RemoveClipButton;
        private System.Windows.Forms.Button AddClipButton;
        private System.Windows.Forms.Label ClipCountLabel;
        private System.Windows.Forms.Label ClipCountLabelLabel;
        private System.Windows.Forms.Panel ClipsContainer;
        private System.Windows.Forms.Button GenerateCodeButton;
        private System.Windows.Forms.TableLayoutPanel ResultsPanel;
        private System.Windows.Forms.Panel GeneratedCodePanel;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button PlayButton;
        private LedMatrix SimulationMatrix;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button AddCopyButton;
        private System.Windows.Forms.TableLayoutPanel SimulationPanel;
        private System.Windows.Forms.Panel SimulationMatrixPanel;
        private System.Windows.Forms.Panel SimulationSpeedPanel;
        private System.Windows.Forms.RadioButton NormalSpeedRadioButton;
        private System.Windows.Forms.RadioButton DoubleSpeedRadioButton;
        private System.Windows.Forms.RadioButton QuadSpeedRadioButton;
        private System.Windows.Forms.RadioButton EightSpeedRadioButton;
    }
}

