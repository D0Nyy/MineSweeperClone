
namespace Mines
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.boardPanel = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelBombs = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxDiff = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBombCount = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonRestart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.Color.LightGray;
            this.boardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardPanel.Location = new System.Drawing.Point(10, 55);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(500, 500);
            this.boardPanel.TabIndex = 0;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.labelSize);
            this.panelSettings.Controls.Add(this.labelBombs);
            this.panelSettings.Controls.Add(this.pictureBox2);
            this.panelSettings.Controls.Add(this.buttonStart);
            this.panelSettings.Controls.Add(this.comboBoxDiff);
            this.panelSettings.Location = new System.Drawing.Point(29, 85);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(461, 445);
            this.panelSettings.TabIndex = 0;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Comic Sans MS", 26.25F);
            this.labelSize.Location = new System.Drawing.Point(173, 215);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(117, 49);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "10x10";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBombs
            // 
            this.labelBombs.AutoSize = true;
            this.labelBombs.Font = new System.Drawing.Font("Comic Sans MS", 26.25F);
            this.labelBombs.Location = new System.Drawing.Point(176, 134);
            this.labelBombs.Name = "labelBombs";
            this.labelBombs.Size = new System.Drawing.Size(38, 49);
            this.labelBombs.TabIndex = 4;
            this.labelBombs.Text = "1";
            this.labelBombs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(247, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.buttonStart.Location = new System.Drawing.Point(199, 264);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(66, 36);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Play";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxDiff
            // 
            this.comboBoxDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiff.FormattingEnabled = true;
            this.comboBoxDiff.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.comboBoxDiff.Location = new System.Drawing.Point(181, 192);
            this.comboBoxDiff.Name = "comboBoxDiff";
            this.comboBoxDiff.Size = new System.Drawing.Size(104, 21);
            this.comboBoxDiff.TabIndex = 0;
            this.comboBoxDiff.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiff_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelBombCount
            // 
            this.labelBombCount.AutoSize = true;
            this.labelBombCount.Font = new System.Drawing.Font("Comic Sans MS", 26.25F);
            this.labelBombCount.Location = new System.Drawing.Point(12, 3);
            this.labelBombCount.Name = "labelBombCount";
            this.labelBombCount.Size = new System.Drawing.Size(38, 49);
            this.labelBombCount.TabIndex = 2;
            this.labelBombCount.Text = "1";
            this.labelBombCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 26.25F);
            this.labelTime.Location = new System.Drawing.Point(467, 4);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 49);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "0";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.Enabled = false;
            this.buttonRestart.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.buttonRestart.Location = new System.Drawing.Point(214, 8);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(83, 43);
            this.buttonRestart.TabIndex = 6;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRestart);
            this.panel1.Controls.Add(this.labelBombCount);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 55);
            this.panel1.TabIndex = 7;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.boardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBombCount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelBombs;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxDiff;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Panel panel1;
    }
}

