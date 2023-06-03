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
            observer.Changed(e);
            observable.ToDefault();
        }
        public override bool isAvailableLocation(int w, int h, int dX, int dY)
        {
            if (this.y + size / 2 + dY >= size && this.x + size / 2 + dX >= size && this.y + size / 2 + dY <= h && this.x + size / 2 + dX <= w)
            {
                return true;
            }
            return false;
        }
        public override void save(StreamWriter SW)
        {
            SW.WriteLine("Square");
            base.save(SW);
        }
    }
}
