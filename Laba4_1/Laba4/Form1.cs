using System.Drawing;//Подключаем для рисования
using System.Collections.Generic;//Подключаем для использования списка
using System.DirectoryServices;
using System.Diagnostics.Eventing.Reader;

namespace Laba4
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Black);
        Brush SelectBrush = new SolidBrush(Color.Yellow);
        Brush DefaultBrush = new SolidBrush(Color.Green);
        bool interSection = false;
        bool ctrlWork = false;
        bool ctrlPressed = false;
        List<CCircle> Circles = new List<CCircle>();
        public Form1()
        {
            InitializeComponent();
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
                            c.CircleSelect();
                            tempList.Add(c);
                            flag = true;
                            break;
                        }
                    }
                    else if (interSection)
                    {
                        c.checkHit(e.X, e.Y);
                        c.CircleSelect();
                        if (c.isSelect())
                        {
                            tempList.Add(c);
                            flag = true;
                        }
                    }
                }
                else
                {
                    c.CircleDeSelect();
                    if (c.checkHit(e.X, e.Y)) c.CircleSelect();
                    if (c.isSelect())
                    {
                        tempList.Add(c);
                        flag = true;
                    }
                }
            }
            
            if (!flag)
            {
                CCircle newCircle = new CCircle(e.X, e.Y);

                Circles.Add(newCircle);
                testContainer.Items.Add(newCircle);
            }
            else
            {
                 if (!interSection)
                {
                    if (!ctrlWork || !ctrlPressed)
                    {
                        foreach (CCircle checkedCircle in tempList)
                        {
                            checkedCircle.CircleDeSelect();

                        }
                        tempList[tempList.Count - 1].CircleSelect();

                    }
                }
            }
            panel1.Invalidate();
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
                    panel1.Invalidate();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            testContainer.Items.Add(e.ClipRectangle.ToString());
            foreach (CCircle c in Circles)
            {
                if (c.isSelect())
                {
                    c.Draw(e.Graphics, pen, SelectBrush);
                }
                else
                {
                    c.Draw(e.Graphics, pen, DefaultBrush);
                }
            }
        }
    }
    class CCircle
    {
        private int x, y;
        private int radius = 50;
        private bool Select = true;
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
                return true;
            }
            return false;
        }
        public void Draw(Graphics _g, Pen _pen, Brush _brush)
        {
            _g.DrawEllipse(_pen, x - 25, y - 25, radius, radius);
            _g.FillEllipse(_brush, x - 25, y - 25, radius, radius);
        }


    }
}