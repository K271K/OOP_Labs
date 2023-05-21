using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Figures
{
    internal class CTriangle : CShape
    {
        private float radius;
        private Point point1;
        private Point point2; 
        private Point point3;

        public CTriangle(int _x, int _y, int _size, Color _color): base(_x, _y, _size, _color)
        {
            radius = (float)(size / Math.Sqrt(3));
            this.point1 = new Point(this.x, (int)(this.y - this.size));
            this.point2 = new Point((int)(this.x + this.size * 0.5), (int)(this.y + this.radius * 0.5));
            this.point3 = new Point((int)(this.x - this.size * 0.5), (int)(this.y + this.radius * 0.5));
        }
        public override bool checkHit(int ClickX, int ClickY)
        {
            if ((point1.X - ClickX) * (point2.Y - point1.Y) - (point2.X - point1.X) * (point1.Y - ClickY) >= 0 &&
                (point2.X - ClickX) * (point3.Y - point2.Y) - (point3.X - point2.X) * (point2.Y - ClickY) >= 0 &&
                (point3.X - ClickX) * (point1.Y - point3.Y) - (point1.X - point3.X) * (point3.Y - ClickY) >= 0)
            {
                return true;
            }
            if ((point1.X - ClickX) * (point2.Y - point1.Y) - (point2.X - point1.X) * (point1.Y - ClickY) < 0 &&
                (point2.X - ClickX) * (point3.Y - point2.Y) - (point3.X - point2.X) * (point2.Y - ClickY) < 0 &&
                (point3.X - ClickX) * (point1.Y - point3.Y) - (point1.X - point3.X) * (point3.Y - ClickY) < 0)
            {
                return true;
            }
            return false;
        }
        public override void draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            point1 = new Point(this.x, (int)(this.y - this.size));
            point2 = new Point((int)(this.x + this.size * 0.5), (int)(this.y + this.radius * 0.5));
            point3 = new Point((int)(this.x - this.size * 0.5), (int)(this.y + this.radius * 0.5));
            if (isSelected)
            {
                g.FillPolygon(new SolidBrush(color), new[] { point1, point2, point3 });
                g.DrawLines(new Pen(Color.Black, 3), new[] { point1, point2, point3, point1 });
            }
            else
            {
                g.FillPolygon(new SolidBrush(color), new[] { point1, point2, point3, point1 });
            }
        }
        public override bool isAvailableLocation(int w, int h, int dX, int dY)
        {
            if (point1.Y + dY >= 0 && point3.X + dX >= 0 && point3.Y + dY < h && point2.X + dX <= w)
            {
                return true;
            }
            return false;
        }
        public override void save(StreamWriter SW)
        {
            SW.WriteLine("Triangle");
            base.save(SW);
        }
    }
}
