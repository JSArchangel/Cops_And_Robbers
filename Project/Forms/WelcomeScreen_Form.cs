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
    public partial class WelcomeScreen_Form : Form
    {

        public static SoundPlayer soundPlayer;

        public WelcomeScreen_Form()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Form_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(@"C:\Users\u\source\repos\CopsNRobbers\Project\Sounds\WelcomeScreen.wav");
            soundPlayer.Play();
        }

        private void WelcomeScreen_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            MenuScreen_Form menuScreen = new MenuScreen_Form();
            this.Hide();
            menuScreen.Show();
        }
    }
}
