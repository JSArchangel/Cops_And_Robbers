using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Resources;

namespace CopsNRobbers.Project.Forms
{
    public partial class Game2Screen_Form : Form
    {
        public static SoundPlayer soundPlayer;

        int seconds = 60;
        int treasure = 0;
        int speed = 6;
        bool goDown = false;
        bool goTop = false;
        bool goRight = false;
        bool goLeft = false;

        Random randomEnumerator = new Random();

        int copLeft;
        int copTop;

        int treasureLeft;
        int treasureTop;

        public Game2Screen_Form()
        {
            InitializeComponent();
        }

        private void Game2Screen_Form_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(@"C:\Users\u\source\repos\CopsNRobbers\Project\Sounds\RunRobberRun.wav");
            soundPlayer.Play();
            KeyPreview = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MidPanel.Visible = false;
            timer1minute.Start();
            timerMove.Start();
            timerRandomCop.Start();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            MenuScreen_Form menuScreen = new MenuScreen_Form();
            this.Hide();
            menuScreen.Show();
        }

        private void timerRandomCop_Tick(object sender, EventArgs e)
        {
            copLeft = randomEnumerator.Next(0, 440);
            copTop = randomEnumerator.Next(250, 350);
            CopPictureBox.Left = copLeft;
            CopPictureBox.Top = copTop;
        }

        private void timer1minute_Tick(object sender, EventArgs e)
        {
            seconds--;
            SecondsLabel.Text = seconds.ToString();

            if (seconds == 0)
            {
                timer1minute.Stop();
                timerRandomCop.Stop();

                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("Time up! Do you want to try again?", "Time up", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    int seconds = 60;
                    int treasure = 0;
                    TreasureLabel.Text = treasure.ToString();
                    SecondsLabel.Text = seconds.ToString();

                    timer1minute.Start();
                    timerRandomCop.Start();
                }
                else if (dialog == DialogResult.No)
                {
                    soundPlayer.Stop();
                    GameOverScreen_Form gameOverScreen = new GameOverScreen_Form();
                    this.Hide();
                    gameOverScreen.Show();
                }
            }
        }

        private void Game2Screen_Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                RobberPictureBox.Image = Image.FromFile(@"C:\Users\u\source\repos\CopsNRobbers\Resources\robberLeft.png");
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                RobberPictureBox.Image = Image.FromFile(@"C:\Users\u\source\repos\CopsNRobbers\Resources\robberRight.png");
            }
            if (e.KeyCode == Keys.Up)
            {
                goTop = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void Game2Screen_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                RobberPictureBox.Image = Image.FromFile(@"C:\Users\u\source\repos\CopsNRobbers\Resources\robberLeft.png");
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                RobberPictureBox.Image = Image.FromFile(@"C:\Users\u\source\repos\CopsNRobbers\Resources\robberRight.png");
            }
            if (e.KeyCode == Keys.Up)
            {
                goTop = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (goLeft == true)
            {
                RobberPictureBox.Left -= speed;
            }
            if (goRight == true)
            {
                RobberPictureBox.Left += speed;
            }
            if (goTop == true)
            {
                RobberPictureBox.Top -= speed;
            }
            if (goDown == true)
            {
                RobberPictureBox.Top += speed;
            }
            if (CopPictureBox.Bounds.IntersectsWith(RobberPictureBox.Bounds))
            {
                timerMove.Stop();
                timerRandomCop.Stop();
                timer1minute.Stop();
                MessageBox.Show("Caught you! Go to Jail!", "Caught!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                soundPlayer.Stop();
                GameOverScreen_Form gameOverScreen = new GameOverScreen_Form();
                this.Hide();
                gameOverScreen.Show();
            }
            if (RobberPictureBox.Bounds.IntersectsWith(TreasurePictureBox.Bounds))
            {
                treasure++;
                treasureLeft = randomEnumerator.Next(0, 540);
                treasureTop = randomEnumerator.Next(250, 350);
                TreasurePictureBox.Left = treasureLeft;
                TreasurePictureBox.Top = treasureTop;
                TreasureLabel.Text = treasure.ToString();

                if (treasure == 3)
                {
                    timerMove.Stop();
                    timerRandomCop.Stop();
                    timer1minute.Stop();
                    MessageBox.Show("You won! You are now rich!", "You are rich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    soundPlayer.Stop();
                    WinningScreen_Form winningScreen = new WinningScreen_Form();
                    this.Hide();
                    winningScreen.Show();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                soundPlayer.Stop();
                MenuScreen_Form menuScreen = new MenuScreen_Form();
                this.Hide();
                menuScreen.Show();
            }
        }
    }
}
