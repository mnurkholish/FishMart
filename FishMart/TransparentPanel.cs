using System;
using System.Drawing;
using System.Windows.Forms;

namespace FishMart
{
    public class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Jangan gambar background panel -> biarkan tembus
            // biar gambar di bawahnya (picturebox besar) terlihat
        }
    }
}
