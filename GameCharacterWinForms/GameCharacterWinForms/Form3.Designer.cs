using System.Drawing;
using System.Windows.Forms;

namespace GameCharacterWinForms
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.ListBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxStatus = new System.Windows.Forms.GroupBox();
            this.iconStatus3 = new System.Windows.Forms.PictureBox();
            this.iconStatus2 = new System.Windows.Forms.PictureBox();
            this.iconStatus1 = new System.Windows.Forms.PictureBox();
            this.iconStatus7 = new System.Windows.Forms.PictureBox();
            this.iconStatus6 = new System.Windows.Forms.PictureBox();
            this.iconStatus5 = new System.Windows.Forms.PictureBox();
            this.iconStatus4 = new System.Windows.Forms.PictureBox();
            this.iconEnergy = new System.Windows.Forms.PictureBox();
            this.iconHealth = new System.Windows.Forms.PictureBox();
            this.portraitPlayer = new System.Windows.Forms.PictureBox();
            this.CharacterIdle = new System.Windows.Forms.PictureBox();
            this.CharacterAction = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnemyIdle = new System.Windows.Forms.PictureBox();
            this.EnemyAction = new System.Windows.Forms.PictureBox();
            this.deathAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxWin = new System.Windows.Forms.PictureBox();
            this.customProgressBar1 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.barEnemyHealth = new GameCharacterWinForms.Models.CustomProgressBar();
            this.barEnergy = new GameCharacterWinForms.Models.CustomProgressBar();
            this.barHealth = new GameCharacterWinForms.Models.CustomProgressBar();
            this.gboxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portraitPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.BackColor = System.Drawing.Color.Gray;
            this.txtCharacterDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCharacterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterDetails.ForeColor = System.Drawing.Color.White;
            this.txtCharacterDetails.Location = new System.Drawing.Point(27, 19);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.Size = new System.Drawing.Size(116, 147);
            this.txtCharacterDetails.TabIndex = 17;
            this.txtCharacterDetails.Text = resources.GetString("txtCharacterDetails.Text");
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Tomato;
            this.btnAttack.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttack.Location = new System.Drawing.Point(677, 361);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(192, 34);
            this.btnAttack.TabIndex = 18;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDefend.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDefend.Location = new System.Drawing.Point(677, 401);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(192, 34);
            this.btnDefend.TabIndex = 19;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = false;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLevelUp.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLevelUp.Location = new System.Drawing.Point(677, 441);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(192, 34);
            this.btnLevelUp.TabIndex = 20;
            this.btnLevelUp.Text = "Level Up";
            this.btnLevelUp.UseVisualStyleBackColor = false;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // battleLog
            // 
            this.battleLog.BackColor = System.Drawing.Color.Gainsboro;
            this.battleLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battleLog.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLog.FormattingEnabled = true;
            this.battleLog.ItemHeight = 17;
            this.battleLog.Location = new System.Drawing.Point(156, 358);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(515, 121);
            this.battleLog.TabIndex = 21;
            this.battleLog.Tag = "STATUS";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Location = new System.Drawing.Point(586, 450);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(81, 23);
            this.btnMenu.TabIndex = 29;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergy.ForeColor = System.Drawing.Color.White;
            this.lblEnergy.Location = new System.Drawing.Point(129, 31);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(26, 15);
            this.lblEnergy.TabIndex = 31;
            this.lblEnergy.Text = "MP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "HP";
            // 
            // gboxStatus
            // 
            this.gboxStatus.BackColor = System.Drawing.Color.Gray;
            this.gboxStatus.Controls.Add(this.iconStatus3);
            this.gboxStatus.Controls.Add(this.iconStatus2);
            this.gboxStatus.Controls.Add(this.iconStatus1);
            this.gboxStatus.Controls.Add(this.iconStatus7);
            this.gboxStatus.Controls.Add(this.txtCharacterDetails);
            this.gboxStatus.Controls.Add(this.iconStatus6);
            this.gboxStatus.Controls.Add(this.iconStatus5);
            this.gboxStatus.Controls.Add(this.iconStatus4);
            this.gboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxStatus.ForeColor = System.Drawing.Color.White;
            this.gboxStatus.Location = new System.Drawing.Point(12, 335);
            this.gboxStatus.Name = "gboxStatus";
            this.gboxStatus.Size = new System.Drawing.Size(138, 146);
            this.gboxStatus.TabIndex = 36;
            this.gboxStatus.TabStop = false;
            this.gboxStatus.Text = "STATUS";
            // 
            // iconStatus3
            // 
            this.iconStatus3.Image = global::GameCharacterWinForms.Properties.Resources.level_up__2_;
            this.iconStatus3.Location = new System.Drawing.Point(6, 66);
            this.iconStatus3.Name = "iconStatus3";
            this.iconStatus3.Size = new System.Drawing.Size(14, 14);
            this.iconStatus3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus3.TabIndex = 42;
            this.iconStatus3.TabStop = false;
            // 
            // iconStatus2
            // 
            this.iconStatus2.Image = global::GameCharacterWinForms.Properties.Resources.swords;
            this.iconStatus2.Location = new System.Drawing.Point(8, 35);
            this.iconStatus2.Name = "iconStatus2";
            this.iconStatus2.Size = new System.Drawing.Size(14, 14);
            this.iconStatus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus2.TabIndex = 41;
            this.iconStatus2.TabStop = false;
            // 
            // iconStatus1
            // 
            this.iconStatus1.Image = global::GameCharacterWinForms.Properties.Resources.wizard;
            this.iconStatus1.Location = new System.Drawing.Point(8, 20);
            this.iconStatus1.Name = "iconStatus1";
            this.iconStatus1.Size = new System.Drawing.Size(14, 14);
            this.iconStatus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus1.TabIndex = 40;
            this.iconStatus1.TabStop = false;
            // 
            // iconStatus7
            // 
            this.iconStatus7.Image = global::GameCharacterWinForms.Properties.Resources.magic_wand;
            this.iconStatus7.Location = new System.Drawing.Point(6, 124);
            this.iconStatus7.Name = "iconStatus7";
            this.iconStatus7.Size = new System.Drawing.Size(14, 14);
            this.iconStatus7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus7.TabIndex = 39;
            this.iconStatus7.TabStop = false;
            // 
            // iconStatus6
            // 
            this.iconStatus6.Image = global::GameCharacterWinForms.Properties.Resources.wizard_hat;
            this.iconStatus6.Location = new System.Drawing.Point(6, 109);
            this.iconStatus6.Name = "iconStatus6";
            this.iconStatus6.Size = new System.Drawing.Size(14, 14);
            this.iconStatus6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus6.TabIndex = 38;
            this.iconStatus6.TabStop = false;
            // 
            // iconStatus5
            // 
            this.iconStatus5.Image = ((System.Drawing.Image)(resources.GetObject("iconStatus5.Image")));
            this.iconStatus5.Location = new System.Drawing.Point(6, 94);
            this.iconStatus5.Name = "iconStatus5";
            this.iconStatus5.Size = new System.Drawing.Size(14, 14);
            this.iconStatus5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus5.TabIndex = 37;
            this.iconStatus5.TabStop = false;
            // 
            // iconStatus4
            // 
            this.iconStatus4.Image = ((System.Drawing.Image)(resources.GetObject("iconStatus4.Image")));
            this.iconStatus4.Location = new System.Drawing.Point(6, 80);
            this.iconStatus4.Name = "iconStatus4";
            this.iconStatus4.Size = new System.Drawing.Size(14, 14);
            this.iconStatus4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus4.TabIndex = 37;
            this.iconStatus4.TabStop = false;
            // 
            // iconEnergy
            // 
            this.iconEnergy.BackColor = System.Drawing.Color.Transparent;
            this.iconEnergy.Image = ((System.Drawing.Image)(resources.GetObject("iconEnergy.Image")));
            this.iconEnergy.Location = new System.Drawing.Point(113, 31);
            this.iconEnergy.Name = "iconEnergy";
            this.iconEnergy.Size = new System.Drawing.Size(15, 15);
            this.iconEnergy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconEnergy.TabIndex = 33;
            this.iconEnergy.TabStop = false;
            // 
            // iconHealth
            // 
            this.iconHealth.BackColor = System.Drawing.Color.Transparent;
            this.iconHealth.Image = ((System.Drawing.Image)(resources.GetObject("iconHealth.Image")));
            this.iconHealth.Location = new System.Drawing.Point(113, 11);
            this.iconHealth.Name = "iconHealth";
            this.iconHealth.Size = new System.Drawing.Size(15, 15);
            this.iconHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHealth.TabIndex = 32;
            this.iconHealth.TabStop = false;
            // 
            // portraitPlayer
            // 
            this.portraitPlayer.BackColor = System.Drawing.Color.RoyalBlue;
            this.portraitPlayer.Image = global::GameCharacterWinForms.Properties.Resources.Mage_Portrait;
            this.portraitPlayer.Location = new System.Drawing.Point(12, 8);
            this.portraitPlayer.Name = "portraitPlayer";
            this.portraitPlayer.Size = new System.Drawing.Size(96, 83);
            this.portraitPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portraitPlayer.TabIndex = 22;
            this.portraitPlayer.TabStop = false;
            // 
            // CharacterIdle
            // 
            this.CharacterIdle.BackColor = System.Drawing.Color.Transparent;
            this.CharacterIdle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CharacterIdle.Image = global::GameCharacterWinForms.Properties.Resources.Warrior_Idle;
            this.CharacterIdle.Location = new System.Drawing.Point(29, 146);
            this.CharacterIdle.Name = "CharacterIdle";
            this.CharacterIdle.Size = new System.Drawing.Size(503, 212);
            this.CharacterIdle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharacterIdle.TabIndex = 37;
            this.CharacterIdle.TabStop = false;
            // 
            // CharacterAction
            // 
            this.CharacterAction.BackColor = System.Drawing.Color.Transparent;
            this.CharacterAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CharacterAction.Image = global::GameCharacterWinForms.Properties.Resources.witch_attack;
            this.CharacterAction.Location = new System.Drawing.Point(311, 159);
            this.CharacterAction.Name = "CharacterAction";
            this.CharacterAction.Size = new System.Drawing.Size(404, 166);
            this.CharacterAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharacterAction.TabIndex = 38;
            this.CharacterAction.TabStop = false;
            this.CharacterAction.Visible = false;
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1500;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Tomato;
            this.pictureBox3.Image = global::GameCharacterWinForms.Properties.Resources.swords;
            this.pictureBox3.Location = new System.Drawing.Point(834, 365);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.Image = global::GameCharacterWinForms.Properties.Resources.shield__1_;
            this.pictureBox4.Location = new System.Drawing.Point(834, 405);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox5.Image = global::GameCharacterWinForms.Properties.Resources.level_up;
            this.pictureBox5.Location = new System.Drawing.Point(834, 446);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::GameCharacterWinForms.Properties.Resources.Orc_Portrait;
            this.pictureBox8.Location = new System.Drawing.Point(773, 16);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(96, 79);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 52;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(752, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(728, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "HP";
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.BackColor = System.Drawing.Color.Transparent;
            this.lblVersus.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersus.ForeColor = System.Drawing.Color.Gold;
            this.lblVersus.Location = new System.Drawing.Point(426, 15);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(47, 36);
            this.lblVersus.TabIndex = 55;
            this.lblVersus.Text = "VS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GameCharacterWinForms.Properties.Resources.health_care__1_;
            this.pictureBox1.Location = new System.Drawing.Point(752, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(728, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "SP";
            // 
            // EnemyIdle
            // 
            this.EnemyIdle.BackColor = System.Drawing.Color.Transparent;
            this.EnemyIdle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyIdle.Image = global::GameCharacterWinForms.Properties.Resources.Orc_Idle;
            this.EnemyIdle.Location = new System.Drawing.Point(363, 178);
            this.EnemyIdle.Name = "EnemyIdle";
            this.EnemyIdle.Size = new System.Drawing.Size(519, 200);
            this.EnemyIdle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyIdle.TabIndex = 59;
            this.EnemyIdle.TabStop = false;
            // 
            // EnemyAction
            // 
            this.EnemyAction.BackColor = System.Drawing.Color.Transparent;
            this.EnemyAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyAction.Image = global::GameCharacterWinForms.Properties.Resources.Orc_Attack;
            this.EnemyAction.Location = new System.Drawing.Point(354, 169);
            this.EnemyAction.Name = "EnemyAction";
            this.EnemyAction.Size = new System.Drawing.Size(166, 200);
            this.EnemyAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyAction.TabIndex = 60;
            this.EnemyAction.TabStop = false;
            // 
            // deathAnimationTimer
            // 
            this.deathAnimationTimer.Interval = 200;
            // 
            // pictureBoxWin
            // 
            this.pictureBoxWin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWin.Image = global::GameCharacterWinForms.Properties.Resources.youwin;
            this.pictureBoxWin.Location = new System.Drawing.Point(227, 20);
            this.pictureBoxWin.Name = "pictureBoxWin";
            this.pictureBoxWin.Size = new System.Drawing.Size(459, 196);
            this.pictureBoxWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxWin.TabIndex = 61;
            this.pictureBoxWin.TabStop = false;
            this.pictureBoxWin.Visible = false;
            this.pictureBoxWin.Click += new System.EventHandler(this.pictureBoxWin_Click);
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.Location = new System.Drawing.Point(626, 38);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.ProgressBarColor = System.Drawing.Color.LimeGreen;
            this.customProgressBar1.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar1.TabIndex = 56;
            this.customProgressBar1.Value = 100;
            // 
            // barEnemyHealth
            // 
            this.barEnemyHealth.Location = new System.Drawing.Point(586, 20);
            this.barEnemyHealth.Name = "barEnemyHealth";
            this.barEnemyHealth.ProgressBarColor = System.Drawing.Color.Red;
            this.barEnemyHealth.Size = new System.Drawing.Size(140, 8);
            this.barEnemyHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barEnemyHealth.TabIndex = 50;
            this.barEnemyHealth.Value = 100;
            // 
            // barEnergy
            // 
            this.barEnergy.Location = new System.Drawing.Point(156, 35);
            this.barEnergy.Name = "barEnergy";
            this.barEnergy.ProgressBarColor = System.Drawing.Color.DeepSkyBlue;
            this.barEnergy.Size = new System.Drawing.Size(100, 8);
            this.barEnergy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barEnergy.TabIndex = 35;
            this.barEnergy.Value = 100;
            // 
            // barHealth
            // 
            this.barHealth.Location = new System.Drawing.Point(156, 16);
            this.barHealth.Name = "barHealth";
            this.barHealth.ProgressBarColor = System.Drawing.Color.Red;
            this.barHealth.Size = new System.Drawing.Size(140, 8);
            this.barHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHealth.TabIndex = 34;
            this.barHealth.Value = 100;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.Battleground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 487);
            this.Controls.Add(this.CharacterAction);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.barEnemyHealth);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gboxStatus);
            this.Controls.Add(this.barEnergy);
            this.Controls.Add(this.barHealth);
            this.Controls.Add(this.iconEnergy);
            this.Controls.Add(this.iconHealth);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.portraitPlayer);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.EnemyAction);
            this.Controls.Add(this.EnemyIdle);
            this.Controls.Add(this.CharacterIdle);
            this.Controls.Add(this.pictureBoxWin);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gboxStatus.ResumeLayout(false);
            this.gboxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portraitPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.ListBox battleLog;
        private PictureBox portraitPlayer;
        private Button btnMenu;
        private Models.CustomProgressBar barEnergy;
        private Models.CustomProgressBar barHealth;
        private PictureBox iconEnergy;
        private PictureBox iconHealth;
        private Label lblEnergy;
        private Label label5;
        private GroupBox gboxStatus;
        private PictureBox iconStatus4;
        private PictureBox iconStatus5;
        private PictureBox iconStatus7;
        private PictureBox iconStatus6;
        private PictureBox iconStatus2;
        private PictureBox iconStatus1;
        private PictureBox iconStatus3;
        private PictureBox CharacterIdle;
        private PictureBox CharacterAction;
        private Timer animationTimer;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Models.CustomProgressBar barEnemyHealth;
        private PictureBox pictureBox8;
        private PictureBox pictureBox2;
        private Label label1;
        private Label lblVersus;
        private PictureBox pictureBox1;
        private Label label2;
        private Models.CustomProgressBar customProgressBar1;
        private PictureBox EnemyIdle;
        private PictureBox EnemyAction;
        private Timer deathAnimationTimer;
        private PictureBox pictureBoxWin;
    }
}