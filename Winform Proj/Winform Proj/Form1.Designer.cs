
namespace Winform_Proj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSlot1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSlot2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSlot3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.numRowLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.colBox = new System.Windows.Forms.TextBox();
            this.mineBox = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.PlaySavedGamesBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.newGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSlot1ToolStripMenuItem,
            this.saveSlot2ToolStripMenuItem,
            this.saveSlot3ToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveSlot1ToolStripMenuItem
            // 
            this.saveSlot1ToolStripMenuItem.Name = "saveSlot1ToolStripMenuItem";
            this.saveSlot1ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveSlot1ToolStripMenuItem.Text = "Save Slot 1";
            this.saveSlot1ToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // saveSlot2ToolStripMenuItem
            // 
            this.saveSlot2ToolStripMenuItem.Name = "saveSlot2ToolStripMenuItem";
            this.saveSlot2ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveSlot2ToolStripMenuItem.Text = "Save Slot 2";
            this.saveSlot2ToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // saveSlot3ToolStripMenuItem
            // 
            this.saveSlot3ToolStripMenuItem.Name = "saveSlot3ToolStripMenuItem";
            this.saveSlot3ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveSlot3ToolStripMenuItem.Text = "Save Slot 3";
            this.saveSlot3ToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeBox
            // 
            this.TimeBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeBox.Enabled = false;
            this.TimeBox.Location = new System.Drawing.Point(348, 0);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(100, 22);
            this.TimeBox.TabIndex = 1;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "flag.ico");
            this.imageList1.Images.SetKeyName(1, "Icon1.ico");
            // 
            // numRowLabel
            // 
            this.numRowLabel.AutoSize = true;
            this.numRowLabel.Location = new System.Drawing.Point(12, 55);
            this.numRowLabel.Name = "numRowLabel";
            this.numRowLabel.Size = new System.Drawing.Size(204, 17);
            this.numRowLabel.TabIndex = 2;
            this.numRowLabel.Text = "Number of Rows (Maximum 60)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Columns (Maximum 60)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Mines (Maximum 3500)";
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(297, 50);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(100, 22);
            this.rowBox.TabIndex = 5;
            this.rowBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // colBox
            // 
            this.colBox.Location = new System.Drawing.Point(297, 91);
            this.colBox.Name = "colBox";
            this.colBox.Size = new System.Drawing.Size(100, 22);
            this.colBox.TabIndex = 6;
            this.colBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // mineBox
            // 
            this.mineBox.Location = new System.Drawing.Point(297, 128);
            this.mineBox.Name = "mineBox";
            this.mineBox.Size = new System.Drawing.Size(100, 22);
            this.mineBox.TabIndex = 7;
            this.mineBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(297, 192);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 8;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // PlaySavedGamesBox
            // 
            this.PlaySavedGamesBox.FormattingEnabled = true;
            this.PlaySavedGamesBox.Location = new System.Drawing.Point(297, 244);
            this.PlaySavedGamesBox.MaxDropDownItems = 3;
            this.PlaySavedGamesBox.Name = "PlaySavedGamesBox";
            this.PlaySavedGamesBox.Size = new System.Drawing.Size(179, 24);
            this.PlaySavedGamesBox.TabIndex = 9;
            this.PlaySavedGamesBox.Text = "Play Saved Games...";
            this.PlaySavedGamesBox.Click += new System.EventHandler(this.PlaySavedGamesBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 773);
            this.Controls.Add(this.PlaySavedGamesBox);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.mineBox);
            this.Controls.Add(this.colBox);
            this.Controls.Add(this.rowBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRowLabel);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox TimeBox;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Label numRowLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.TextBox colBox;
        private System.Windows.Forms.TextBox mineBox;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.ToolStripMenuItem saveSlot1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSlot2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSlot3ToolStripMenuItem;
        private System.Windows.Forms.ComboBox PlaySavedGamesBox;
    }
}

