using GameCharacterWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GameCharacterWinForms
{

    public partial class Form3 : Form
    {
        GameCharacter selectedCharacter = Form2.Instance.currentCharacter;
        public Form3()
        {
            InitializeComponent();
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
                EnemyIdle.Image = Properties.Resources.Orc_Death;
            }
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

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCharacterDetails.Text = selectedCharacter.ToString();

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
                CharacterIdle.Size = new Size(140, 157);
                CharacterIdle.SizeMode =  PictureBoxSizeMode.Zoom;
                CharacterIdle.Location = new Point(217, 178);

                CharacterAction.Image = Properties.Resources.witch_attack;
                CharacterAction.Size = new Size(303, 166);
                CharacterAction.SizeMode = PictureBoxSizeMode.Zoom;
                CharacterAction.Location = new Point(305, 169);

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
                CharacterIdle.Size = new Size(209, 212);
                CharacterIdle.SizeMode = PictureBoxSizeMode.StretchImage;
                CharacterIdle.Location = new Point(179, 157);

                CharacterAction.Image = Properties.Resources.Warrior_Attack;
                CharacterAction.Size = new Size(217, 212);
                CharacterAction.SizeMode = PictureBoxSizeMode.StretchImage;
                CharacterAction.Location = new Point(373, 156);

            }

            CharacterIdle.Visible = true;
            CharacterAction.Visible = false;
            EnemyIdle.Visible = true;
            EnemyAction.Visible = false;
            animationTimer.Tick += animationTimer_Tick;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationTimer.Stop();
            CharacterIdle.Visible = true;
            CharacterAction.Visible = false;
            EnemyIdle.Visible = true;
            EnemyAction.Visible = false;
        }
    }
}
