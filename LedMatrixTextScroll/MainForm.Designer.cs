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
            this.InputText = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ActionsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainLayoutPanel.SuspendLayout();
            this.ActionsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.Location = new System.Drawing.Point(3, 3);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(1155, 48);
            this.InputText.TabIndex = 1;
            this.InputText.WordWrap = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateButton.Location = new System.Drawing.Point(1164, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(154, 48);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Controls.Add(this.ResultTextBox, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.ActionsLayoutPanel, 0, 0);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(1327, 857);
            this.MainLayoutPanel.TabIndex = 4;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.Font = new System.Drawing.Font("Courier New", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(6, 60);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(1315, 791);
            this.ResultTextBox.TabIndex = 3;
            // 
            // ActionsLayoutPanel
            // 
            this.ActionsLayoutPanel.ColumnCount = 2;
            this.ActionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ActionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.ActionsLayoutPanel.Controls.Add(this.InputText, 0, 0);
            this.ActionsLayoutPanel.Controls.Add(this.GenerateButton, 1, 0);
            this.ActionsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ActionsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ActionsLayoutPanel.Name = "ActionsLayoutPanel";
            this.ActionsLayoutPanel.RowCount = 1;
            this.ActionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ActionsLayoutPanel.Size = new System.Drawing.Size(1321, 54);
            this.ActionsLayoutPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1327, 857);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.ActionsLayoutPanel.ResumeLayout(false);
            this.ActionsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TableLayoutPanel ActionsLayoutPanel;
    }
}

