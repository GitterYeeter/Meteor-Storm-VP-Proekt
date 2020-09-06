using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Meteor_Blaster
{
    public partial class Game : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] stars;
        int backgroundSpeed; 
        int playerSpeed;
        Random rnd;


        PictureBox[] munitions;
        int munitionSpeed;

        PictureBox[] enemyes;
        int enemySpeed;

        Menu menu;

        public Game(Menu menu)
        {

            this.menu = menu;
            InitializeComponent();
        }

        int score;
        int level;
        bool pause;
        bool gameIsOver;

        //bool playTheGame = false;



        private void Form1_Load(object sender, EventArgs e)
        {
            /*if (!playTheGame)
            {
                StopTimers();
            }
            else
            {
                StartTimers();
            }*/
                pause = false;
                gameIsOver = false;
                score = 0;
                level = 1;

                //Create WMP
                gameMedia = new WindowsMediaPlayer();
                shootMedia = new WindowsMediaPlayer();
                explosion = new WindowsMediaPlayer();

                //Load Songs
                gameMedia.URL = "songs\\GameSong.mp3";
                shootMedia.URL = "songs\\shoot.mp3";
                explosion.URL = "songs\\boom.mp3";

                //Setup Songs
                gameMedia.settings.setMode("loop", true);
                gameMedia.settings.volume = 5;
                shootMedia.settings.volume = 1;
                explosion.settings.volume = 6;
                gameMedia.controls.play();

                backgroundSpeed = 4;
                playerSpeed = 4;
                enemySpeed = 8;


                stars = new PictureBox[10];
                rnd = new Random();

                munitionSpeed = 20;
                munitions = new PictureBox[3];

                Image munition = Image.FromFile("Pictures\\munition.png");

                Image m1 = Image.FromFile("pictures\\meteor1.jpg");
                Image m2 = Image.FromFile("pictures\\meteor2.png");
                Image m3 = Image.FromFile("pictures\\meteor3.png");
                Image m4 = Image.FromFile("pictures\\meteor4.png");
                Image m5 = Image.FromFile("pictures\\meteor5.png");

                enemyes = new PictureBox[10];

                for (int i = 0; i < enemyes.Length; i++)
                {
                    enemyes[i] = new PictureBox();
                    enemyes[i].Size = new Size(40, 40);
                    enemyes[i].SizeMode = PictureBoxSizeMode.Zoom;
                    enemyes[i].BorderStyle = BorderStyle.None;
                    enemyes[i].Visible = false;
                    enemyes[i].BackColor = Color.Transparent;
                    this.Controls.Add(enemyes[i]);
                    enemyes[i].Location = new Point((i + 1) * 50, -50);
                }
                enemyes[0].Image = m1;
                enemyes[1].Image = m2;
                enemyes[2].Image = m3;
                enemyes[3].Image = m4;
                enemyes[4].Image = m2;
                enemyes[5].Image = m3;
                enemyes[6].Image = m5;
                enemyes[7].Image = m1;
                enemyes[8].Image = m3;
                enemyes[9].Image = m4;

                for (int i = 0; i < stars.Length; i++)
                {
                    stars[i] = new PictureBox();
                    stars[i].BorderStyle = BorderStyle.None;
                    stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
                    if (i % 2 == 1)
                    {
                        stars[i].Size = new Size(2, 2);
                        stars[i].BackColor = Color.Wheat;
                    }
                    else
                    {
                        stars[i].Size = new Size(3, 3);
                        stars[i].BackColor = Color.DarkGray;
                    }
                    this.Controls.Add(stars[i]);
                }
                for (int i = 0; i < munitions.Length; i++)
                {
                    munitions[i] = new PictureBox();
                    munitions[i].Size = new Size(20, 20);
                    munitions[i].Image = munition;
                    munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                    munitions[i].BorderStyle = BorderStyle.None;
                    this.Controls.Add(munitions[i]);
                }
            
        }

        private void MoveBgTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundSpeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundSpeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void leftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void rightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += playerSpeed;
            }
        }

        private void downMoveTimer_Tick(object sender, EventArgs e)
        {

            if (Player.Top < 400)
            {
                Player.Top += playerSpeed;
            }
        }

        private void upMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    rightMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    leftMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    downMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    upMoveTimer.Start();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            leftMoveTimer.Stop();
            rightMoveTimer.Stop();
            downMoveTimer.Stop();
            upMoveTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        textlabel1.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        textlabel1.Location = new Point(this.Width / 2 - 90, 150);
                        textlabel1.Text = "PAUSED";
                        textlabel1.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        private void moveMunitionTimer_Tick(object sender, EventArgs e)
        {
            shootMedia.controls.play();
        
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionSpeed;
                    hit();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void moveEnemyTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemyes, enemySpeed);
        }
        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;
                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        public void hit()
        {
            for (int i = 0; i < enemyes.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemyes[i].Bounds) || munitions[1].Bounds.IntersectsWith(enemyes[i].Bounds) || munitions[2].Bounds.IntersectsWith(enemyes[i].Bounds))
                {
                    explosion.controls.play();
                    score += 1;
                    scorelbl.Text = (score < 10) ? "0" + score.ToString() : score.ToString();
                    if (score % 30 == 0)
                    {
                        level += 1;
                        levellbl.Text = (level < 10) ? "0" + level.ToString() : level.ToString();
                        if (enemySpeed <= 10)
                        {
                            enemySpeed++;
                        }
                        if (level == 10)
                        {
                            GameOver("YOU ARE DONE!");
                        }
                    }
                    enemyes[i].Location = new Point((i + 1) * 50, -100);
                }


                if (Player.Bounds.IntersectsWith(enemyes[i].Bounds))
                {
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("");
                }
            }
        }

        private void StopTimers()
        {
            MoveBgTimer.Stop();
            moveEnemyTimer.Stop();
            moveMunitionTimer.Stop();
        }
        private void StartTimers()
        {
            MoveBgTimer.Start();
            moveEnemyTimer.Start();
            moveMunitionTimer.Start();
        }
        private void GameOver(String str)
        {
            label4.Visible = true;
            textlabel1.Text = score.ToString();
            textlabel1.Location = new Point(280, 120);
            textlabel1.Visible = true;
            replayBtn.Visible = true;
            exitBtn.Visible = true;
            gameMedia.controls.stop();
            StopTimers();

            
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.menu.Show();
            this.Close();
            
        }
        

        private void replayBtn_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.menu.Show();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            playTheGame = true;

            Form1_Load(e, e);
        }*/

    }
}
