using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lvl_2_Math_Project
{
    public partial class ShootingGallery : UserControl
    {
        private static ShootingGallery _instance;
        public static ShootingGallery Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShootingGallery();
                return _instance;
            }
        }

        int m_iSpeed = 1,
            m_iHits,
            m_iNumofTargets = 5,
            m_iTry = 0,
            m_iShots;

        bool bLevel1 = false,
             bLevel2 = false;

        Random rnd = new Random();

        public ShootingGallery()
        {
            InitializeComponent();
        }

        [Serializable]
        public struct ShotGalStat
        {
            public string m_sName;
            public string m_sLevel;
            public int m_iHits;
            public int m_iShots;
            public int m_iSpeed;
            public double m_dPercentage;
            public int m_iScore;

            public ShotGalStat(string sName, string sLevel, int iHits, int iShots, int iSpeed, double dPercentage, int iScore)
            {
                m_sName = sName;
                m_sLevel = sLevel;
                m_iHits = iHits;
                m_iShots = iShots;
                m_iSpeed = iSpeed;
                m_dPercentage = dPercentage;
                m_iScore = iScore;
            }
        }

        public List<ShotGalStat> ShotGalList = new List<ShotGalStat>();
        
        private void timer1_Tick(object sender, EventArgs e) // Level 1
        {
            pictureBox1.Visible = true;

            if (m_iTry < m_iNumofTargets)
            {
                int iX = rnd.Next(110, 750);
                int iY = rnd.Next(120, 420);

                pictureBox1.Location = new Point(iX, iY);
                m_iTry++;
            }
            else
            {
                Random.Enabled = false;
                pictureBox1.Visible = false;
                Start.Enabled = Levels.Enabled = saveTheScoreToolStripMenuItem.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) // Start button
        {
            if (bLevel1)
            {
                Random.Enabled = true;
                Start.Enabled = Levels.Enabled = false;

                m_iTry = m_iHits = m_iShots = 0;

                label2.Text = string.Format("Hits: {0}/{1}", m_iHits, m_iNumofTargets);

                ChangeSpeed();
                SpeedDown.Enabled = SpeedUp.Enabled = TargetDown.Enabled = TargetUp.Enabled = false;

            }
            if (bLevel2)
            {
                RightTimer.Enabled = true;
                Start.Enabled = Levels.Enabled = false;

                m_iShots = m_iHits = 0;

                label2.Text = string.Format("Hits: {0}/{1}", m_iHits, m_iNumofTargets);

                pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = pictureBox5.Visible = pictureBox6.Visible = true;

                SpeedDown.Enabled = SpeedUp.Enabled = TargetDown.Enabled = TargetUp.Enabled = false;
            }
        }
        
        int[] iX = new int[5] { 113, 752, 113, 752, 113 };
        int[] iY = new int[5] { 128, 198, 268, 338, 408 };

        private void RightTimer_Tick(object sender, EventArgs e)
        {
            if ((iX[0] != 752) && (iX[0] < 752))
            {
                if ((m_iHits < m_iNumofTargets) && ((iX[0] < 752) && (iX[0] > 742)))
                {
                    pictureBox2.Visible = true;
                }
                if ((m_iHits < m_iNumofTargets) && ((iX[0] < 752) && (iX[0] > 742)))
                {
                    pictureBox3.Visible = true;
                }
                if ((m_iHits < m_iNumofTargets) && ((iX[0] < 752) && (iX[0] > 742)))
                {
                    pictureBox4.Visible = true;
                }
                if ((m_iHits < m_iNumofTargets) && ((iX[0] < 752) && (iX[0] > 742)))
                {
                    pictureBox5.Visible = true;
                }
                if ((m_iHits < m_iNumofTargets) && ((iX[0] < 752) && (iX[0] > 742)))
                {
                    pictureBox6.Visible = true;
                }
                if (m_iHits == m_iNumofTargets)
                {
                    RightTimer.Enabled = false;
                    Levels.Enabled = saveTheScoreToolStripMenuItem.Enabled = true;
                    pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = pictureBox5.Visible = pictureBox6.Visible = false;
                }

                pictureBox2.Location = new Point(iX[0] += m_iSpeed, iY[0]);
                pictureBox3.Location = new Point(iX[1] -= m_iSpeed, iY[1]);
                pictureBox4.Location = new Point(iX[2] += m_iSpeed, iY[2]);
                pictureBox5.Location = new Point(iX[3] -= m_iSpeed, iY[3]);
                pictureBox6.Location = new Point(iX[4] += m_iSpeed, iY[4]);
            }
            else
            {
                RightTimer.Enabled = false;
                LeftTimer.Enabled = true;
            }
        }

        private void LeftTimer_Tick(object sender, EventArgs e)
        {
            if ((iX[0] != 113) && (iX[0] > 113))
            {
                if ((m_iHits < m_iNumofTargets) && ((iX[0] > 113) && (iX[0] < 133)))
                {
                    pictureBox2.Visible = true;
                }
                if ((m_iHits < m_iNumofTargets) && ((iX[0] > 113) && (iX[0] < 133)))
                {
                    pictureBox3.Visible = true;
                }
                if ((m_iHits < m_iNumofTargets) && ((iX[0] > 113) && (iX[0] < 133)))
                {
                    pictureBox4.Visible = true;
                }
                if ((m_iHits < m_iNumofTargets) && ((iX[0] > 113) && (iX[0] < 133)))
                {
                    pictureBox5.Visible = true;
                }
                if ((m_iHits < m_iNumofTargets) && ((iX[0] > 113) && (iX[0] < 133)))
                {
                    pictureBox6.Visible = true;
                }
                if (m_iHits == m_iNumofTargets)
                {
                    LeftTimer.Enabled = false;
                    Levels.Enabled = saveTheScoreToolStripMenuItem.Enabled = true;
                    pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = pictureBox5.Visible = pictureBox6.Visible = false;
                }

                pictureBox2.Location = new Point(iX[0] -= m_iSpeed, iY[0]);
                pictureBox3.Location = new Point(iX[1] += m_iSpeed, iY[1]);
                pictureBox4.Location = new Point(iX[2] -= m_iSpeed, iY[2]);
                pictureBox5.Location = new Point(iX[3] += m_iSpeed, iY[3]);
                pictureBox6.Location = new Point(iX[4] -= m_iSpeed, iY[4]);
            }
            else
            {
                RightTimer.Enabled = true;
                LeftTimer.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Level 1
        {
            if (Random.Enabled)
            {
                m_iHits++;
                label2.Text = string.Format("Hits: {0}/{1}", m_iHits, m_iNumofTargets);

                Shot();
            }
        }
        
        private void PictureBox_Click(object sender, EventArgs e) // Level 2
        {
            if ((RightTimer.Enabled) || (LeftTimer.Enabled))
            {
                PictureBox pctClick = null;

                if (sender is PictureBox)
                {
                    pctClick = (PictureBox)sender;

                    if (pctClick != pictureBox1)
                    {
                        m_iHits++;
                        pctClick.Visible = false;

                        label2.Text = string.Format("Hits: {0}/{1}", m_iHits, m_iNumofTargets);

                        Shot();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) // White label behind the picture boxes
        {
            if (Random.Enabled || LeftTimer.Enabled || RightTimer.Enabled)
                Shot();
        }
        
        private void level1ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
        }

        private void level1ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
        }

        private void level2ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
        }

        private void level2ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
        }

        private void level1ToolStripMenuItem_Click(object sender, EventArgs e) // Choose Level 1
        {
            Start.Enabled = true;
            Start.Text = "Play";
            label2.Text = "Hits:";
            bLevel1 = true;
            bLevel2 = false;

            m_iSpeed = 1;
            m_iNumofTargets = 5;

            ShowSpeed();
            ShowTargets();

            SpeedDown.Enabled = SpeedUp.Enabled = TargetDown.Enabled = TargetUp.Enabled = true;
        }

        private void level2ToolStripMenuItem_Click(object sender, EventArgs e) // Choose Level 2
        {
            Start.Enabled = true;
            Start.Text = "Play";
            label2.Text = "Hits:";
            bLevel2 = true;
            bLevel1 = false;

            m_iSpeed = 1;
            m_iNumofTargets = 5;


            ShowSpeed();
            ShowTargets();

            SpeedDown.Enabled = SpeedUp.Enabled = TargetDown.Enabled = TargetUp.Enabled = true;
        }

        private void SpeedDown_Click(object sender, EventArgs e)
        {
            DecreaseSpeed();
        }

        private void SpeedUp_Click(object sender, EventArgs e)
        {
            IncreaseSpeed();
        }

        private void TargetDown_Click(object sender, EventArgs e)
        {
            DecreaseTarget();
        }

        private void TargetUp_Click(object sender, EventArgs e)
        {
            IncreaseTarget();
        }



        private void ChangeSpeed()
        {
            if (m_iSpeed == 1)
            {
                Random.Interval = 1000;
            }

            if (m_iSpeed == 2)
            {
                Random.Interval = 800;
            }

            if (m_iSpeed == 3)
            {
                Random.Interval = 600;
            }

            if (m_iSpeed == 4)
            {
                Random.Interval = 400;
            }

            if (m_iSpeed == 5)
            {
                Random.Interval = 200;
            }
        }

        private void Shot()
        {
            System.IO.Stream str = Properties.Resources.Rifle;
            System.Media.SoundPlayer Rifle = new System.Media.SoundPlayer(str);
            Rifle.Play();

            m_iShots++;
        }

        private void IncreaseSpeed()
        {
            if ((bLevel1) || (bLevel2))
            {
                m_iSpeed++;

                if (m_iSpeed > 5)
                {
                    m_iSpeed = 5;
                }

                ShowSpeed();

                label9.Focus();
            }

        }

        private void DecreaseSpeed()
        {
            if ((bLevel1) || (bLevel2))
            {
                m_iSpeed--;

                if (m_iSpeed < 1)
                {
                    m_iSpeed = 1;
                }

                ShowSpeed();

                label9.Focus();
            }
        }

        private void IncreaseTarget()
        {
            if (bLevel1)
            {
                m_iNumofTargets++;
            }

            else if (bLevel2)
            {
                m_iNumofTargets += 5;
            }

            if (m_iNumofTargets > 30)
            {
                m_iNumofTargets = 30;
            }

            ShowTargets();

            label9.Focus();
        }

        private void DecreaseTarget()
        {
            if (bLevel1)
            {
                m_iNumofTargets--;
            }

            else if (bLevel2)
            {
                m_iNumofTargets -= 5;
            }

            if (m_iNumofTargets < 5)
            {
                m_iNumofTargets = 5;
            }

            ShowTargets();

            label9.Focus();
        }
        
        private void ShowSpeed()
        {
            label5.Text = string.Format("Speed: {0}", m_iSpeed);
        }

        private void ShowTargets()
        {
            label6.Text = string.Format("Targets: {0}", m_iNumofTargets);
        }

        private int CountScore(int iHits, int iShots, int iSpeed)
        {
            int iScore = 0;

            for (int i = 0; i < iHits; i++)
            {
                if (m_iSpeed == 1)
                    iScore = (bLevel1) ? iScore += 200 : iScore += 100;
                else if (m_iSpeed == 2)
                    iScore = (bLevel1) ? iScore += 400 : iScore += 200;
                else if (m_iSpeed == 3)
                    iScore = (bLevel1) ? iScore += 600 : iScore += 300;
                else if (m_iSpeed == 4)
                    iScore = (bLevel1) ? iScore += 800 : iScore += 400;
                else if (m_iSpeed == 5)
                    iScore = (bLevel1) ? iScore += 1000 : iScore += 500;
            }

            for (int i = 0; i < iShots - iHits; i++)
                iScore = (bLevel1) ? iScore -= 50 : iScore -= 100;

            return iScore;
        }

        private double CountPercent(int iHits, int iShots)
        {
            double dPercent = iHits / Convert.ToDouble(iShots);

            return dPercent;
        }
        


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Up))
            {
                IncreaseTarget();
                return true;
            }
            if (keyData == (Keys.Down))
            {
                DecreaseTarget();
                return true;
            }
            if (keyData == (Keys.Right))
            {
                IncreaseSpeed();
                return true;
            }
            if (keyData == (Keys.Left))
            {
                DecreaseSpeed();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        } // Works only after the user clicks Shooting Gallery

        Savethescore ScoreDialog = new Savethescore(); // Name dialog

        private void saveTheScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreDialog.ShowDialog();

            if (ScoreDialog.DialogResult == DialogResult.OK)
            {
                string sLevel = "Level 1";

                if (bLevel1)
                    sLevel = "Level 1";
                if (bLevel2)
                    sLevel = "Level 2";

                ShotGalStat Player = new ShotGalStat(ScoreDialog.textBox1.Text, sLevel, m_iHits, m_iShots, m_iSpeed, CountPercent(m_iHits, m_iShots), CountScore(m_iHits, m_iShots, m_iSpeed));

                int iReplace = CheckPlayer(ScoreDialog.textBox1.Text, sLevel, ShotGalList);

                if (iReplace != -1)
                {
                    DialogResult drResult = MessageBox.Show("Hall of Glory has this name already at this level. Do you want to overwrite the statistics for this name?", "Shotting Gallery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (drResult == DialogResult.Yes)
                    {
                        ShotGalList.RemoveAt(iReplace);
                        ShotGalList.Add(Player);
                    }

                }
                else
                {
                    ShotGalList.Add(Player);
                }

                ScoreDialog.textBox1.Text = null;

                RefreshListView();
                

                try
                {

                    FileStream fs = new FileStream("ShotGal.bin", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();

                    bf.Serialize(fs, ShotGalList);

                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Game Package");
                }

                saveTheScoreToolStripMenuItem.Enabled = false;
            }
        }



        private int CheckPlayer(string sFind, string sLvl, List<ShotGalStat> lNames)
        {
            int iFoundAt = -1;

            for (int i = 0; i < lNames.Count; i++)
            {
                if ((lNames[i].m_sName == sFind) && (lNames[i].m_sLevel == sLvl))
                {
                    iFoundAt = i;
                }
            }

            return iFoundAt;

        }

        public void InsertionSort(List<ShotGalStat> lList)
        {
            int iTemp = 0;
            int iPass = 0;
            int iScan = 0;
            ShotGalStat sTemp = new ShotGalStat(); // Temporary stuct for transition

            for (iPass = 1; iPass < lList.Count; iPass++)
            {
                iScan = iPass - 1;
                iTemp = lList[iPass].m_iScore;
                sTemp = lList[iPass];

                while ((iScan >= 0) && (iTemp > lList[iScan].m_iScore))
                {
                    lList[iScan + 1] = lList[iScan];
                    iScan--;
                }
                lList[iScan + 1] = sTemp;
            }

            RefreshListView();
        }

        public void SelectionSortAlphabet(List<ShotGalStat> lNms)
        {

            int iMinIndex = 0;  //index where min value found
            ShotGalStat sTemp = new ShotGalStat();  //temporary storage for swapping
            int iCurrent = 0;   //current location for selected value
            int iScan = 0;  //index to scan the unsorted array

            for (iCurrent = 0; iCurrent < lNms.Count - 1; iCurrent++)
            {
                iMinIndex = iCurrent;

                for (iScan = iCurrent + 1; iScan < lNms.Count; iScan++)
                {
                    if (string.Compare(lNms[iScan].m_sName, lNms[iMinIndex].m_sName, true) < 0) // Compairing 2 strings
                    {
                        iMinIndex = iScan;
                    }
                }
                
                sTemp = lNms[iMinIndex];
                lNms[iMinIndex] = lNms[iCurrent];
                lNms[iCurrent] = sTemp;
            }

            RefreshListView();
        }
        
        public void FindPlayer(List<ShotGalStat> lList)
        {
            ScoreDialog.ShowDialog();
            if (ScoreDialog.DialogResult == DialogResult.OK)
            {
                foreach (ListViewItem i in HallofGlory.Instance.ShotGalStat.SelectedItems)
                {
                    i.Selected = false;
                }

                int iFoundAt = -1;
                for (int iIndex = 0; iIndex < lList.Count; iIndex++)
                {
                    if (ScoreDialog.textBox1.Text == lList[iIndex].m_sName)
                    {
                        iFoundAt = iIndex;
                        HallofGlory.Instance.ShotGalStat.Focus();
                        HallofGlory.Instance.ShotGalStat.Items[iIndex].Selected = true;
                        HallofGlory.Instance.ShotGalStat.Items[iIndex].EnsureVisible();
                    }
                }
                if (iFoundAt == -1)
                {
                    MessageBox.Show("Sorry, this name was not found", "Shooting Gallery");
                }

            }

            ScoreDialog.textBox1.Text = null;
        }
        
        public void RefreshListView()
        {
            HallofGlory.Instance.ShotGalStat.Items.Clear();

            ListViewItem lvPlayers = new ListViewItem();

            foreach (ShotGalStat Record in ShotGalList)
            {
                lvPlayers = new ListViewItem(Record.m_sName);
                lvPlayers.SubItems.Add(Record.m_sLevel);
                lvPlayers.SubItems.Add(Record.m_iHits.ToString());
                lvPlayers.SubItems.Add(Record.m_iShots.ToString());
                lvPlayers.SubItems.Add(Record.m_iSpeed.ToString());
                lvPlayers.SubItems.Add(string.Format("{0:P1}", Record.m_dPercentage));
                lvPlayers.SubItems.Add(Record.m_iScore.ToString());

                HallofGlory.Instance.ShotGalStat.Items.Add(lvPlayers);
            }
        }

        public void LoadShotGalStat()
        {
            try
            {
                FileStream fs = new FileStream("ShotGal.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                ShotGalList = (List<ShotGalStat>)bf.Deserialize(fs);

                fs.Close();

                RefreshListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Game Package");
            }
        }



    }
}
