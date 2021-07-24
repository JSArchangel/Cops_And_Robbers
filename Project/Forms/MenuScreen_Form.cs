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
using System.Threading;

namespace CopsNRobbers.Project.Forms
{
    public partial class MenuScreen_Form : Form
    {

        public MenuScreen_Form()
        {
            InitializeComponent();
        }
        private void MenuScreen_Form_Load(object sender, EventArgs e)
        {
            if (Game1Screen_Form.isGoBack == true)
            {
                WelcomeScreen_Form.soundPlayer.Play();
            }
        }

        private void Instructions_Button_Click(object sender, EventArgs e)
        {
            Instructions_GroupBox.Visible = true;
        }

        private void CatchTheRobber_Button_Click(object sender, EventArgs e)
        {
            Game1Screen_Form game1Screen = new Game1Screen_Form();
            WelcomeScreen_Form.soundPlayer.Stop();
            this.Hide();
            game1Screen.Show();
        }

        private void RunRobberRun_Button_Click(object sender, EventArgs e)
        {
            Game2Screen_Form game2Screen = new Game2Screen_Form();
            WelcomeScreen_Form.soundPlayer.Stop();
            this.Hide();
            game2Screen.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye, have a nice day!", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Instructions_GroupBox.Visible = false;

        }

        private void GroupBox_Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Goodbye, have a nice day!", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
