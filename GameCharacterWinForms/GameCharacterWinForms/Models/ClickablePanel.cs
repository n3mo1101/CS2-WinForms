using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCharacterWinForms.Models
{
    public class ClickablePanel : Panel
    {
        private Color _defaultBackColor;
        private Color _hoverBackColor = Color.Transparent; // Hover color
        private Color _clickBackColor = Color.Transparent;    // Click color

        public ClickablePanel()
        {
            // Store the default back color
            _defaultBackColor = this.BackColor;

            // Attach event handlers for mouse events
            this.MouseEnter += ClickablePanel_MouseEnter;
            this.MouseLeave += ClickablePanel_MouseLeave;
            this.MouseDown += ClickablePanel_MouseDown;
            this.MouseUp += ClickablePanel_MouseUp;

            //this.Click += (s, e) => OnClick(e); // Ensure the panel handles click events
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            // Forward child control clicks to the parent panel
            e.Control.Click += (s, args) => this.OnClick(e);
            e.Control.MouseEnter += (s, args) => this.OnMouseEnter(args);
            e.Control.MouseLeave += (s, args) => this.OnMouseLeave(args);
        }

        private void ClickablePanel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = _hoverBackColor;
        }

        private void ClickablePanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _defaultBackColor;
        }

        private void ClickablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = _clickBackColor;
        }

        private void ClickablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = _hoverBackColor;
        }
    }
}


