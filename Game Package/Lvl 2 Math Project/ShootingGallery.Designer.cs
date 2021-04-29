namespace Lvl_2_Math_Project
{
    partial class ShootingGallery
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShootingGallery));
            this.label1 = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RightTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Levels = new System.Windows.Forms.MenuStrip();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTheScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.SpeedUp = new System.Windows.Forms.Button();
            this.SpeedDown = new System.Windows.Forms.Button();
            this.TargetUp = new System.Windows.Forms.Button();
            this.TargetDown = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Levels.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Location = new System.Drawing.Point(107, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 350);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Random
            // 
            this.Random.Interval = 1000;
            this.Random.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Speed: 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(27, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Targets: 5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(370, 536);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(183, 54);
            this.Start.TabIndex = 18;
            this.Start.TabStop = false;
            this.Start.Text = "Choose a level";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hits:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightTimer
            // 
            this.RightTimer.Interval = 1;
            this.RightTimer.Tick += new System.EventHandler(this.RightTimer_Tick);
            // 
            // LeftTimer
            // 
            this.LeftTimer.Interval = 1;
            this.LeftTimer.Tick += new System.EventHandler(this.LeftTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(33, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 28;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Levels
            // 
            this.Levels.Dock = System.Windows.Forms.DockStyle.None;
            this.Levels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem,
            this.saveTheScoreToolStripMenuItem});
            this.Levels.Location = new System.Drawing.Point(0, 0);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(261, 32);
            this.Levels.TabIndex = 29;
            this.Levels.Text = "menuStrip1";
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level1ToolStripMenuItem,
            this.level2ToolStripMenuItem});
            this.levelToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // level1ToolStripMenuItem
            // 
            this.level1ToolStripMenuItem.Name = "level1ToolStripMenuItem";
            this.level1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.level1ToolStripMenuItem.Size = new System.Drawing.Size(470, 28);
            this.level1ToolStripMenuItem.Text = "Level 1 (Random locations)";
            this.level1ToolStripMenuItem.Click += new System.EventHandler(this.level1ToolStripMenuItem_Click);
            this.level1ToolStripMenuItem.MouseLeave += new System.EventHandler(this.level1ToolStripMenuItem_MouseLeave);
            this.level1ToolStripMenuItem.MouseHover += new System.EventHandler(this.level1ToolStripMenuItem_MouseHover);
            // 
            // level2ToolStripMenuItem
            // 
            this.level2ToolStripMenuItem.Name = "level2ToolStripMenuItem";
            this.level2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.level2ToolStripMenuItem.Size = new System.Drawing.Size(470, 28);
            this.level2ToolStripMenuItem.Text = "Level 2 (Consistent movement)";
            this.level2ToolStripMenuItem.Click += new System.EventHandler(this.level2ToolStripMenuItem_Click);
            this.level2ToolStripMenuItem.MouseLeave += new System.EventHandler(this.level2ToolStripMenuItem_MouseLeave);
            this.level2ToolStripMenuItem.MouseHover += new System.EventHandler(this.level2ToolStripMenuItem_MouseHover);
            // 
            // saveTheScoreToolStripMenuItem
            // 
            this.saveTheScoreToolStripMenuItem.Enabled = false;
            this.saveTheScoreToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.saveTheScoreToolStripMenuItem.Name = "saveTheScoreToolStripMenuItem";
            this.saveTheScoreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTheScoreToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.saveTheScoreToolStripMenuItem.Text = "Save the score";
            this.saveTheScoreToolStripMenuItem.Click += new System.EventHandler(this.saveTheScoreToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.SpeedUp);
            this.panel2.Controls.Add(this.SpeedDown);
            this.panel2.Controls.Add(this.TargetUp);
            this.panel2.Controls.Add(this.TargetDown);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(923, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 661);
            this.panel2.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 149);
            this.label10.TabIndex = 39;
            this.label10.Text = "Shooting Gallery";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedUp
            // 
            this.SpeedUp.BackColor = System.Drawing.Color.Black;
            this.SpeedUp.Enabled = false;
            this.SpeedUp.Image = global::Lvl_2_Math_Project.Properties.Resources.Rightb;
            this.SpeedUp.Location = new System.Drawing.Point(110, 235);
            this.SpeedUp.Name = "SpeedUp";
            this.SpeedUp.Size = new System.Drawing.Size(64, 64);
            this.SpeedUp.TabIndex = 41;
            this.SpeedUp.TabStop = false;
            this.SpeedUp.UseVisualStyleBackColor = false;
            this.SpeedUp.Click += new System.EventHandler(this.SpeedUp_Click);
            // 
            // SpeedDown
            // 
            this.SpeedDown.BackColor = System.Drawing.Color.Black;
            this.SpeedDown.Enabled = false;
            this.SpeedDown.Image = global::Lvl_2_Math_Project.Properties.Resources.Leftb1;
            this.SpeedDown.Location = new System.Drawing.Point(25, 235);
            this.SpeedDown.Name = "SpeedDown";
            this.SpeedDown.Size = new System.Drawing.Size(64, 64);
            this.SpeedDown.TabIndex = 40;
            this.SpeedDown.TabStop = false;
            this.SpeedDown.UseVisualStyleBackColor = false;
            this.SpeedDown.Click += new System.EventHandler(this.SpeedDown_Click);
            // 
            // TargetUp
            // 
            this.TargetUp.BackColor = System.Drawing.Color.Black;
            this.TargetUp.Enabled = false;
            this.TargetUp.Image = global::Lvl_2_Math_Project.Properties.Resources.Upb;
            this.TargetUp.Location = new System.Drawing.Point(110, 389);
            this.TargetUp.Name = "TargetUp";
            this.TargetUp.Size = new System.Drawing.Size(64, 64);
            this.TargetUp.TabIndex = 39;
            this.TargetUp.TabStop = false;
            this.TargetUp.UseVisualStyleBackColor = false;
            this.TargetUp.Click += new System.EventHandler(this.TargetUp_Click);
            // 
            // TargetDown
            // 
            this.TargetDown.BackColor = System.Drawing.Color.Black;
            this.TargetDown.Enabled = false;
            this.TargetDown.Image = global::Lvl_2_Math_Project.Properties.Resources.Downb;
            this.TargetDown.Location = new System.Drawing.Point(25, 389);
            this.TargetDown.Name = "TargetDown";
            this.TargetDown.Size = new System.Drawing.Size(64, 64);
            this.TargetDown.TabIndex = 33;
            this.TargetDown.TabStop = false;
            this.TargetDown.UseVisualStyleBackColor = false;
            this.TargetDown.Click += new System.EventHandler(this.TargetDown_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(1, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 81);
            this.label8.TabIndex = 38;
            this.label8.Text = "Change number of targets:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 72);
            this.label7.TabIndex = 37;
            this.label7.Text = "Change speed:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(599, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "label9";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Lvl_2_Math_Project.Properties.Resources.Level_2;
            this.pictureBox9.Location = new System.Drawing.Point(478, 61);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(350, 175);
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Lvl_2_Math_Project.Properties.Resources.Level_1;
            this.pictureBox8.Location = new System.Drawing.Point(478, 29);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(350, 175);
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(113, 408);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(752, 338);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(113, 268);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(752, 198);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(113, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(441, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ShootingGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Levels);
            this.Controls.Add(this.label9);
            this.Name = "ShootingGallery";
            this.Size = new System.Drawing.Size(1118, 661);
            this.Levels.ResumeLayout(false);
            this.Levels.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer RightTimer;
        private System.Windows.Forms.Timer LeftTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip Levels;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level2ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button TargetDown;
        private System.Windows.Forms.Button SpeedUp;
        private System.Windows.Forms.Button SpeedDown;
        private System.Windows.Forms.Button TargetUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem saveTheScoreToolStripMenuItem;
        private System.Windows.Forms.Label label10;
    }
}
