namespace GameCharacterWinForms
{
    partial class Form1
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
            this.exit = new System.Windows.Forms.PictureBox();
            this.startgame = new System.Windows.Forms.PictureBox();
            this.pictureTitle = new System.Windows.Forms.PictureBox();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startgame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::GameCharacterWinForms.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(319, 279);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(158, 34);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 7;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // startgame
            // 
            this.startgame.BackColor = System.Drawing.Color.Transparent;
            this.startgame.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.start;
            this.startgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startgame.Location = new System.Drawing.Point(319, 239);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(158, 34);
            this.startgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startgame.TabIndex = 6;
            this.startgame.TabStop = false;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // pictureTitle
            // 
            this.pictureTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureTitle.Image = global::GameCharacterWinForms.Properties.Resources.Title;
            this.pictureTitle.Location = new System.Drawing.Point(178, 77);
            this.pictureTitle.Name = "pictureTitle";
            this.pictureTitle.Size = new System.Drawing.Size(465, 101);
            this.pictureTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTitle.TabIndex = 3;
            this.pictureTitle.TabStop = false;
            // 
            // pictureBackground
            // 
            this.pictureBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBackground.Image = global::GameCharacterWinForms.Properties.Resources.bg_main;
            this.pictureBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(800, 450);
            this.pictureBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackground.TabIndex = 2;
            this.pictureBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.startgame);
            this.Controls.Add(this.pictureTitle);
            this.Controls.Add(this.pictureBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startgame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.PictureBox pictureTitle;
        private System.Windows.Forms.PictureBox startgame;
        private System.Windows.Forms.PictureBox exit;
    }
}

