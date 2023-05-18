using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Figures
{
    internal class CSquare : CShape
    {
        public CSquare(int _x, int _y, int _size, Color _color) : base(_x, _y, _size, _color) { }
        public override bool checkHit(int ClickX, int ClickY)
        {
            if (this.x - size / 2 <= ClickX && ClickX <= this.x + size / 2 && this.y - size / 2 <= ClickY && ClickY <= this.y + size / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (GetSelected())
            {
                g.FillRectangle(new SolidBrush(color), x - size / 2, y - size / 2, size, size);
                g.DrawRectangle(new Pen(Color.Black, 3), x - size / 2, y - size / 2, this.size, this.size);
            }
            else
            {
                g.FillRectangle(new SolidBrush(color), x - size / 2, y - size / 2, size, size);
            }
        }

        public override void load()
        {

        }

        public override void save()
        {

        }
    }
}
