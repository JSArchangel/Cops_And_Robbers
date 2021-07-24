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

namespace CopsNRobbers.Project.Forms
{
    public partial class Game1Screen_Form : Form
    {
        public static SoundPlayer soundPlayer;

        int level = 1;
        int count = 0;
        int seconds = 60;

        public static bool isGoBack;

        Random randomNumerator = new Random();

        int robberLeft;
        int robberTop;

        int citizenLeft;
        int citizenTop;

        public Game1Screen_Form()
        {
            InitializeComponent();
        }

        private void Game1Screen_Form_Load(object sender, EventArgs e)
        {
            robberLeft = randomNumerator.Next(0, 440);
            robberTop = randomNumerator.Next(150, 350);
            soundPlayer = new SoundPlayer(@"C:\Users\u\source\repos\CopsNRobbers\Project\Sounds\CatchTheRobber.wav");
            soundPlayer.Play();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MidPanel.Hide();
            timer1minute.Start();
            timerRandomRobber.Start();
            CitizenPictureBox.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            isGoBack = true;
            soundPlayer.Stop();
            MenuScreen_Form menuScreen = new MenuScreen_Form();
            this.Hide();
            menuScreen.Show();
        }

        private void timerRandomRobber_Tick(object sender, EventArgs e)
        {
            robberLeft = randomNumerator.Next(0, 440);
            robberTop = randomNumerator.Next(150, 350);
            citizenLeft = randomNumerator.Next(0, 440);
            citizenTop = randomNumerator.Next(150, 350);
            RobberPictureBox.Left = robberLeft;
            RobberPictureBox.Top = robberTop;
        }

        private void timer1minute_Tick(object sender, EventArgs e)
        {
            seconds--;
            SecondsLabel.Text = seconds.ToString();


            if (seconds == 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Time up! Do you want to try again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    timerRandomRobber.Interval = 1000;
                    level = 1;
                    count = 0;
                    seconds = 60;
                    CitizenPictureBox.Visible = false;
                    timer1minute.Start();
                    timerRandomRobber.Start();
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

        private void timerCitizens_Tick(object sender, EventArgs e)
        {
            CitizenPictureBox.Visible = true;
            citizenLeft = randomNumerator.Next(0, 440);
            citizenTop = randomNumerator.Next(150, 350);
            CitizenPictureBox.Left = citizenLeft;
            CitizenPictureBox.Top = citizenTop;
        }

        private void RobberPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            count++;
            CountLabel.Text = count.ToString();
            PoliceTalk.Text = "Robber\nCaught;";

            if (count == 5)
            {
                MessageBox.Show("Level 1 Completed!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                level++;
                LevelLabel.Text = level.ToString();
                timerRandomRobber.Interval = 100;
                CitizenPictureBox.Visible = true;
                timerCitizens.Start();
            }
            else if (count == 10)
            {
                MessageBox.Show("Game completed! Well done!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinningScreen_Form winningScreen = new WinningScreen_Form();
                this.Hide();
                winningScreen.Show();
                soundPlayer.Stop(); 
            }
        }

        private void Game1Screen_Form_MouseClick(object sender, MouseEventArgs e)
        {
            PoliceTalk.Text = "Miss!;";
        }

        private void CitizenPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PoliceTalk.Text = "Oops!;";
            timer1minute.Stop();
            timerRandomRobber.Stop();
            timerCitizens.Stop();
            MessageBox.Show("You caught citizens by mistake! Game Over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            soundPlayer.Stop();
            GameOverScreen_Form gameoverScreen = new GameOverScreen_Form();
            this.Hide();
            gameoverScreen.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
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
