using Laba6.Factory;
using Laba6.Figures;
using Laba6.Storage;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laba6
{
    public partial class Form1 : Form
    {
        MyCShapeList Figures = new MyCShapeList();
        CMyShapeFactory Factory = new CMyShapeFactory();

        public string choosenFigure = "Circle";
        public string filename;

        bool ctrlPressed = false;

        Color ChosenColor = Color.Red;

        public int defaultSize = 50;
        public int defaultDyW = -5;
        public int defaultDxA = -5;
        public int defaultDxD = 5;
        public int defaultDyS = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bool isNew = true;
            //Если нажат контрл выделять объекты
            if (ctrlPressed)
            {
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
            }
            //Если не нажат, то клик на уже созданный объект ничего не сделает
            else
            {
                foreach (CShape s in Figures)
                {
                    if (s.checkHit(e.X, e.Y))
                    {
                        isNew = false;
                    }

                }
            }
            //Если по координатам клика нет объекта создаем новый с помощью фабрики
            if (isNew)
            {
                CShape cShape = Factory.createShape(choosenFigure, e.X, e.Y, defaultSize, ChosenColor);
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
            foreach (CShape s in Figures)
            {
                if (s.GetSelected())
                {
                    s.ColorChange(ChosenColor);
                }
            }
            pictureBox1.Invalidate();
        }

        private void AnyColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ChosenColor = colorDialog1.Color;
                ((Button)sender).BackColor = ChosenColor;
                foreach (CShape s in Figures)
                {
                    if (s.GetSelected())
                    {
                        s.ColorChange(ChosenColor);
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    ctrlPressed = true;
                    break;
                case Keys.W:

                    foreach (CShape s in Figures)
                    {
                        if (s.GetSelected())
                            s.move(pictureBox1.Width, pictureBox1.Height, 0, defaultDyW);
                    }
                    break;
                case Keys.A:
                    foreach (CShape s in Figures)
                    {
                        if (s.GetSelected())
                            s.move(pictureBox1.Width, pictureBox1.Height, defaultDxA, 0);
                    }
                    break;
                case Keys.S:
                    foreach (CShape s in Figures)
                    {
                        if (s.GetSelected())
                            s.move(pictureBox1.Width, pictureBox1.Height, 0, defaultDyS);
                    }
                    break;
                case Keys.D:
                    foreach (CShape s in Figures)
                    {
                        if (s.GetSelected())
                            s.move(pictureBox1.Width, pictureBox1.Height, defaultDxD, 0);
                    }
                    break;
                case Keys.Oemplus:
                    foreach (CShape s in Figures)
                    {
                        if (s.GetSelected())
                        {
                            s.SizeChange(5, pictureBox1.Width, pictureBox1.Height);
                        }
                    }
                    break;
                case Keys.OemMinus:
                    foreach (CShape s in Figures)
                    {
                        if (s.GetSelected())
                        {
                            s.SizeChange(-5, pictureBox1.Width, pictureBox1.Height);
                        }
                    }
                    break;
                case Keys.Delete:

                    for (int i = 0; i < Figures.GetSize(); i++)
                    {
                        if (Figures[i].GetSelected())
                        {
                            Figures.remove(i);
                            i--;
                        }
                    }
                    break;
                case Keys.ShiftKey:
                    CGroup group = new CGroup();
                    for (int i = 0; i < Figures.GetSize(); i++)
                    {
                        if (Figures[i].GetSelected())
                        {
                            group.addShape(Figures[i]);
                            Figures.remove(i);
                            i--;
                        }
                    }
                    Figures.push_back(group);
                    break;
                case Keys.Z:
                    for (int i = 0; i < Figures.GetSize(); i++)
                    {
                        if (Figures[i].GetSelected() && Figures[i].isA("CGroup"))
                        {
                            CGroup g = Figures[i] as CGroup;
                            for (int j = 0; j < g.GetSize(); j++)
                            {
                                Figures.push_back(g.getItem(j));
                                g.getItem(j).DeSelect();
                            }
                            Figures.remove(i);
                            i--;
                        }
                    }
                    break;
                default:
                    break;
            }
            pictureBox1.Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) { ctrlPressed = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            Figures.clear();
            pictureBox1.Invalidate();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                filename = saveFileDialog1.FileName;
                FileStream fcreate = File.Open(filename, FileMode.Create);

                StreamWriter SW = new StreamWriter(fcreate);
                SW.WriteLine(Figures.GetSize());
                foreach (CShape s in Figures)
                {
                    s.save(SW);
                }
                SW.Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Figures.clear();
                filename = openFileDialog1.FileName;
                Figures.loadShapes(filename, Factory);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = e.X.ToString() + " " + e.Y.ToString();
        }
    }

}