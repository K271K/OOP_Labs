using System.IO;

namespace Laba4_2
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
            InitializeComponent();
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBoxA.Text = model.getValueA().ToString();
            textBoxB.Text = model.getValueB().ToString();
            textBox—.Text = model.getValueC().ToString();
            numericUpDownA.Value = model.getValueA();
            numericUpDownB.Value = model.getValueB();
            numericUpDownC.Value = model.getValueC();
            trackBarA.Value = model.getValueA();
            trackBarB.Value = model.getValueB();
            trackBarC.Value = model.getValueC();
        }
        private void textBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int valueCheck;
                if (sender == textBoxA)
                {
                    Int32.TryParse((sender as TextBox).Text, out valueCheck);
                    model.setValueA(valueCheck);
                }
                if (sender == textBoxB)
                {
                    Int32.TryParse((sender as TextBox).Text, out valueCheck);
                    model.setValueB(valueCheck);
                }
                if (sender == textBox—)
                {
                    Int32.TryParse((sender as TextBox).Text, out valueCheck);
                    model.setValueC(valueCheck);
                }
            }
        }
        private void textBoxes_Leave(object sender, EventArgs e)
        {
            int valueCheck;
            if (sender == textBoxA)
            {
                Int32.TryParse((sender as TextBox).Text, out valueCheck);
                model.setValueA(valueCheck);
            }
            if (sender == textBoxB)
            {
                Int32.TryParse((sender as TextBox).Text, out valueCheck);
                model.setValueB(valueCheck);
            }
            if (sender == textBox—)
            {
                Int32.TryParse((sender as TextBox).Text, out valueCheck);
                model.setValueC(valueCheck);
            }
        }

        private void NumericUpDowns_ValueChanged(object sender, EventArgs e)
        {
            if (sender == numericUpDownA)
            {
                model.setValueA(Decimal.ToInt32((sender as NumericUpDown).Value));
            }
            if (sender == numericUpDownB)
            {
                model.setValueB(Decimal.ToInt32((sender as NumericUpDown).Value));
            }
            if (sender == numericUpDownC)
            {
                model.setValueC(Decimal.ToInt32((sender as NumericUpDown).Value));
            }
        }

        private void trackBars_Scroll(object sender, EventArgs e)
        {
            if (sender == trackBarA)
            {
                model.setValueA(Decimal.ToInt32((sender as TrackBar).Value));
            }
            if (sender == trackBarB)
            {
                model.setValueB(Decimal.ToInt32((sender as TrackBar).Value));
            }
            if (sender == trackBarC)
            {
                model.setValueC(Decimal.ToInt32((sender as TrackBar).Value));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateFromModel(model, EventArgs.Empty);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            model.Model_Destruct();
        }
    }
    class Model
    {
        private int A, B, C;
        public System.EventHandler observers;

        public Model()
        {
            observers?.Invoke(this, null);

            string line;
            int CheckA, CheckB, CheckC;
            StreamReader sr = new StreamReader("ModelData.txt");

            line = sr.ReadLine();
            Int32.TryParse(line, out CheckA);
            if (CheckA < 0 || CheckA > 100)
                this.A = 0;
            else
                this.A = CheckA;



            line = sr.ReadLine();
            Int32.TryParse(line, out CheckB);
            if (CheckB < 0 || CheckB > 100)
                this.B = 0;
            else
                this.B = CheckB;

            line = sr.ReadLine();
            Int32.TryParse(line, out CheckC);
            if (CheckC < 0 || CheckC > 100)
                this.C = 0;
            else
                this.C = CheckC;

            sr.Close();

        }
        public void Model_Destruct()
        {
            StreamWriter sw = new StreamWriter("ModelData.txt");
            sw.WriteLine(A);
            sw.WriteLine(B);
            sw.WriteLine(C);
            sw.Close();
        }
        public void setValueA(int valueA)
        {
            if (valueA > 100)
            {
                valueA = A;
            }
            if (valueA < 0)
            {
                valueA = A;
            }
            if (valueA > B)
            {
                B = valueA;
            }
            if (valueA > C)
            {
                C = valueA;
            }
            this.A = valueA;
            observers.Invoke(this, null);
        }
        public int getValueA()
        {
            return this.A;
        }
        public void setValueB(int valueB)
        {
            if (valueB > 100)
            {
                valueB = B;
            }
            if (valueB < 0)
            {
                valueB = B;
            }
            if (valueB < A)
            {
                valueB = A;
            }
            if (valueB > C)
            {
                valueB = C;
            }
            this.B = valueB;
            observers.Invoke(this, null);
        }
        public int getValueB()
        {
            return this.B;
        }
        public void setValueC(int valueC)
        {
            if (valueC > 100)
            {
                valueC = C;
            }
            if (valueC < 0)
            {
                valueC = C;
            }
            if (valueC < B)
            {
                B = valueC;
            }
            if (valueC < A)
            {
                A = valueC;
            }
            this.C = valueC;
            observers.Invoke(this, null);
        }
        public int getValueC()
        {
            return this.C;
        }
    }
}
