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
            textBoxС.Text = model.getValueC().ToString();
            numericUpDownA.Value = model.getValueA();
            numericUpDownB.Value = model.getValueB();
            numericUpDownC.Value = model.getValueC();
            trackBarA.Value = model.getValueA();
            trackBarB.Value = model.getValueB();
            trackBarC.Value = model.getValueC();
        }
        //Функция создания файлов с данными из модели
        void CreateFile(string data, string path)
        {
            if (data.Count() > 1)
            {
                File.WriteAllText(path, data);
            }
        }
        //Функция проверки строки на корректность. Если только цифр -- true, если есть что-то кроме цифр -- false

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            //Если пользователь нажал Enter  
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueA(textBoxA.Text);
            }

        }
        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueB(textBoxB.Text);
            }
        }
        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueC(textBoxС.Text);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CreateFile(model.getValueA().ToString(), "TextBoxA_Data.txt");
            CreateFile(model.getValueB().ToString(), "TextBoxB_Data.txt");
            CreateFile(model.getValueC().ToString(), "TextBoxC_Data.txt");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("TextBoxA_Data.txt"))
            {
                string valueA = File.ReadAllText("TextBoxA_Data.txt");
                model.setValueA(valueA);

            }
            if (File.Exists("TextBoxC_Data.txt"))
            {
                string valueC = File.ReadAllText("TextBoxC_Data.txt");
                model.setValueC(valueC);

            }
            if (File.Exists("TextBoxB_Data.txt"))
            {
                string valueB = File.ReadAllText("TextBoxB_Data.txt");
                model.setValueB(valueB);

            }
            model.observers.Invoke(model, null);
        }

        private void textBoxA_Leave_1(object sender, EventArgs e)
        {
            model.setValueA(textBoxA.Text);
        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            model.setValueB(textBoxB.Text);
        }

        private void textBoxС_Leave(object sender, EventArgs e)
        {
            model.setValueC(textBoxС.Text);
        }

        private void numericUpDownA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void numericUpDownB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void numericUpDownC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(trackBarA.Value));
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(trackBarB.Value));
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(trackBarC.Value));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int a;
            a = Int32.Parse("1234");
            label1.Text = a.ToString();
        }
    }
    class Model
    {
        private int A, B, C;
        public System.EventHandler observers;

        private bool StringCorrect(string value)
        {
            //Проверка нет ли среди введенных данных чего-либо кроме цифр
            //Прохожусь по каждой букве в textBox и если там есть что-то крооме цифры, делаю флаг тру.
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    //если введена цифра, то все норм
                }
                else
                {
                    //если нашли  не цифру, то меняем флаг и заканчиваем цикл
                    return false;
                    break;
                }
            }
            return true;
        }
        public void setValueA(string valueA_str)
        {
            if (StringCorrect(valueA_str))
            {
                int valueA;
                valueA = Int32.Parse(valueA_str);
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
            else observers.Invoke(this, null);
        }
        public void setValueA(int valueA)
        {
            if (StringCorrect(valueA.ToString()))
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
            else return;
        }
        public int getValueA()
        {
            return this.A;
        }
        public void setValueB(int valueB)
        {
            if (StringCorrect(valueB.ToString()))
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
            else return;
        }
        public void setValueB(string valueB_str)
        {
            if (StringCorrect(valueB_str))
            {
                int valueB = Int32.Parse(valueB_str);
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
            else observers.Invoke(this, null);
        }
        public int getValueB()
        {
            return this.B;
        }
        public void setValueC(string valueC_str)
        {
            if (StringCorrect(valueC_str))
            {
                int valueC = Int32.Parse(valueC_str);
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
            else observers.Invoke(this, null);
        }
        public void setValueC(int valueC)
        {
            if (StringCorrect(valueC.ToString()))
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
            else return;
        }
        public int getValueC()
        {
            return this.C;
        }
    }
}
