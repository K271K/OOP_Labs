using Laba6.Figures;

namespace Laba6
{
    public partial class Form1 : Form
    {
        MyList<CShape> Figures = new MyList<CShape>();
        public string choosenFigure;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bool isNew = true;
            foreach (CShape s in Figures)
            {
                if (s.checkHit(e.X, e.Y))
                {
                    if (s.GetSelected() == true)
                        s.DeSelect();
                    else
                        s.Select();
                    isNew = false;
                }
            }
            if (isNew)
            {
                if (choosenFigure == "Circle")
                {
                    CShape c = new CCircle(e.X, e.Y, 50, Color.Blue);
                    Figures.push_back(c);
                }
                if (choosenFigure == "Square")
                {
                    CShape s = new CSquare(e.X, e.Y, 50, Color.Blue);
                    Figures.push_back(s);
                }
                if (choosenFigure == "Triangle")
                {
                    CShape s = new CTriangle(e.X, e.Y, 50, Color.Blue);
                    Figures.push_back(s);
                }
            }
            pictureBox1.Invalidate();
        }
        //Отрисовка всех фигур
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (CShape s in Figures)
            {
                s.draw(e);
            }
        }
        //Выбор фигуры, которая будет рисоваться
        private void buttonFigure_Click(object sender, EventArgs e)
        {
            if (sender == buttonCircle)
            {
                choosenFigure = "Circle";
            }
            if (sender == buttonSquare)
            {
                choosenFigure = "Square";
            }
            if (sender == buttonTriangle)
            {
                choosenFigure = "Triangle";
            }
        }
    }

}