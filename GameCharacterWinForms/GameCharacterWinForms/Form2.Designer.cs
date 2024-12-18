namespace GameCharacterWinForms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnToBattle = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCharacterType = new System.Windows.Forms.ComboBox();
            this.pictureSelectedClass = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.txtpictureSelectedClass = new System.Windows.Forms.PictureBox();
            this.panelMage = new GameCharacterWinForms.Models.ClickablePanel();
            this.customProgressBar4 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.customProgressBar3 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblMana = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panelWarrior = new GameCharacterWinForms.Models.ClickablePanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblWarriorDescription = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customProgressBar2 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.customProgressBar1 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblWarriorLevel = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblStamina = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelectedClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureSelectedClass)).BeginInit();
            this.panelMage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panelWarrior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToBattle
            // 
            this.btnToBattle.BackColor = System.Drawing.SystemColors.Control;
            this.btnToBattle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBattle.Location = new System.Drawing.Point(298, 389);
            this.btnToBattle.Name = "btnToBattle";
            this.btnToBattle.Size = new System.Drawing.Size(199, 42);
            this.btnToBattle.TabIndex = 0;
            this.btnToBattle.Text = "FIGHT!";
            this.btnToBattle.UseVisualStyleBackColor = false;
            this.btnToBattle.Click += new System.EventHandler(this.btnToBattle_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(301, 356);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 22);
            this.txtName.TabIndex = 16;
            this.txtName.Text = "Enter Name";
            // 
            // cmbCharacterType
            // 
            this.cmbCharacterType.FormattingEnabled = true;
            this.cmbCharacterType.Items.AddRange(new object[] {
            "Warrior",
            "Mage"});
            this.cmbCharacterType.Location = new System.Drawing.Point(337, 396);
            this.cmbCharacterType.Name = "cmbCharacterType";
            this.cmbCharacterType.Size = new System.Drawing.Size(121, 21);
            this.cmbCharacterType.TabIndex = 23;
            // 
            // pictureSelectedClass
            // 
            this.pictureSelectedClass.BackColor = System.Drawing.Color.Transparent;
            this.pictureSelectedClass.Image = global::GameCharacterWinForms.Properties.Resources.sword__3_;
            this.pictureSelectedClass.Location = new System.Drawing.Point(304, 307);
            this.pictureSelectedClass.Name = "pictureSelectedClass";
            this.pictureSelectedClass.Size = new System.Drawing.Size(33, 31);
            this.pictureSelectedClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSelectedClass.TabIndex = 21;
            this.pictureSelectedClass.TabStop = false;
            this.pictureSelectedClass.Visible = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(457, 396);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(30, 30);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(307, 396);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::GameCharacterWinForms.Properties.Resources.SelecChar;
            this.pictureBox13.Location = new System.Drawing.Point(304, -7);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(206, 89);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 21;
            this.pictureBox13.TabStop = false;
            // 
            // txtpictureSelectedClass
            // 
            this.txtpictureSelectedClass.BackColor = System.Drawing.Color.Transparent;
            this.txtpictureSelectedClass.Image = global::GameCharacterWinForms.Properties.Resources.warrior_txt;
            this.txtpictureSelectedClass.Location = new System.Drawing.Point(292, 300);
            this.txtpictureSelectedClass.Name = "txtpictureSelectedClass";
            this.txtpictureSelectedClass.Size = new System.Drawing.Size(218, 50);
            this.txtpictureSelectedClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtpictureSelectedClass.TabIndex = 25;
            this.txtpictureSelectedClass.TabStop = false;
            this.txtpictureSelectedClass.Visible = false;
            // 
            // panelMage
            // 
            this.panelMage.BackColor = System.Drawing.Color.Transparent;
            this.panelMage.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.bg_scroll;
            this.panelMage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMage.Controls.Add(this.customProgressBar4);
            this.panelMage.Controls.Add(this.label1);
            this.panelMage.Controls.Add(this.customProgressBar3);
            this.panelMage.Controls.Add(this.label2);
            this.panelMage.Controls.Add(this.label6);
            this.panelMage.Controls.Add(this.pictureBox9);
            this.panelMage.Controls.Add(this.pictureBox6);
            this.panelMage.Controls.Add(this.lblIntelligence);
            this.panelMage.Controls.Add(this.label5);
            this.panelMage.Controls.Add(this.pictureBox8);
            this.panelMage.Controls.Add(this.pictureBox7);
            this.panelMage.Controls.Add(this.lblMana);
            this.panelMage.Controls.Add(this.pictureBox10);
            this.panelMage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMage.Location = new System.Drawing.Point(417, 68);
            this.panelMage.Name = "panelMage";
            this.panelMage.Size = new System.Drawing.Size(341, 230);
            this.panelMage.TabIndex = 22;
            this.panelMage.Click += new System.EventHandler(this.panelMage_Click);
            this.panelMage.MouseLeave += new System.EventHandler(this.panelMage_MouseLeave);
            this.panelMage.MouseHover += new System.EventHandler(this.panelMage_MouseHover);
            // 
            // customProgressBar4
            // 
            this.customProgressBar4.Location = new System.Drawing.Point(200, 59);
            this.customProgressBar4.Name = "customProgressBar4";
            this.customProgressBar4.ProgressBarColor = System.Drawing.Color.DeepSkyBlue;
            this.customProgressBar4.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar4.TabIndex = 22;
            this.customProgressBar4.Value = 100;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "A powerful spellcaster, the Mage harnesses elemental and mystical magic to contro" +
    "l the battlefield.";
            // 
            // customProgressBar3
            // 
            this.customProgressBar3.Location = new System.Drawing.Point(200, 40);
            this.customProgressBar3.Name = "customProgressBar3";
            this.customProgressBar3.ProgressBarColor = System.Drawing.Color.Red;
            this.customProgressBar3.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar3.TabIndex = 21;
            this.customProgressBar3.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spell Power : 10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(173, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Level : 1";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(181, 107);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 15);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(157, 55);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligence.ForeColor = System.Drawing.Color.White;
            this.lblIntelligence.Location = new System.Drawing.Point(201, 107);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(84, 15);
            this.lblIntelligence.TabIndex = 4;
            this.lblIntelligence.Text = "Intelligence : 25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(173, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "HP";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(182, 126);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 15);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(157, 35);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 15);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMana.ForeColor = System.Drawing.Color.White;
            this.lblMana.Location = new System.Drawing.Point(173, 55);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(23, 16);
            this.lblMana.TabIndex = 3;
            this.lblMana.Text = "MP";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::GameCharacterWinForms.Properties.Resources.witch_float;
            this.pictureBox10.Location = new System.Drawing.Point(16, 35);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(181, 175);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // panelWarrior
            // 
            this.panelWarrior.BackColor = System.Drawing.Color.Transparent;
            this.panelWarrior.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.bg_scroll;
            this.panelWarrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWarrior.Controls.Add(this.pictureBox5);
            this.panelWarrior.Controls.Add(this.pictureBox4);
            this.panelWarrior.Controls.Add(this.lblWarriorDescription);
            this.panelWarrior.Controls.Add(this.pictureBox3);
            this.panelWarrior.Controls.Add(this.pictureBox2);
            this.panelWarrior.Controls.Add(this.customProgressBar2);
            this.panelWarrior.Controls.Add(this.customProgressBar1);
            this.panelWarrior.Controls.Add(this.lblArmor);
            this.panelWarrior.Controls.Add(this.lblWarriorLevel);
            this.panelWarrior.Controls.Add(this.lblStrength);
            this.panelWarrior.Controls.Add(this.lblHealth);
            this.panelWarrior.Controls.Add(this.lblStamina);
            this.panelWarrior.Controls.Add(this.pictureBox1);
            this.panelWarrior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelWarrior.Location = new System.Drawing.Point(43, 68);
            this.panelWarrior.Name = "panelWarrior";
            this.panelWarrior.Size = new System.Drawing.Size(341, 230);
            this.panelWarrior.TabIndex = 21;
            this.panelWarrior.Click += new System.EventHandler(this.panelWarrior_Click);
            this.panelWarrior.MouseLeave += new System.EventHandler(this.panelWarrior_MouseLeave);
            this.panelWarrior.MouseHover += new System.EventHandler(this.panelWarrior_MouseHover);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(155, 56);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(155, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // lblWarriorDescription
            // 
            this.lblWarriorDescription.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarriorDescription.ForeColor = System.Drawing.Color.White;
            this.lblWarriorDescription.Location = new System.Drawing.Point(150, 153);
            this.lblWarriorDescription.Name = "lblWarriorDescription";
            this.lblWarriorDescription.Size = new System.Drawing.Size(152, 55);
            this.lblWarriorDescription.TabIndex = 6;
            this.lblWarriorDescription.Text = "A resilient frontline fighter, the Warrior excels in melee combat, using strength" +
    " and heavy armor.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(182, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(183, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // customProgressBar2
            // 
            this.customProgressBar2.Location = new System.Drawing.Point(198, 60);
            this.customProgressBar2.Name = "customProgressBar2";
            this.customProgressBar2.ProgressBarColor = System.Drawing.Color.LimeGreen;
            this.customProgressBar2.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar2.TabIndex = 20;
            this.customProgressBar2.Value = 100;
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.Location = new System.Drawing.Point(198, 41);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.ProgressBarColor = System.Drawing.Color.Red;
            this.customProgressBar1.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar1.TabIndex = 19;
            this.customProgressBar1.Value = 100;
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmor.ForeColor = System.Drawing.Color.White;
            this.lblArmor.Location = new System.Drawing.Point(203, 128);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(62, 15);
            this.lblArmor.TabIndex = 5;
            this.lblArmor.Text = "Armor : 10";
            // 
            // lblWarriorLevel
            // 
            this.lblWarriorLevel.AutoSize = true;
            this.lblWarriorLevel.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarriorLevel.ForeColor = System.Drawing.Color.White;
            this.lblWarriorLevel.Location = new System.Drawing.Point(171, 85);
            this.lblWarriorLevel.Name = "lblWarriorLevel";
            this.lblWarriorLevel.Size = new System.Drawing.Size(47, 15);
            this.lblWarriorLevel.TabIndex = 1;
            this.lblWarriorLevel.Text = "Level : 1";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.Color.White;
            this.lblStrength.Location = new System.Drawing.Point(203, 107);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(73, 15);
            this.lblStrength.TabIndex = 4;
            this.lblStrength.Text = "Strength : 25";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(171, 36);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(23, 16);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "HP";
            // 
            // lblStamina
            // 
            this.lblStamina.AutoSize = true;
            this.lblStamina.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStamina.ForeColor = System.Drawing.Color.White;
            this.lblStamina.Location = new System.Drawing.Point(171, 56);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(23, 16);
            this.lblStamina.TabIndex = 3;
            this.lblStamina.Text = "SP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameCharacterWinForms.Properties.Resources.Warrior_Idle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.bg_sword;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureSelectedClass);
            this.Controls.Add(this.panelMage);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.btnToBattle);
            this.Controls.Add(this.cmbCharacterType);
            this.Controls.Add(this.panelWarrior);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.txtpictureSelectedClass);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelectedClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureSelectedClass)).EndInit();
            this.panelMage.ResumeLayout(false);
            this.panelMage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panelWarrior.ResumeLayout(false);
            this.panelWarrior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToBattle;
        private System.Windows.Forms.Label lblWarriorLevel;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblWarriorDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private Models.CustomProgressBar customProgressBar2;
        private Models.CustomProgressBar customProgressBar1;
        private Models.CustomProgressBar customProgressBar4;
        private Models.CustomProgressBar customProgressBar3;
        private Models.ClickablePanel panelWarrior;
        private Models.ClickablePanel panelMage;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.PictureBox pictureSelectedClass;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox txtpictureSelectedClass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}