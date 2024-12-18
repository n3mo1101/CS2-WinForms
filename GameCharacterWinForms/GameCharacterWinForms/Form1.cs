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
using System.IO;

namespace GameCharacterWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startgame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.pictureTitle.Parent = pictureBackground;
            this.startgame.Parent = pictureBackground;
            this.exit.Parent = pictureBackground;

            string audioFilePath = Path.Combine(Application.StartupPath, "Assets", "Audio", "BGMusic_Form2.wav");
            SoundPlayer player = new SoundPlayer(audioFilePath);
            player.PlayLooping();
        }

        private void lblClickStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
