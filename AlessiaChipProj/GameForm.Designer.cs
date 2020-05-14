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
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
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
            this.timeTextLabel.Location = new System.Drawing.Point(455, 46);
            this.timeTextLabel.Name = "timeTextLabel";
            this.timeTextLabel.Size = new System.Drawing.Size(97, 13);
            this.timeTextLabel.TabIndex = 2;
            this.timeTextLabel.Text = "TIME REMAINING";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(489, 91);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(25, 13);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "100";
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(457, 63);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(94, 23);
            this.timeBar.TabIndex = 4;
            // 
            // chipsRTextLabel
            // 
            this.chipsRTextLabel.AutoSize = true;
            this.chipsRTextLabel.Location = new System.Drawing.Point(455, 120);
            this.chipsRTextLabel.Name = "chipsRTextLabel";
            this.chipsRTextLabel.Size = new System.Drawing.Size(103, 13);
            this.chipsRTextLabel.TabIndex = 5;
            this.chipsRTextLabel.Text = "CHIPS REMAINING";
            // 
            // chipsRLabel
            // 
            this.chipsRLabel.AutoSize = true;
            this.chipsRLabel.Location = new System.Drawing.Point(495, 139);
            this.chipsRLabel.Name = "chipsRLabel";
            this.chipsRLabel.Size = new System.Drawing.Size(19, 13);
            this.chipsRLabel.TabIndex = 6;
            this.chipsRLabel.Text = "10";
            // 
            // chipsCTextLabel
            // 
            this.chipsCTextLabel.AutoSize = true;
            this.chipsCTextLabel.Location = new System.Drawing.Point(455, 172);
            this.chipsCTextLabel.Name = "chipsCTextLabel";
            this.chipsCTextLabel.Size = new System.Drawing.Size(105, 13);
            this.chipsCTextLabel.TabIndex = 7;
            this.chipsCTextLabel.Text = "CHIPS COLLECTED";
            // 
            // chipsCLabel
            // 
            this.chipsCLabel.AutoSize = true;
            this.chipsCLabel.Location = new System.Drawing.Point(499, 192);
            this.chipsCLabel.Name = "chipsCLabel";
            this.chipsCLabel.Size = new System.Drawing.Size(13, 13);
            this.chipsCLabel.TabIndex = 8;
            this.chipsCLabel.Text = "0";
            // 
            // tilePanel
            // 
            this.tilePanel.BackColor = System.Drawing.Color.LightGray;
            this.tilePanel.ColumnCount = 9;
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.Location = new System.Drawing.Point(20, 44);
            this.tilePanel.Name = "tilePanel";
            this.tilePanel.RowCount = 9;
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tilePanel.Size = new System.Drawing.Size(387, 387);
            this.tilePanel.TabIndex = 9;
            // 
            // secondsTimer
            // 
            this.secondsTimer.Interval = 1000;
            this.secondsTimer.Tick += new System.EventHandler(this.secondsTimer_Tick);
            // 
            // gameTick
            // 
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
            this.menuBar.Size = new System.Drawing.Size(600, 24);
            this.menuBar.TabIndex = 10;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuBarFile
            // 
            this.menuBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuBarFile.Name = "menuBarFile";
            this.menuBarFile.Size = new System.Drawing.Size(37, 20);
            this.menuBarFile.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuBarLevel
            // 
            this.menuBarLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.enterPasswordToolStripMenuItem});
            this.menuBarLevel.Name = "menuBarLevel";
            this.menuBarLevel.Size = new System.Drawing.Size(46, 20);
            this.menuBarLevel.Text = "Level";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // enterPasswordToolStripMenuItem
            // 
            this.enterPasswordToolStripMenuItem.Name = "enterPasswordToolStripMenuItem";
            this.enterPasswordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.enterPasswordToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.enterPasswordToolStripMenuItem.Text = "Enter Password";
            this.enterPasswordToolStripMenuItem.Click += new System.EventHandler(this.enterPasswordToolStripMenuItem_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(470, 258);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(70, 13);
            this.inventoryLabel.TabIndex = 11;
            this.inventoryLabel.Text = "INVENTORY";
            // 
            // hintLabel
            // 
            this.hintLabel.Location = new System.Drawing.Point(433, 382);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(150, 50);
            this.hintLabel.TabIndex = 12;
            this.hintLabel.Text = "Hint:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlessiaChipProj.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.inventoryLabel);
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
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label hintLabel;
    }
}

