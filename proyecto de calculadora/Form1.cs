using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_de_calculadora
{
    public partial class Form1 : Form
    {
        private double Num1, Num2, Result;
        private int op;
       
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            Size = new Size(340, 440);

        }

        #region modos
        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false; 
            Size = new Size(340, 440);
        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel7.Visible = false;
            Size = new Size(589, 440);
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = true;
            panel7.Visible = false;
            Size = new Size(589, 440);
        }

        private void estandarConConversiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel7.Visible = true;
            Size = new Size(740, 440);
        }
        #endregion

        #region radiobotones
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button113.Enabled = false; 
            button111.Enabled = false; 
            button109.Enabled = false;
            button110.Enabled = false;

            button135.Enabled = true;
            button106.Enabled = true;
            button94.Enabled = true;
            button90.Enabled = true;
            button86.Enabled = true;
            button82.Enabled = true;

            button128.Enabled = true;
            button127.Enabled = true;
            button123.Enabled = true;
            button122.Enabled = true;
            button119.Enabled = true;
            button118.Enabled = true;
            button124.Enabled = true;
            button120.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button113.Enabled = false;
            button111.Enabled = false;
            button109.Enabled = false;
            button110.Enabled = false;

            button135.Enabled = false;
            button106.Enabled = false;
            button94.Enabled = false;
            button90.Enabled = false;
            button86.Enabled = false;
            button82.Enabled = false;
            
            button113.Enabled = false;
            button111.Enabled = false;
            button109.Enabled = false;
            button110.Enabled = false;

            button128.Enabled = true;
            button127.Enabled = true;
            button123.Enabled = true;
            button122.Enabled = true;
            button119.Enabled = true;
            button118.Enabled = true;
            button124.Enabled = true;
            button120.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button113.Enabled = false;
            button111.Enabled = false;
            button109.Enabled = false;
            button110.Enabled = false;

            button135.Enabled = false;
            button106.Enabled = false;
            button94.Enabled = false;
            button90.Enabled = false;
            button86.Enabled = false;
            button82.Enabled = false;

            button124.Enabled = false;
            button120.Enabled = false;
            button135.Enabled = false;
            button106.Enabled = false;
            button94.Enabled = false;
            button90.Enabled = false;
            button86.Enabled = false;
            button82.Enabled = false;

            button128.Enabled = true;
            button127.Enabled = true;
            button123.Enabled = true;
            button122.Enabled = true;
            button119.Enabled = true;
            button118.Enabled = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button113.Enabled = false;
            button111.Enabled = false;
            button109.Enabled = false;
            button110.Enabled = false;

            button135.Enabled = false;
            button106.Enabled = false;
            button94.Enabled = false;
            button90.Enabled = false;
            button86.Enabled = false;
            button82.Enabled = false;

            button128.Enabled = false;
            button127.Enabled = false;
            button123.Enabled = false;
            button122.Enabled = false;
            button119.Enabled = false;
            button118.Enabled = false;
            
            button124.Enabled = false;
            button120.Enabled = false;
        }
        #endregion

        #region keypress
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        #endregion

        #region funcional
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';
        }


        private void button15_Click(object sender, EventArgs e)
        {
            //boton C 
            textBox1.Text = "";
        }


        private void button24_Click(object sender, EventArgs e)
        {
            //boton mas 

            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 1;
        }

        

        private void button23_Click(object sender, EventArgs e)
        {
            //boton menos

            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 2;
        }

        

        private void button22_Click(object sender, EventArgs e)
        {
            //boton multiplicar
            
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 3;
        }


        private void button21_Click(object sender, EventArgs e)
        {
            //boton dividir
            
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 4;
        }


        private void button28_Click(object sender, EventArgs e)
        {
            //boton igual
            Num2 = Convert.ToDouble(textBox1.Text);
            switch (op)
            {
                case 1:
                    Result = Num1 + Num2;
                    break;
                case 2:
                    Result = Num1 - Num2;
                    break;
                case 3:
                    Result = Num1 * Num2;
                    break;
                case 4:
                    Result = Num1 / Num2;
                    break;
            }

            textBox1.Text = Result.ToString();

        }

        private void button26_Click(object sender, EventArgs e)
        {           
            //boton porcentaje

            Num1 = Convert.ToDouble(textBox1.Text);
            Result = Num1 / 100;
            textBox1.Text = Result.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //boton 1/x
            
            Num1 = Convert.ToDouble(textBox1.Text);
            Result = 1 / Num1;
            textBox1.Text = Result.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //boton mas menos 
            
            Num1 = Convert.ToDouble(textBox1.Text);
            Result = -Num1;
            textBox1.Text = Result.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // boton CE
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // boton suprimir

            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // boton raiz
            Num1 = Convert.ToDouble(textBox1.Text);
            Result = Math.Sqrt(Num1);
            textBox1.Text = Result.ToString();
        }


        #endregion

    }
}
