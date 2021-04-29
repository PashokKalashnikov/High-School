using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lvl_2_Math_Project
{
    public partial class HallofGlory : UserControl
    {
        public HallofGlory()
        {
            InitializeComponent();
        }

        private static HallofGlory _instance;
        public static HallofGlory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HallofGlory();
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            if (ShotGalStat.Visible)
                ShootingGallery.Instance.InsertionSort(ShootingGallery.Instance.ShotGalList);
            else if (SnakeStat.Visible)
                Snake.Instance.InsertionSort(Snake.Instance.SnakeList);
            else if (PicPuzStat.Visible)
                PicturePuzzle.Instance.InsertionSort(PicturePuzzle.Instance.PicPuzList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

            if (ShotGalStat.Visible)
                ShootingGallery.Instance.SelectionSortAlphabet(ShootingGallery.Instance.ShotGalList);
            else if (SnakeStat.Visible)
                Snake.Instance.SelectionSortAlphabet(Snake.Instance.SnakeList);
            else if (PicPuzStat.Visible)
                PicturePuzzle.Instance.SelectionSortAlphabet(PicturePuzzle.Instance.PicPuzList);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            if (ShotGalStat.Visible)
                ShootingGallery.Instance.FindPlayer(ShootingGallery.Instance.ShotGalList);
            else if (SnakeStat.Visible)
                Snake.Instance.FindPlayer(Snake.Instance.SnakeList);
            else if (PicPuzStat.Visible)
                PicturePuzzle.Instance.FindPlayer(PicturePuzzle.Instance.PicPuzList);
        }

        private void shootingGalleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShotGalStat.Visible = true;
            SnakeStat.Visible = PicPuzStat.Visible = false;
        }

        private void secondGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicPuzStat.Visible = ShotGalStat.Visible = false;
            SnakeStat.Visible = true;
        }

        private void thirdGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicPuzStat.Visible = true;
            SnakeStat.Visible = ShotGalStat.Visible = false;
        }

        private void HallofGlory_Load(object sender, EventArgs e)
        {
            ShotGalStat.Visible = true;
        }
    }
}
