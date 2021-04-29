using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace Lvl_2_Math_Project
{
    public partial class PicturePuzzle : UserControl
    {
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        private static PicturePuzzle _instance;
        public static PicturePuzzle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PicturePuzzle();
                return _instance;
            }
        }

        [Serializable]
        public struct PicturePuzzleStat
        {
            public string m_sName;
            public string m_sPictureName;
            public int m_iMoves;
            public string m_sTime;
            public int m_iScore;

            public PicturePuzzleStat(string sName, string sPictureName, int iMoves, string sTime, int iScore)
            {
                m_sName = sName;
                m_sPictureName = sPictureName;
                m_iMoves = iMoves;
                m_sTime = sTime;
                m_iScore = iScore;
            }
        }
        
        public List<PicturePuzzleStat> PicPuzList = new List<PicturePuzzleStat>();
        int iMoves = 0,
            iScore;
        bool bGameStarted = false;
        Random rnd = new Random();
        Image[] imgarray = new Image[16];
        Images ImageCollection = new Images();
        public Original_px OrPix = null;
        Savethescore ScoreDialog = new Savethescore(); // Name dialog



        public PicturePuzzle()
        {
            InitializeComponent();
        }

        private void PicturePuzzle_Load(object sender, EventArgs e)
        {
            RefreshPuzzlePicture();

            ShowFull();

            ImageCollection.lblPicName.Text = "Witcher.png"; // Standard picture
        }


        private void RefreshPuzzlePicture()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int iIndex = i * 4 + j;
                    imgarray[iIndex] = new Bitmap(128, 128);
                    var graphics = Graphics.FromImage(imgarray[iIndex]);
                    
                    graphics.DrawImage(Original_px.Instance.pictureBox1.Image, new Rectangle(0, 0, 128, 128), new Rectangle(j * 128, i * 128, 128, 128), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            if (bGameStarted == false)
            {
                ShowFull();
                gameToolStripMenuItem.Enabled = true;
            }
            else
            {
                ShowFull();
                StartGame();
                gameToolStripMenuItem.Enabled = false;
            }
        }

        private bool ValidPicture(string filename, int limitWidth, int limitHeight)
        {
            using (var img = new Bitmap(filename))
            {
                if (img.Width != limitWidth || img.Height != limitHeight)
                    return false;
            }
            return true;
        }

        private void chooseAPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OrPix == null)
            {
                OrPix = new Original_px();
                OrPix.FormClosed += PixClosed;
            }

            ImageCollection.ShowDialog();

            if (ImageCollection.DialogResult == DialogResult.OK)
                RefreshPuzzlePicture();
        }

        private void uploadOwnPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Choose a picture which is 512x512 pixels";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (ValidPicture(dlg.FileName, 512, 512))
                    {
                        if (OrPix == null)
                        {
                            OrPix = new Original_px();
                            OrPix.FormClosed += PixClosed;
                        }

                        Original_px.Instance.pictureBox1.Image = new Bitmap(dlg.FileName);

                        DialogResult drResult = MessageBox.Show("Do you desire to save your image in the list of pictures?", "Picture Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (drResult == DialogResult.Yes)
                        {
                            try
                            {
                                File.Copy(dlg.FileName, Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) + "/PicPuzImages", Path.GetFileName(dlg.FileName)), true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Picture Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }

                        RefreshPuzzlePicture();
                    }
                    else
                    {
                        MessageBox.Show("The size of your picture is not 512x512 pixels. Please choose another one.", "Picture Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void showFullPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OrPix == null)
            {
                OrPix = new Original_px();
                OrPix.FormClosed += PixClosed;
            }

            OrPix.pictureBox1.Image = Original_px.Instance.pictureBox1.Image; 
            OrPix.Show();
        }

        private void PixClosed(object sender, FormClosedEventArgs e)
        {
            OrPix = null;
        }
        
        private void PicturePuzzle_Click(object sender, EventArgs e)
        {
            if (bGameStarted)
                MoveButton((PictureBox)sender);
        }

        private void MoveButton (PictureBox px)
        {
            lblMoves.Text = "Moves: " + iMoves.ToString();
            if (((px.Location.X == px16.Location.X - 128 || px.Location.X == px16.Location.X + 128)
                && px.Location.Y == px16.Location.Y) 
                || (px.Location.Y == px16.Location.Y - 128 || px.Location.Y == px16.Location.Y + 128)
                && px.Location.X == px16.Location.X)
            {
                Point Swap = px.Location;
                px.Location = px16.Location;
                px16.Location = Swap;
                iMoves++;
            }

            if (px16.Location.X == 384 && px16.Location.Y == 384)
                CheckValid();
        }

        private void CheckValid()
        {
            int iCount = 0, iIndex;
            foreach (PictureBox px in Puzzlepanel.Controls)
            {
                iIndex = (px.Location.Y / 128) * 4 + px.Location.X / 128;
                if (imgarray[iIndex] == px.Image)
                    iCount++;
            }

            Debug.WriteLine(iCount);

            if (iCount == 15)
            {
                bGameStarted = false;
                gameToolStripMenuItem.Enabled = true;
                playToolStripMenuItem.Text = "Play";

                timer1.Enabled = false;
                timer.Stop();

                System.IO.Stream str = Properties.Resources.Win;
                System.Media.SoundPlayer Win = new System.Media.SoundPlayer(str);
                Win.Play();

                DialogResult drResult = MessageBox.Show("Nice job! Do you want to save your score?", "Picture Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (drResult == DialogResult.Yes)
                {
                    ScoreDialog.ShowDialog();

                    if (ScoreDialog.DialogResult == DialogResult.OK)
                    {
                        TimeSpan ts = timer.Elapsed;

                        PicturePuzzleStat Player = new PicturePuzzleStat(ScoreDialog.textBox1.Text, ImageCollection.lblPicName.Text, iMoves, string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds), iScore);

                        Debug.WriteLine("Name: {0}\n" +
                            "Picture Name: {1}\n" +
                            "Moves: {2}\n" +
                            "Time: {3}\n" +
                            "Score: {4}", Player.m_sName, Player.m_sPictureName, Player.m_iMoves, Player.m_sTime, Player.m_iScore);

                        int iReplace = CheckPlayer(ScoreDialog.textBox1.Text, Player.m_sPictureName, PicPuzList);

                        if (iReplace != -1)
                        {
                            drResult = MessageBox.Show("Hall of Glory has this name with this picture already. Do you want to overwrite the statistics for this name?", "Picture Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (drResult == DialogResult.Yes)
                            {
                                PicPuzList.RemoveAt(iReplace);
                                PicPuzList.Add(Player);
                            }
                        }
                        else
                        {
                            PicPuzList.Add(Player);
                        }

                        ScoreDialog.textBox1.Text = null;

                        RefreshListView();

                        try
                        {

                            FileStream fs = new FileStream("PicturePuzzle.bin", FileMode.Create, FileAccess.Write);
                            BinaryFormatter bf = new BinaryFormatter();

                            bf.Serialize(fs, PicPuzList);

                            fs.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Game Package");
                        }

                        timer.Restart();
                    }
                }
            }

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(playToolStripMenuItem.Text == "Play")
            {
                iMoves = 0;
                bGameStarted = true;
                RefreshPuzzlePicture();

                timer.Start();
                timer1.Enabled = true;

                playToolStripMenuItem.Text = "Stop";
            }
            else
            {
                iMoves = 0; lblMoves.Text = "Moves:"; lblTime.Text = "Time:";
                bGameStarted = false;
                gameToolStripMenuItem.Enabled = true;

                timer.Stop();
                timer.Restart();
                timer1.Enabled = false;

                playToolStripMenuItem.Text = "Play";
            }
        }

        private void changeColourOfTheEmptyBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();

            DialogResult drResult = cdlg.ShowDialog();

            if (drResult == DialogResult.OK)
            {
                px16.BackColor = cdlg.Color;
            }
        }
        
        private void ShowFull()
        {
            px1.Image = imgarray[0];    px1.Location = new Point(0, 0);
            px2.Image = imgarray[1];    px2.Location = new Point(128, 0);
            px3.Image = imgarray[2];    px3.Location = new Point(256, 0);
            px4.Image = imgarray[3];    px4.Location = new Point(384, 0);

            px5.Image = imgarray[4];    px5.Location = new Point(0, 128);
            px6.Image = imgarray[5];    px6.Location = new Point(128, 128);    
            px7.Image = imgarray[6];    px7.Location = new Point(256, 128);
            px8.Image = imgarray[7];    px8.Location = new Point(384, 128);

            px9.Image = imgarray[8];    px9.Location = new Point(0, 256);
            px10.Image = imgarray[9];   px10.Location = new Point(128, 256);
            px11.Image = imgarray[10];  px11.Location = new Point(256, 256);
            px12.Image = imgarray[11];  px12.Location = new Point(384, 256);

            px13.Image = imgarray[12];  px13.Location = new Point(0, 384);
            px14.Image = imgarray[13];  px14.Location = new Point(128, 384);
            px15.Image = imgarray[14];  px15.Location = new Point(256, 384);
                                        px16.Location = new Point(384, 384);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = timer.Elapsed;
            lblTime.Text = string.Format("Time: {0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            lblScore.Text = string.Format("Score: {0}", iScore = CountScore(iMoves, Convert.ToInt32(ts.TotalSeconds)));

        }

        public int CountScore(int iMoves, int iTime)
        {
            int iScore = 1000;
            while (iMoves > 0)
            {
                iMoves--;
                iScore--;
            }
            while (iTime > 0)
            {
                iScore--;
                iTime--;
            }

            return iScore;
        }

        private void StartGame()
        {
            List<PictureBox> Swap = new List<PictureBox>();

            for(int i = 0; i < 300; i++)
            {
                foreach (PictureBox px in Puzzlepanel.Controls)
                {
                    if (((px.Location.X == px16.Location.X - 128 || px.Location.X == px16.Location.X + 128)
                        && px.Location.Y == px16.Location.Y)
                        || (px.Location.Y == px16.Location.Y - 128 || px.Location.Y == px16.Location.Y + 128)
                        && px.Location.X == px16.Location.X)
                    {
                        Swap.Add(px);
                    }
                }

                SwapImages(Swap[rnd.Next(0, Swap.Count)]);
                Swap.Clear();
            }
        }

        private void SwapImages( PictureBox px)
        {
            Point Swap = px.Location;
            px.Location = px16.Location;
            px16.Location = Swap;
        }


        private int CheckPlayer(string sFind, string sPictureName,List<PicturePuzzleStat> lNames)
        {
            int iFoundAt = -1;

            for (int i = 0; i < lNames.Count; i++)
            {
                if ((lNames[i].m_sName == sFind) && (lNames[i].m_sPictureName == sPictureName))
                {
                    iFoundAt = i;
                }
            }
            return iFoundAt;
        }

        public void LoadPicPuzStat()
        {
            try
            {
                FileStream fs = new FileStream("PicturePuzzle.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                PicPuzList = (List<PicturePuzzleStat>)bf.Deserialize(fs);

                fs.Close();

                RefreshListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Game Package");
            }
        }

        public void InsertionSort(List<PicturePuzzleStat> lList)
        {
            int iTemp = 0;
            int iPass = 0;
            int iScan = 0;
            PicturePuzzleStat sTemp = new PicturePuzzleStat(); // Temporary stuct for transition

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

        public void SelectionSortAlphabet(List<PicturePuzzleStat> lNms)
        {

            int iMinIndex = 0;  //index where min value found
            PicturePuzzleStat sTemp = new PicturePuzzleStat();  //temporary storage for swapping
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

        public void FindPlayer(List<PicturePuzzleStat> lList)
        {
            ScoreDialog.ShowDialog();
            if (ScoreDialog.DialogResult == DialogResult.OK)
            {
                foreach (ListViewItem i in HallofGlory.Instance.PicPuzStat.SelectedItems)
                {
                    i.Selected = false;
                }

                int iFoundAt = -1;
                for (int iIndex = 0; iIndex < lList.Count; iIndex++)
                {
                    if (ScoreDialog.textBox1.Text == lList[iIndex].m_sName)
                    {
                        iFoundAt = iIndex;
                        HallofGlory.Instance.PicPuzStat.Focus();
                        HallofGlory.Instance.PicPuzStat.Items[iIndex].Selected = true;
                        HallofGlory.Instance.PicPuzStat.Items[iIndex].EnsureVisible();
                    }
                }
                if (iFoundAt == -1)
                {
                    MessageBox.Show("Sorry, this name was not found", "Picture Puzzle");
                }

            }

            ScoreDialog.textBox1.Text = null;
        }

        public void RefreshListView()
        {
            HallofGlory.Instance.PicPuzStat.Items.Clear();

            ListViewItem lvPlayers = new ListViewItem();

            foreach (PicturePuzzleStat Record in PicPuzList)
            {
                lvPlayers = new ListViewItem(Record.m_sName);
                lvPlayers.SubItems.Add(Record.m_sPictureName);
                lvPlayers.SubItems.Add(Record.m_iMoves.ToString());
                lvPlayers.SubItems.Add(Record.m_sTime);
                lvPlayers.SubItems.Add(Record.m_iScore.ToString());

                HallofGlory.Instance.PicPuzStat.Items.Add(lvPlayers);
            }
        }
    }
}
