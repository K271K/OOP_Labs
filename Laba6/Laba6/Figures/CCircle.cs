using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Laba6.Figures
{
    internal class CCircle : CShape
    {
        public CCircle(int _x, int _y, int _size, Color _color) : base(_x, _y, _size, _color) {; }
        public override bool checkHit(int ClickX, int ClickY)
        {
            if (Math.Pow((ClickX - x), 2) + Math.Pow((ClickY - y), 2) < Math.Pow((size / 2), 2))
            {
                return true;
            }
            return false;
        }
        public override void draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isSelected)
            {
                g.FillEllipse(new SolidBrush(color), x - size / 2, y - size / 2, this.size, this.size);
                g.DrawEllipse(new Pen(Color.Black, 3), x - size / 2, y - size / 2, this.size, this.size);
            }
            else
            {
                g.FillEllipse(new SolidBrush(color), x - size / 2, y - size / 2, this.size, this.size);
            }

        }
        public override void save(StreamWriter SW) {
            SW.WriteLine("Circle");
            base.save(SW);
        }
        /*public override void load() {; }*/

        public override bool isAvailableLocation(int w, int h, int dX, int dY)
        {
            if (this.y + size/2 + dY >= size && this.x + size/2 + dX >= size && this.y + size/2 + dY <= h && this.x + size/2 + dX <= w)
            {
                return true;
            }
            return false;
        }
    }
}
