namespace Lvl_2_Math_Project
{
    partial class SnakeColour
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadLbl = new System.Windows.Forms.Label();
            this.BodyLbl = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 44);
            this.label7.TabIndex = 40;
            this.label7.Text = "Your custom snake:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-7, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 44);
            this.label1.TabIndex = 41;
            this.label1.Text = "Head:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(131, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 44);
            this.label2.TabIndex = 42;
            this.label2.Text = "Body:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadLbl
            // 
            this.HeadLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeadLbl.Location = new System.Drawing.Point(87, 125);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(40, 40);
            this.HeadLbl.TabIndex = 43;
            this.HeadLbl.Click += new System.EventHandler(this.HeadLbl_Click);
            // 
            // BodyLbl
            // 
            this.BodyLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BodyLbl.Location = new System.Drawing.Point(225, 125);
            this.BodyLbl.Name = "BodyLbl";
            this.BodyLbl.Size = new System.Drawing.Size(40, 40);
            this.BodyLbl.TabIndex = 44;
            this.BodyLbl.Click += new System.EventHandler(this.BodyLbl_Click);
            // 
            // OK
            // 
            this.OK.Enabled = false;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OK.Location = new System.Drawing.Point(292, 125);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(40, 40);
            this.OK.TabIndex = 45;
            this.OK.TabStop = false;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // SnakeColour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 181);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.BodyLbl);
            this.Controls.Add(this.HeadLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnakeColour";
            this.Text = "SnakeColour";
            this.Load += new System.EventHandler(this.SnakeColour_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeColour_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OK;
        public System.Windows.Forms.Label HeadLbl;
        public System.Windows.Forms.Label BodyLbl;
    }
}