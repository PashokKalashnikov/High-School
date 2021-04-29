using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lvl_2_Math_Project
{
    public partial class SnakeColour : Form
    {
        public SnakeColour()
        {
            InitializeComponent();
        }

        Color clrCustomHead = Color.Green,
              clrCustomBody = Color.GreenYellow;

        private void SnakeColour_Load(object sender, EventArgs e)
        {
            HeadLbl.BackColor = clrCustomHead;
            BodyLbl.BackColor = clrCustomBody;
        }

        private void HeadLbl_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            DialogResult drResult = dlg.ShowDialog();

            if(drResult == DialogResult.OK)
            {
                clrCustomHead = HeadLbl.BackColor = dlg.Color;

                panel1.Refresh();

                OK.Enabled = true;
            }
            

        }

        private void BodyLbl_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            DialogResult drResult = dlg.ShowDialog();

            if (drResult == DialogResult.OK)
            {
                BodyLbl.BackColor = clrCustomBody = dlg.Color;

                panel1.Refresh();
                
                OK.Enabled = true;
            }

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            int iX = 0,
                iY = 0;

            for (int i = 0; i < 12; i++)
            {
                SolidBrush snakeColour;

                if (i == 0)
                    snakeColour = new SolidBrush(clrCustomHead); // Head
                else
                    snakeColour = new SolidBrush(clrCustomBody); // Body

                canvas.FillEllipse(snakeColour,
                    new Rectangle(iX, iY, // Coordinates
                                  32, 32)); // Width & Height

                iX += 32;
            }
        }

        private void SnakeColour_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (OK.Enabled))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
