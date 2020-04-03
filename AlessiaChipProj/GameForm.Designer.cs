namespace AlessiaChipProj
{
    partial class GameForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timeTextLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.chipsRTextLabel = new System.Windows.Forms.Label();
            this.chipsRLabel = new System.Windows.Forms.Label();
            this.chipsCTextLabel = new System.Windows.Forms.Label();
            this.chipsCLabel = new System.Windows.Forms.Label();
            this.tilePanel = new System.Windows.Forms.TableLayoutPanel();
            this.secondsTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuBarFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(509, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // timeTextLabel
            // 
            this.timeTextLabel.AutoSize = true;
            this.timeTextLabel.Location = new System.Drawing.Point(480, 62);
            this.timeTextLabel.Name = "timeTextLabel";
            this.timeTextLabel.Size = new System.Drawing.Size(97, 13);
            this.timeTextLabel.TabIndex = 2;
            this.timeTextLabel.Text = "TIME REMAINING";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(515, 80);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(25, 13);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "100";
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(480, 100);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(94, 23);
            this.timeBar.TabIndex = 4;
            // 
            // chipsRTextLabel
            // 
            this.chipsRTextLabel.AutoSize = true;
            this.chipsRTextLabel.Location = new System.Drawing.Point(477, 137);
            this.chipsRTextLabel.Name = "chipsRTextLabel";
            this.chipsRTextLabel.Size = new System.Drawing.Size(103, 13);
            this.chipsRTextLabel.TabIndex = 5;
            this.chipsRTextLabel.Text = "CHIPS REMAINING";
            // 
            // chipsRLabel
            // 
            this.chipsRLabel.AutoSize = true;
            this.chipsRLabel.Location = new System.Drawing.Point(520, 158);
            this.chipsRLabel.Name = "chipsRLabel";
            this.chipsRLabel.Size = new System.Drawing.Size(19, 13);
            this.chipsRLabel.TabIndex = 6;
            this.chipsRLabel.Text = "10";
            // 
            // chipsCTextLabel
            // 
            this.chipsCTextLabel.AutoSize = true;
            this.chipsCTextLabel.Location = new System.Drawing.Point(477, 194);
            this.chipsCTextLabel.Name = "chipsCTextLabel";
            this.chipsCTextLabel.Size = new System.Drawing.Size(105, 13);
            this.chipsCTextLabel.TabIndex = 7;
            this.chipsCTextLabel.Text = "CHIPS COLLECTED";
            // 
            // chipsCLabel
            // 
            this.chipsCLabel.AutoSize = true;
            this.chipsCLabel.Location = new System.Drawing.Point(524, 214);
            this.chipsCLabel.Name = "chipsCLabel";
            this.chipsCLabel.Size = new System.Drawing.Size(13, 13);
            this.chipsCLabel.TabIndex = 8;
            this.chipsCLabel.Text = "0";
            // 
            // tilePanel
            // 
            this.tilePanel.ColumnCount = 9;
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.Location = new System.Drawing.Point(12, 32);
            this.tilePanel.Name = "tilePanel";
            this.tilePanel.RowCount = 9;
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tilePanel.Size = new System.Drawing.Size(400, 400);
            this.tilePanel.TabIndex = 9;
            // 
            // secondsTimer
            // 
            this.secondsTimer.Enabled = true;
            this.secondsTimer.Interval = 1000;
            this.secondsTimer.Tick += new System.EventHandler(this.secondsTimer_Tick);
            // 
            // gameTick
            // 
            this.gameTick.Enabled = true;
            this.gameTick.Interval = 75;
            this.gameTick.Tick += new System.EventHandler(this.gameTick_Tick);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarFile,
            this.menuBarLevel});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(667, 24);
            this.menuBar.TabIndex = 10;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuBarFile
            // 
            this.menuBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuBarFile.Name = "menuBarFile";
            this.menuBarFile.Size = new System.Drawing.Size(122, 20);
            this.menuBarFile.Text = "File";
            // 
            // menuBarLevel
            // 
            this.menuBarLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterPasswordToolStripMenuItem});
            this.menuBarLevel.Name = "menuBarLevel";
            this.menuBarLevel.Size = new System.Drawing.Size(46, 20);
            this.menuBarLevel.Text = "Level";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // enterPasswordToolStripMenuItem
            // 
            this.enterPasswordToolStripMenuItem.Name = "enterPasswordToolStripMenuItem";
            this.enterPasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enterPasswordToolStripMenuItem.Text = "Enter Password";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 444);
            this.Controls.Add(this.tilePanel);
            this.Controls.Add(this.chipsCLabel);
            this.Controls.Add(this.chipsCTextLabel);
            this.Controls.Add(this.chipsRLabel);
            this.Controls.Add(this.chipsRTextLabel);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeTextLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "GameForm";
            this.Text = "Chips Challenge - Alessia";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label timeTextLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.Label chipsRTextLabel;
        private System.Windows.Forms.Label chipsRLabel;
        private System.Windows.Forms.Label chipsCTextLabel;
        private System.Windows.Forms.Label chipsCLabel;
        private System.Windows.Forms.TableLayoutPanel tilePanel;
        private System.Windows.Forms.Timer secondsTimer;
        private System.Windows.Forms.Timer gameTick;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuBarFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBarLevel;
        private System.Windows.Forms.ToolStripMenuItem enterPasswordToolStripMenuItem;
    }
}

