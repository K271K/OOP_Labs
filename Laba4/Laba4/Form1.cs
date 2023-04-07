namespace Laba4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        Brush brush;
       
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            brush = new SolidBrush(Color.Gray);

        }
        class CCircle
        {
            public float x, y;
            public float radius = 50;

            public CCircle(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            CCircle kryg = new CCircle(e.X - 25, e.Y - 25);
            g.DrawEllipse(pen, kryg.x, kryg.y, kryg.radius, kryg.radius);
        }
    }
}