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
            textBoxC.Text = model.getValueC().ToString();
        }


        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            { 
                model.setValueC(Convert.ToInt32(textBoxC.Text));
            }
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueB(Convert.ToInt32(textBoxB.Text));
            }
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueA(Convert.ToInt32(textBoxA.Text));
            }
        }
    }

    public class Model
    {
        private int A, B, C;
        public System.EventHandler observers;

        public void setValueA(int valueA)
        {
            if (valueA < 0)
            {
                valueA = 0;
            }
            if (valueA > 100)
            {
                valueA = 100;
            }
            if (valueA > B)
            {
                B = valueA;
            }
            if (C == 0 || valueA > C)
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
            if (valueC < B)
            {
                B = valueC;
            }
            if (A > valueC)
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