namespace Lvl_2_Math_Project
{
    partial class Snake
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.SpeedUp = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.SpeedDown = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Levels = new System.Windows.Forms.MenuStrip();
            this.changeColorOfTheSnakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTheScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.RGB = new System.Windows.Forms.Timer(this.components);
            this.RGBFood = new System.Windows.Forms.Timer(this.components);
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.Levels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.SpeedUp);
            this.panel2.Controls.Add(this.lblLength);
            this.panel2.Controls.Add(this.SpeedDown);
            this.panel2.Controls.Add(this.lblSpeed);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblScore);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(923, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 661);
            this.panel2.TabIndex = 34;
            // 
            // SpeedUp
            // 
            this.SpeedUp.BackColor = System.Drawing.Color.Black;
            this.SpeedUp.Image = global::Lvl_2_Math_Project.Properties.Resources.Rightb;
            this.SpeedUp.Location = new System.Drawing.Point(110, 235);
            this.SpeedUp.Name = "SpeedUp";
            this.SpeedUp.Size = new System.Drawing.Size(64, 64);
            this.SpeedUp.TabIndex = 44;
            this.SpeedUp.TabStop = false;
            this.SpeedUp.UseVisualStyleBackColor = false;
            this.SpeedUp.Click += new System.EventHandler(this.SpeedUp_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLength.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLength.Location = new System.Drawing.Point(27, 72);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(86, 24);
            this.lblLength.TabIndex = 43;
            this.lblLength.Text = "Length:";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedDown
            // 
            this.SpeedDown.BackColor = System.Drawing.Color.Black;
            this.SpeedDown.Image = global::Lvl_2_Math_Project.Properties.Resources.Leftb1;
            this.SpeedDown.Location = new System.Drawing.Point(25, 235);
            this.SpeedDown.Name = "SpeedDown";
            this.SpeedDown.Size = new System.Drawing.Size(64, 64);
            this.SpeedDown.TabIndex = 43;
            this.SpeedDown.TabStop = false;
            this.SpeedDown.UseVisualStyleBackColor = false;
            this.SpeedDown.Click += new System.EventHandler(this.SpeedDown_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSpeed.Location = new System.Drawing.Point(27, 29);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(99, 24);
            this.lblSpeed.TabIndex = 42;
            this.lblSpeed.Text = "Speed: 1";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 72);
            this.label7.TabIndex = 42;
            this.label7.Text = "Change speed:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(27, 119);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(73, 24);
            this.lblScore.TabIndex = 41;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 149);
            this.label10.TabIndex = 40;
            this.label10.Text = "Snake";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(370, 536);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(183, 54);
            this.Start.TabIndex = 37;
            this.Start.TabStop = false;
            this.Start.Text = "Play";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Levels
            // 
            this.Levels.Dock = System.Windows.Forms.DockStyle.None;
            this.Levels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorOfTheSnakeToolStripMenuItem,
            this.saveTheScoreToolStripMenuItem});
            this.Levels.Location = new System.Drawing.Point(0, 0);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(495, 32);
            this.Levels.TabIndex = 38;
            this.Levels.Text = "menuStrip1";
            // 
            // changeColorOfTheSnakeToolStripMenuItem
            // 
            this.changeColorOfTheSnakeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.changeColorOfTheSnakeToolStripMenuItem.Name = "changeColorOfTheSnakeToolStripMenuItem";
            this.changeColorOfTheSnakeToolStripMenuItem.Size = new System.Drawing.Size(312, 28);
            this.changeColorOfTheSnakeToolStripMenuItem.Text = "Change colour of the snake";
            this.changeColorOfTheSnakeToolStripMenuItem.Click += new System.EventHandler(this.changeColorOfTheSnakeToolStripMenuItem_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "label3";
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.White;
            this.lblGameOver.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Black;
            this.lblGameOver.Location = new System.Drawing.Point(320, 189);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(324, 181);
            this.lblGameOver.TabIndex = 45;
            this.lblGameOver.Text = "Game Over. Press Enter or Play to start again";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RGB
            // 
            this.RGB.Interval = 1000;
            this.RGB.Tick += new System.EventHandler(this.RGB_Tick);
            // 
            // RGBFood
            // 
            this.RGBFood.Interval = 1000;
            this.RGBFood.Tick += new System.EventHandler(this.RGBFood_Tick);
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.White;
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCanvas.Location = new System.Drawing.Point(93, 72);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(736, 417);
            this.pbCanvas.TabIndex = 35;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.Levels);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGameOver);
            this.Name = "Snake";
            this.Size = new System.Drawing.Size(1118, 661);
            this.Load += new System.EventHandler(this.Snake_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Levels.ResumeLayout(false);
            this.Levels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip Levels;
        private System.Windows.Forms.ToolStripMenuItem saveTheScoreToolStripMenuItem;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button SpeedUp;
        private System.Windows.Forms.Button SpeedDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ToolStripMenuItem changeColorOfTheSnakeToolStripMenuItem;
        private System.Windows.Forms.Timer RGB;
        private System.Windows.Forms.Timer RGBFood;
    }
}
