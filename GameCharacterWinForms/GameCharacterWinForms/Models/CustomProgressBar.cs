using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCharacterWinForms.Models
{
    public class CustomProgressBar : ProgressBar
    {
        public Color ProgressBarColor { get; set; } = Color.Blue;

        public CustomProgressBar()
        {
            // Enable double buffering to reduce flicker
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(ProgressBarColor))
            {
                // Calculate progress bar fill area
                int width = (int)(this.Width * ((double)this.Value / this.Maximum));

                // Draw the progress bar
                e.Graphics.FillRectangle(brush, 0, 0, width, this.Height);

                // Optionally, draw a border
                e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }

}
