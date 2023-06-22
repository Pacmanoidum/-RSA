using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Алгоритм_RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (int.Parse(input_p.Text) * int.Parse(input_q.Text) <= 6)
                MessageBox.Show("Введены неверные числа");
            else if (int.Parse(input_p.Text) * int.Parse(input_q.Text) == 12)
                MessageBox.Show("Введены неверные числа");
            else
            {
                int φ1 = (int.Parse(input_p.Text) - 1) * (int.Parse(input_q.Text) - 1);
                int n1 = int.Parse(input_p.Text) * int.Parse(input_q.Text);
                n.Text += n1;
                φ.Text += φ1;
                textBox6.Text += n1;
                textBox8.Text += n1;
                for (int i = 2; i < φ1; i++)
                {
                    if (φ1 % i == 0) continue;
                    for (int j = 2; j < i / 2; j++)
                    {
                        if (i % j == 0)
                            break;
                    }
                    el.Text += i;
                    textBox5.Text += i;
                    break;
                }
                int d1 = 1;
                while (true)
                {
                    if ((d1 * int.Parse(el.Text)) % φ1 == 1)
                        if (d1 != int.Parse(el.Text))
                        {
                            d.Text += d1;
                            textBox7.Text += d1;
                            break;
                        }
                    d1++;
                }
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
                input_p.Text = "";
                input_q.Text = "";
                n.Text = "";
                φ.Text = "";
                el.Text = "";
                d.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }

            private void button2_Click(object sender, EventArgs e)
            {
            if (textBox5.Text == "") MessageBox.Show("Сначала сформируйте ключи");
            else textBox10.Text += Math.Pow((int.Parse(textBox9.Text)), int.Parse(el.Text)) % int.Parse(n.Text);
            }

            private void button3_Click(object sender, EventArgs e)
            {
            if (textBox5.Text == "") MessageBox.Show("Сначала сформируйте ключи");
            else textBox9.Text += Math.Pow((int.Parse(textBox10.Text)), int.Parse(d.Text)) % int.Parse(n.Text);
            }
        } 
}
