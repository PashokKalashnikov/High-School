namespace Lvl_2_Math_Project
{
    partial class Images
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
            this.Previewpx = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPicName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Previewpx)).BeginInit();
            this.SuspendLayout();
            // 
            // Previewpx
            // 
            this.Previewpx.Location = new System.Drawing.Point(253, 49);
            this.Previewpx.Name = "Previewpx";
            this.Previewpx.Size = new System.Drawing.Size(256, 256);
            this.Previewpx.TabIndex = 0;
            this.Previewpx.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(25, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 44);
            this.label7.TabIndex = 39;
            this.label7.Text = "Picture name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Enabled = false;
            this.ChooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChooseButton.Location = new System.Drawing.Point(23, 272);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(214, 33);
            this.ChooseButton.TabIndex = 41;
            this.ChooseButton.TabStop = false;
            this.ChooseButton.Text = "Choose";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(253, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 44);
            this.label1.TabIndex = 43;
            this.label1.Text = "Picture preview:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 212);
            this.listBox1.TabIndex = 44;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblPicName
            // 
            this.lblPicName.AutoSize = true;
            this.lblPicName.Location = new System.Drawing.Point(228, 17);
            this.lblPicName.Name = "lblPicName";
            this.lblPicName.Size = new System.Drawing.Size(35, 13);
            this.lblPicName.TabIndex = 45;
            this.lblPicName.Text = "label2";
            this.lblPicName.Visible = false;
            // 
            // Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 323);
            this.Controls.Add(this.lblPicName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Previewpx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Images";
            this.Text = "Images";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Images_FormClosed);
            this.Load += new System.EventHandler(this.Images_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Previewpx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Previewpx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label lblPicName;
    }
}