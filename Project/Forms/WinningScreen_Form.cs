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
    public partial class WinningScreen_Form : Form
    {
        public static SoundPlayer soundPlayer;


        public WinningScreen_Form()
        {
            InitializeComponent();
        }

        private void WinningScreen_Form_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(@"C:\Users\u\source\repos\CopsNRobbers\Project\Sounds\Winning.wav");
            soundPlayer.Play();
        }

        private void PlayAgain_Button_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            MenuScreen_Form menuScreen = new MenuScreen_Form();
            this.Hide();
            menuScreen.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
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
