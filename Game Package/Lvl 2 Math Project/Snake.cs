using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lvl_2_Math_Project
{
    public partial class Snake : UserControl
    {
        private static Snake _instance;
        public static Snake Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Snake();
                return _instance;
            }
        }

        [Serializable]
        public struct SnakeStat // Add rainbow circles
        {
            public string m_sName;
            public int m_iSpeed;
            public int m_iBonusFoodEatean;
            public int m_iLength;
            public int m_iScore;

            public SnakeStat(string sName, int iSpeed, int iBonusFoodEatean, int iLength, int iScore)
            {
                m_sName = sName;
                m_iSpeed = iSpeed;
                m_iBonusFoodEatean = iBonusFoodEatean;
                m_iLength = iLength;
                m_iScore = iScore;
            }
        }

        public List<SnakeStat> SnakeList = new List<SnakeStat>();
        private List<Circle> snake = new List<Circle>();
        private Circle food = new Circle();
        Random rnd = new Random();

        int iScore = 0,
            iLength = 1,
            iSpeed = 1,
            iBonusFood = 8,
            iBonusEaten = 0;

        bool bBonusFood = false;
        
        public Snake()
        {
            InitializeComponent();
        }
        
        private void Snake_Load(object sender, EventArgs e)
        {
            new Settings();

            //Set game speed and start timer
            gameTimer.Interval = 1000 / 8;
            Settings.Speed = 8;
            gameTimer.Tick += UpdateScreen;

            Settings.GameOver = true;
        }

        private void StartGame()
        {
            new Settings();
            gameTimer.Enabled = true;

            //Create new player object
            snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            snake.Add(head);


            SpeedDown.Enabled = SpeedUp.Enabled = false;

            iBonusEaten = iScore = 0;
            iLength = 1;
            iBonusFood = 8;
            GenerateFood();
        }

        private void GenerateFood() // Fixed
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            int iX = rnd.Next(0, maxXPos),
                iY = rnd.Next(0, maxYPos);

            for (int i = snake.Count - 1; i >= 0; i--)
            {
                for (int j = 1; j < snake.Count; j++)
                {
                    if (snake[i].X == iX && snake[i].Y == iY)
                    {
                        iX = rnd.Next(0, maxXPos);
                        iY = rnd.Next(0, maxYPos);

                        Debug.WriteLine("Random was spawned inside the snake");
                    }
                    else
                    {
                        if (iBonusFood == iLength)
                        {
                            iBonusFood += 6;
                            Debug.WriteLine("iBonusFood: {0}", iBonusFood);
                            double dChance = GetRandomNumber(0, 1);
                            double dProbability = 0.0;

                            if (iSpeed == 1)
                                dProbability = 0.1; // 10% 

                            else if (iSpeed == 2)
                                dProbability = 0.2; // 20%

                            else if (iSpeed == 3)
                                dProbability = 0.3; // 30%

                            else if (iSpeed == 4)
                                dProbability = 0.4; // 40%

                            else if (iSpeed == 5)
                                dProbability = 0.5; // 50%

                            if (dChance < dProbability)
                            {
                                bBonusFood = true;
                                RGBFood.Enabled = true;
                            }
                        }
                        food = new Circle { X = iX, Y = iY };
                        break;
                    }
                }
            }

            if (bBonusFood)
            {
                System.IO.Stream str = Properties.Resources.BonusFoodSpawn;
                System.Media.SoundPlayer BonusFoodSpawn = new System.Media.SoundPlayer(str);
                BonusFoodSpawn.Play();
            }
            else
            {
                System.IO.Stream str = Properties.Resources.FoodSpawn;
                System.Media.SoundPlayer FoodSpawn = new System.Media.SoundPlayer(str);
                FoodSpawn.Play();
            }
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            MovePlayer();

            pbCanvas.Invalidate();
        }

        Color clrCustomHead = Color.Green,
              clrCustomBody = Color.GreenYellow;

        SolidBrush snakeColour;
        SolidBrush foodColour;

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                for (int i = 0; i < snake.Count; i++)
                {
                    if (RGB.Enabled)
                    {
                        RGBMix(clrRainbow);
                        //Draw snake
                        canvas.FillEllipse(snakeColour = new SolidBrush(clrRainbow[0]),
                            new Rectangle(snake[i].X * Settings.Width,
                                          snake[i].Y * Settings.Height,
                                          Settings.Width, Settings.Height));

                        //Draw Food
                        canvas.FillEllipse(Brushes.Red,
                            new Rectangle(food.X * Settings.Width,
                                 food.Y * Settings.Height, Settings.Width, Settings.Height));
                    }
                    else
                    {
                        if (i == 0)
                            snakeColour = new SolidBrush(clrCustomHead); // Head
                        else
                            snakeColour = new SolidBrush(clrCustomBody); // Body

                        //Draw snake
                        canvas.FillEllipse(snakeColour,
                            new Rectangle(snake[i].X * Settings.Width,
                                          snake[i].Y * Settings.Height,
                                          Settings.Width, Settings.Height));

                        //Draw Food
                        RGBMix(clrRainbow);
                        if (bBonusFood)
                        {
                            canvas.FillEllipse(foodColour = new SolidBrush(clrRainbow[0]),
                                new Rectangle(food.X * Settings.Width,
                                     food.Y * Settings.Height, Settings.Width, Settings.Height));
                        }
                        else
                        {
                            canvas.FillEllipse(Brushes.Red,
                                new Rectangle(food.X * Settings.Width,
                                     food.Y * Settings.Height, Settings.Width, Settings.Height));
                        }
                    }


                }
            }
        }

        private void MovePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            snake[i].X++;
                            break;
                        case Direction.Left:
                            snake[i].X--;
                            break;
                        case Direction.Up:
                            snake[i].Y--;
                            break;
                        case Direction.Down:
                            snake[i].Y++;
                            break;
                    }


                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (snake[i].X < 0 || snake[i].Y < 0
                        || snake[i].X >= maxXPos || snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    //Detect collission with body
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X &&
                           snake[i].Y == snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (snake[0].X == food.X && snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    //Move body
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }



        private void Eat()
        {
            if (bBonusFood)
            {
                RGB.Enabled = true;
                RGBFood.Enabled = bBonusFood = false;
                iBonusEaten++;
                Debug.WriteLine(string.Format("Rainbow Circles eaten: {0}", iBonusEaten));

                if (iSpeed == 1)
                    iScore += 500;

                else if (iSpeed == 2)
                    iScore += 1000;

                else if (iSpeed == 3)
                    iScore += 1500;

                else if (iSpeed == 4)
                    iScore += 2000;

                else if (iSpeed == 5)
                    iScore += 2500;
            }
            else
            {
                RGB.Enabled = false;
            }
            //Add circle to body
            Circle circle = new Circle
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            };
            snake.Add(circle);

            GenerateFood();

            lblLength.Text = string.Format("Length: {0}", iLength++);

            CountScore();

        }

        private void Die()
        {
            Settings.GameOver = true;

            RGB.Enabled = RGBFood.Enabled = bBonusFood = false;

            SpeedDown.Enabled = SpeedUp.Enabled = true;

            lblGameOver.BringToFront();

            saveTheScoreToolStripMenuItem.Enabled = changeColorOfTheSnakeToolStripMenuItem.Enabled = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Settings.GameOver)
            {
                StartGame();
                iLength = 1;

                lblGameOver.SendToBack();
            }

            saveTheScoreToolStripMenuItem.Enabled = changeColorOfTheSnakeToolStripMenuItem.Enabled = false;

            lblLength.Text = "Length:";
            lblScore.Text = "Score:";
            food = new Circle {X = 5, Y = 5 };
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == (Keys.Up)) && (Settings.direction != Direction.Down))
            {
                Settings.direction = Direction.Up;
                return true;
            }
            if ((keyData == (Keys.Down)) && (Settings.direction != Direction.Up))
            {
                Settings.direction = Direction.Down;
                return true;
            }
            if ((keyData == (Keys.Right)) && (Settings.direction != Direction.Left))
            {
                Settings.direction = Direction.Right;
                return true;
            }
            if ((keyData == (Keys.Left)) && (Settings.direction != Direction.Right))
            {
                Settings.direction = Direction.Left;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SpeedDown_Click(object sender, EventArgs e) // -Speed
        {
           DecreaseSpeed();
        }

        private void SpeedUp_Click(object sender, EventArgs e) // +Speed
        {
           IncreaseSpeed();
        }

        public void IncreaseSpeed()
        {
            if (Settings.Speed < 40)
            {
                Settings.Speed += 8;
                iSpeed++;
                gameTimer.Interval = 1000 / Settings.Speed;

                Debug.WriteLine("Speed Mode: {0} /// Speed Settings: {1}", iSpeed, Settings.Speed);
            }

            label3.Focus();
            lblSpeed.Text = string.Format("Speed: {0}", iSpeed);
        }

        public void DecreaseSpeed()
        {
            if (Settings.Speed > 8)
            {
                Settings.Speed -= 8;
                iSpeed--;
                gameTimer.Interval = 1000 / Settings.Speed;

                Debug.WriteLine("Speed Mode: {0} /// Speed Settings: {1}", iSpeed, Settings.Speed);
            }

            label3.Focus();
            lblSpeed.Text = string.Format("Speed: {0}", iSpeed);
        }

        Savethescore ScoreDialog = new Savethescore(); // Name dialog

        private void saveTheScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreDialog.ShowDialog();

            if (ScoreDialog.DialogResult == DialogResult.OK)
            {
                SnakeStat Player = new SnakeStat(ScoreDialog.textBox1.Text, iSpeed, iBonusEaten, iLength, iScore);

                int iReplace = CheckPlayer(ScoreDialog.textBox1.Text, SnakeList);

                if (iReplace != -1)
                {
                    DialogResult drResult = MessageBox.Show("Hall of Glory has this name already. Do you want to overwrite the statistics for this name?", "Snake", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (drResult == DialogResult.Yes)
                    {
                        SnakeList.RemoveAt(iReplace);
                        SnakeList.Add(Player);
                    }
                }
                else
                {
                    SnakeList.Add(Player);
                }
            }

            ScoreDialog.textBox1.Text = null;

            RefreshListView();

            try
            {

                FileStream fs = new FileStream("Snake.bin", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, SnakeList);

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Game Package");
            }

            saveTheScoreToolStripMenuItem.Enabled = changeColorOfTheSnakeToolStripMenuItem.Enabled = false;
        }

        public void CountScore()
        {
            if (iSpeed == 1)
            {
                iScore += 100;
                lblScore.Text = string.Format("Score: {0}", iScore);
            }

            else if (iSpeed == 2)
            {
                iScore += 200;
                lblScore.Text = string.Format("Score: {0}", iScore);
            }

            else if (iSpeed == 3)
            {
                iScore += 300;
                lblScore.Text = string.Format("Score: {0}", iScore);
            }

            else if (iSpeed == 4)
            {
                iScore += 400;
                lblScore.Text = string.Format("Score: {0}", iScore);
            }

            else if (iSpeed == 5)
            {
                iScore += 500;
                lblScore.Text = string.Format("Score: {0}", iScore);
            }
        }

        private int CheckPlayer(string sFind, List<SnakeStat> lNames)
        {
            int iFoundAt = -1;

            for (int i = 0; i < lNames.Count; i++)
            {
                if (lNames[i].m_sName == sFind)
                {
                    iFoundAt = i;
                }
            }
            return iFoundAt;
        }


        public void LoadSnakeStat()
        {
            try
            {
                FileStream fs = new FileStream("Snake.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                SnakeList = (List<SnakeStat>)bf.Deserialize(fs);

                fs.Close();

                RefreshListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Game Package");
            }
        }

        public void InsertionSort(List<SnakeStat> lList)
        {
            int iTemp = 0;
            int iPass = 0;
            int iScan = 0;
            SnakeStat sTemp = new SnakeStat(); // Temporary stuct for transition

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

        public void SelectionSortAlphabet(List<SnakeStat> lNms)
        {
            int iMinIndex = 0;  //index where min value found
            SnakeStat sTemp = new SnakeStat();  //temporary storage for swapping
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

        SnakeColour snk = new SnakeColour();
        
        private void changeColorOfTheSnakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drResult = snk.ShowDialog();
            
            if (drResult == DialogResult.OK)
            {
                clrCustomHead = snk.HeadLbl.BackColor;
                clrCustomBody = snk.BodyLbl.BackColor;
            }
        }

        public void FindPlayer(List<SnakeStat> lList)
        {
            ScoreDialog.ShowDialog();
            if (ScoreDialog.DialogResult == DialogResult.OK)
            {
                foreach (ListViewItem i in HallofGlory.Instance.SnakeStat.SelectedItems)
                {
                    i.Selected = false;
                }

                int iFoundAt = -1;
                for (int iIndex = 0; iIndex < lList.Count; iIndex++)
                {
                    if (ScoreDialog.textBox1.Text == lList[iIndex].m_sName)
                    {
                        iFoundAt = iIndex;
                        HallofGlory.Instance.SnakeStat.Focus();
                        HallofGlory.Instance.SnakeStat.Items[iIndex].Selected = true;
                        HallofGlory.Instance.SnakeStat.Items[iIndex].EnsureVisible();
                    }
                }
                if (iFoundAt == -1)
                {
                    MessageBox.Show("Sorry, this name was not found", "Snake");
                }

            }

            ScoreDialog.textBox1.Text = null;
        }

        public void RefreshListView()
        {
            HallofGlory.Instance.SnakeStat.Items.Clear();

            ListViewItem lvPlayers = new ListViewItem();

            foreach (SnakeStat Record in SnakeList)
            {
                lvPlayers = new ListViewItem(Record.m_sName);
                lvPlayers.SubItems.Add(Record.m_iSpeed.ToString());
                lvPlayers.SubItems.Add(Record.m_iBonusFoodEatean.ToString());
                lvPlayers.SubItems.Add(Record.m_iLength.ToString());
                lvPlayers.SubItems.Add(Record.m_iScore.ToString());

                HallofGlory.Instance.SnakeStat.Items.Add(lvPlayers);
            }
        }

        Color[] clrRainbow = new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple };

        public void RGBMix(Color[] clrRGB)
        {
            Color clrTemp = clrRGB[5];

            for(int i = 5; i > 0; i--)
            {
                clrRGB[i] = clrRGB[i - 1];
            }

            clrRGB[0] = clrTemp;
        }
        
        private void RGB_Tick(object sender, EventArgs e)
        {
            pbCanvas.Refresh();
        }

        private void RGBFood_Tick(object sender, EventArgs e)
        {
            pbCanvas.Refresh();
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
