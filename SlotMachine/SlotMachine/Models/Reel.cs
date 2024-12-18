using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    internal class Reel
    {
        private Image symbolImage; 
        private readonly PictureBox pictureBox;
        private readonly string[] symbols = { "cherries", "lemon", "bell", "watermelon", "plum", "diamond" };
        private readonly Random random = new Random();
        private readonly string imagePath = Path.Combine(Application.StartupPath, "Icons");

        public Reel(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.pictureBox.Paint += Reel_Paint;
            this.Symbol = symbols[random.Next(symbols.Length)];
        }

        public string Symbol
        {
            get => Path.GetFileNameWithoutExtension(symbolImage?.Tag as string);
            set
            {
                string imageFilePath = Path.Combine(imagePath, $"{value}.png");
                if (File.Exists(imageFilePath))
                {
                    symbolImage = Image.FromFile(imageFilePath);
                    symbolImage.Tag = imageFilePath;
                    pictureBox.Invalidate(); 
                }
                else
                {
                    throw new FileNotFoundException($"Image file not found: {imageFilePath}");
                }
            }
        }

        private void Reel_Paint(object sender, PaintEventArgs e)
        {
            if (symbolImage != null)
            {
                e.Graphics.DrawImage(symbolImage, pictureBox.ClientRectangle);
            }
        }

        public void Spin()
        {
            Symbol = symbols[random.Next(symbols.Length)];
        }
    }
}
