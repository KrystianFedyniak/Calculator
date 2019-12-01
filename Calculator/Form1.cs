using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool sign;
        bool OnTop = false;


      

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Выйти из приложения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Автор приложения Fedyniak Krystian", "Пасхалочка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            sign = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            sign = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            sign = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            sign = true;
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text); //сложение
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text); //вычитание
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text); //умножение
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text); //деление
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        public void OnTopCheck() 
        {
            if (OnTop==true)
            {
                TopMost = true;
                button21.BackColor = Color.Purple;
            }
            else
            {
                TopMost = false;
                button21.BackColor = Color.DimGray;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) //удаление последней цифры в TextBox1
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                if (sign == true)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    sign = false;
                }
                else if (sign == false)
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    sign = true;
                }

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) // перетаскивание формы за заголовок
        {
            panel1.Capture = false;
            //  base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }

        private void button21_Click(object sender, EventArgs e) // закрепление поверх всех окон
        {
            if(OnTop==false)
            {
                OnTop = true;
            }
            else
            {
                OnTop = false;
            }
            OnTopCheck();
        }

        private void button21_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button21, "Закрепить поверх всех окон");
        }

       

        private void button20_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip x = new ToolTip();
            x.SetToolTip(button20, "Выход");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ',';
        }
    }
}
