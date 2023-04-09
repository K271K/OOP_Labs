using System.Drawing;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Graphics g;
        Pen pen;
        Brush brush;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
        class CCircle
        {
            public float x, y;
            public float radius = 50;
            Pen pen = new Pen(Color.Black, 10);
            public CCircle(int _x, int _y, Graphics _g)
            {
                this.x = _x;
                this.y = _y;
                _g.DrawEllipse(pen, x, y, radius, radius);
                _g.FillEllipse(Brushes.DeepPink, x, y, radius, radius);
            }
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            CCircle kryg = new CCircle(e.X - 25, e.Y - 25, g);
        }

    }
}