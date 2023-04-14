using System.Drawing;//Подключаем для рисования
using System.Collections.Generic;//Подключаем для использования списка
using System.DirectoryServices;
using System.Diagnostics.Eventing.Reader;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Graphics g;
        bool interSection = false;
        bool ctrlWork = false;
        bool ctrlPressed = false;
        List<CCircle> Circles = new List<CCircle>();
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
        class CCircle
        {
            public int x, y;
            public int radius = 50;
            public bool Select = true;
            public CCircle(int _x, int _y)
            {
                this.x = _x;
                this.y = _y;
            }
            public bool isSelect()
            {
                return Select;
            }
            public void CircleSelect()
            {
                Select = true;
            }
            public void CircleDeSelect()
            {
                Select = false;
            }
            public bool checkHit(int ClickX, int ClickY)
            {
                if (Math.Pow((ClickX - x), 2) + Math.Pow((ClickY - y), 2) < Math.Pow((radius / 2), 2))
                {
                    this.CircleSelect();
                    return true;
                }
                return false;
            }
            public void Draw(Graphics _g)
            {
                if (!isSelect())
                {
                    _g.DrawEllipse(Pens.Black, x - 25, y - 25, radius, radius);
                    _g.FillEllipse(Brushes.Green, x - 25, y - 25, radius, radius);
                }
                else
                {
                    _g.DrawEllipse(Pens.Blue, x - 25, y - 25, radius, radius);
                    _g.FillEllipse(Brushes.Yellow, x - 25, y - 25, radius, radius);
                }
            }
            public void Easier(Graphics _g)
            {
                _g.DrawEllipse(Pens.White, x - 25, y - 25, radius, radius);
                _g.FillEllipse(Brushes.White, x - 25, y - 25, radius, radius);
            }


        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            List<CCircle> tempList = new List<CCircle>();
            bool flag = false;

            foreach (CCircle c in Circles)
            {
                if (ctrlPressed && ctrlWork)
                {

                    if (!interSection)
                    {
                        if (c.checkHit(e.X, e.Y))
                        {
                            tempList.Add(c);
                            flag = true;
                            break;
                        }
                        else
                        {
                            c.Draw(g);
                        }
                    }

                    else if (interSection)
                    {
                        c.checkHit(e.X, e.Y);
                        if (c.isSelect())
                        {
                            tempList.Add(c);
                            flag = true;
                        }
                        else
                        {
                            c.Draw(g);
                        }
                    }
                }
                else
                {
                    c.CircleDeSelect();
                    c.checkHit(e.X, e.Y);
                    if (c.isSelect())
                    {
                        tempList.Add(c);
                        flag = true;
                    }
                    else
                    {
                        c.Draw(g);
                    }
                }
            }
            if (!flag)
            {
                CCircle newCircle = new CCircle(e.X, e.Y);
                Circles.Add(newCircle);
                testContainer.Items.Add(newCircle);
                newCircle.Draw(g);
            }
            else
            {
                if (interSection)
                {
                    foreach (CCircle checkedCircle in tempList)
                    {
                        checkedCircle.Draw(g);
                    }
                }
                else if (!interSection)
                {
                    if (!ctrlWork || !ctrlPressed)
                    {
                        foreach (CCircle checkedCircle in tempList)
                        {
                            checkedCircle.CircleDeSelect();
                            checkedCircle.Draw(g);
                        }
                        tempList[tempList.Count - 1].CircleSelect();
                        tempList[tempList.Count - 1].Draw(g);
                    }
                    else if (ctrlWork && ctrlPressed)
                    {
                        foreach (CCircle checkedCircle in tempList)
                        {
                            checkedCircle.Draw(g);
                        }


                    }
                }
            }
            tempList.Clear();
        }
        private void InterSection_CheckedChanged(object sender, EventArgs e)
        {
            interSection = !interSection;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyData.ToString();
            if (e.KeyCode == Keys.ControlKey)
            {
                ctrlPressed = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                List<CCircle> deleteCircles = new List<CCircle>();

                foreach (CCircle c in Circles)
                {
                    if (c.isSelect())
                    {
                        c.Easier(g);
                        deleteCircles.Add(c);
                    }
                }
                foreach (CCircle c in deleteCircles)
                {
                    Circles.Remove(c);
                }
                if (Circles.Count > 0)
                {
                    Circles[Circles.Count - 1].CircleSelect();
                    Circles[Circles.Count - 1].Draw(g);
                }
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            ctrlPressed = false;
            label1.Text = e.KeyData.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ctrlWork = !ctrlWork;
        }


    }
}