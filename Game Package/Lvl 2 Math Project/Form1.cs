using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lvl_2_Math_Project
{
    public partial class Form1 : Form
    {
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            if (!panel4.Controls.Contains(ShootingGallery.Instance))
            {
                panel4.Controls.Add(ShootingGallery.Instance);
                ShootingGallery.Instance.BringToFront();
                ShootingGallery.Instance.Focus();
            }
            else
            {
                ShootingGallery.Instance.BringToFront();
            }
            
            ShootingGallery.Instance.LoadShotGalStat();
            Snake.Instance.LoadSnakeStat();
            PicturePuzzle.Instance.LoadPicPuzStat();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            if (!panel4.Controls.Contains(ShootingGallery.Instance))
            {
                panel4.Controls.Add(ShootingGallery.Instance);
                ShootingGallery.Instance.BringToFront();
                ShootingGallery.Instance.Focus();
            }
            else
            {
                ShootingGallery.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

            if (!panel4.Controls.Contains(Snake.Instance))
            {
                panel4.Controls.Add(Snake.Instance);
                Snake.Instance.BringToFront();
                Snake.Instance.Focus();
            }
            else
            {
                Snake.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            if (!panel4.Controls.Contains(PicturePuzzle.Instance))
            {
                panel4.Controls.Add(PicturePuzzle.Instance);
                PicturePuzzle.Instance.BringToFront();
                PicturePuzzle.Instance.Focus();
            }
            else
            {
                PicturePuzzle.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            if (!panel4.Controls.Contains(HallofGlory.Instance))
            {
                panel4.Controls.Add(HallofGlory.Instance);
                HallofGlory.Instance.BringToFront();
            }
            else
            {
                HallofGlory.Instance.BringToFront();
            }
        }
    }
}
