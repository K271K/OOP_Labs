using Laba6.Factory;
using Laba6.Figures;

namespace Laba6
{
    public partial class Form1 : Form
    {
        MyList<CShape> Figures = new MyList<CShape>();
        CMyShapeFactory Factory = new CMyShapeFactory();
        public string choosenFigure;
        Color ChosenColor;
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
                CShape cShape = Factory.createShape(choosenFigure, e.X, e.Y, 50, ChosenColor);
                Figures.push_back(cShape);
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

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ChosenColor = ((Button)sender).BackColor;
        }

        private void AnyColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ChosenColor = colorDialog1.Color;
                ((Button)sender).BackColor = ChosenColor;
            }
        }
    }

}