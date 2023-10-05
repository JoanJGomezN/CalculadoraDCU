using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDCU
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(tbDisplay.Text);
            switch (operacion)
            {
                case 1:
             resultado = num1 + num2;
             break;
                    case 2:
                    resultado = num1 - num2;
                    break;
                  case 3: 
                    resultado = num1 / num2;
                    break;
                    case 4:
                    resultado = num1 * num2;
                    break;

            }
            tbDisplay.Text=resultado.ToString();
            
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + ".";
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operacion = 3;
            num1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnlimpiarC_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            operacion = 1;
            num1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operacion = 2;
            num1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operacion = 4;
            num1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }
    }
}
