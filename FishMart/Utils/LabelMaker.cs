using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Utils
{
    public class LabelMaker
    {
        public Label MakeLabel(string text, int size, FontStyle style, int top, int left = 0, int width = 350, ContentAlignment align = ContentAlignment.MiddleLeft)
        {
            return new Label()
            {
                Text = text,
                Font = new Font("Poppins", size, style),
                AutoSize = false,
                Width = width,
                Top = top,
                Left = left,
                TextAlign = align
            };
        }

        public Label MakeSeparator(int top)
        {
            return new Label()
            {
                Text = "----------------------------------------------",
                AutoSize = false,
                Width = 350,
                Top = top,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }
    }
}
