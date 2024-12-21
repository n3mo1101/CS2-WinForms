using GameCharacterWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
//using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace GameCharacterWinForms
{

    public partial class Form3 : Form
    {
        SoundPlayer soundPlayer;
        GameCharacter selectedCharacter = Form2.Instance.currentCharacter;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1.Instance.soundPlayer.Stop();

            string bgMusic = Path.Combine(Application.StartupPath, "Assets", "Audio", "retrograme-bgmusic.wav");
            soundPlayer = new SoundPlayer(bgMusic);
            soundPlayer.PlayLooping();

            txtCharacterDetails.Text = selectedCharacter.ToString();

            CharacterIdle.Visible = true;
            CharacterAction.Visible = false;
            CharacterAction.Parent = EnemyIdle;

            EnemyIdle.Visible = true;
            EnemyAction.Visible = false;
            EnemyAction.Parent = CharacterIdle;

            if (Form2.Instance.selectedClassType == "Mage")
            {
                portraitPlayer.Image = Properties.Resources.Mage_Portrait;
                lblEnergy.Text = "MP";
                barEnergy.ProgressBarColor = Color.DeepSkyBlue;
                iconEnergy.Image = Properties.Resources.magic;

                iconStatus1.Image = Properties.Resources.wizard;
                iconStatus5.Image = Properties.Resources.magic;
                iconStatus6.Image = Properties.Resources.wizard_hat;
                iconStatus7.Image = Properties.Resources.magic_wand;

                CharacterIdle.Image = Properties.Resources.witch_idle;
                CharacterIdle.Size = new Size(308, 157);
                CharacterIdle.SizeMode = PictureBoxSizeMode.Zoom;
                CharacterIdle.Location = new Point(132, 172);

                CharacterAction.Image = Properties.Resources.witch_attack;
                CharacterAction.Size = new Size(303, 166);
                CharacterAction.SizeMode = PictureBoxSizeMode.Zoom;

                CharacterAction.Location = new Point(0, -10);
                EnemyAction.Location = new Point(150, 0);

            }
            else if (Form2.Instance.selectedClassType == "Warrior")
            {
                portraitPlayer.Image = Properties.Resources.Male_Portrait;
                lblEnergy.Text = "SP";
                barEnergy.ProgressBarColor = Color.LimeGreen;
                iconEnergy.Image = Properties.Resources.health_care__1_;

                iconStatus1.Image = Properties.Resources.viking;
                iconStatus5.Image = Properties.Resources.health_care__1_;
                iconStatus6.Image = Properties.Resources.sword__3_;
                iconStatus7.Image = Properties.Resources.shield__2_;

                CharacterIdle.Image = Properties.Resources.Warrior_Idle;
                CharacterIdle.Size = new Size(503, 212);
                CharacterIdle.SizeMode = PictureBoxSizeMode.Zoom;
                CharacterIdle.Location = new Point(29, 146);

                CharacterAction.Image = Properties.Resources.Warrior_Attack;
                CharacterAction.Size = new Size(217, 212);
                CharacterAction.SizeMode = PictureBoxSizeMode.StretchImage;

                CharacterAction.Location = new Point(70, -30);
                EnemyAction.Location = new Point(240, 20);
            }
            
            animationTimer.Tick += animationTimer_Tick;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            selectedCharacter.Attack(out var message, out var damageDealt);
            AddToBattleLog(message);
            txtCharacterDetails.Text = selectedCharacter.ToString();

            CharacterIdle.Visible = false;
            CharacterAction.Visible = true;
            animationTimer.Start();

            damageDealt = Convert.ToInt32(damageDealt * 0.1);
            if (barEnemyHealth.Value > damageDealt)
            {
                barEnemyHealth.Value -= damageDealt;
            }
            else
            {
                barEnemyHealth.Value = 0;
                PlayEnemyDeathAnimation();

                btnAttack.Enabled = false;
                btnDefend.Enabled = false;
                btnLevelUp.Enabled = false;

                pictureBoxWin.Visible = true;
                string winSfx = Path.Combine(Application.StartupPath, "Assets", "Audio", "win-sfx.wav");
                soundPlayer.SoundLocation = winSfx;
                soundPlayer.Load();
                soundPlayer.Play();
            }
        }

        private void PlayEnemyDeathAnimation()
        {
            EnemyIdle.Image = Properties.Resources.Orc_Death_Fix;
            EnemyIdle.Visible = true;

            ImageAnimator.StopAnimate(EnemyIdle.Image, null);

            int currentFrame = 0;
            int totalFrames = EnemyIdle.Image.GetFrameCount(FrameDimension.Time);

            deathAnimationTimer.Tick += (s, e) =>
            {
                if (currentFrame >= totalFrames - 1)
                {
                    deathAnimationTimer.Stop();
                    deathAnimationTimer.Dispose();

                    EnemyIdle.Enabled = false;
                }
                else
                {
                    EnemyIdle.Image.SelectActiveFrame(FrameDimension.Time, currentFrame++);
                    EnemyIdle.Invalidate();
                }
            };

            deathAnimationTimer.Start();
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            CharacterIdle.SendToBack();

            EnemyIdle.Visible = false;
            EnemyAction.Visible = true;
            animationTimer.Start();
            barHealth.Value -= 10;

            AddToBattleLog(selectedCharacter.Defend());
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            selectedCharacter.LevelUp();
            battleLog.Items.Add($"{selectedCharacter.Name} leveled up.");
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void AddToBattleLog(string message)
        {
            int maxLineLength = 100;
            List<string> lines = new List<string>();

            while (message.Length > maxLineLength)
            {
                int splitIndex = message.LastIndexOf(' ', maxLineLength);
                if (splitIndex == -1) splitIndex = maxLineLength;

                lines.Add(message.Substring(0, splitIndex));
                message = message.Substring(splitIndex).TrimStart();
            }

            if (message.Length > 0)
            {
                lines.Add(message);
            }

            foreach (var line in lines)
            {
                battleLog.Items.Add(line);
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationTimer.Stop();
            CharacterIdle.Visible = true;
            CharacterAction.Visible = false;
            EnemyIdle.Visible = true;
            EnemyAction.Visible = false;
        }

        private void pictureBoxWin_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();

            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
