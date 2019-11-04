using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacao;
        double valor;
        public Form1()
        {
            InitializeComponent();
            txt.Enabled = false;
        }

        private bool guardarValor()
        {
            try
            {
                valor = double.Parse(txt.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Número inválido.");
                txt.Text = "";
                return false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {

                txt.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "0";
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {

                if (txt.Text.Length > 0)
                {
                    try
                    {
                        txt.Text = txt.Text.Remove(txt.Text.Length - 1, 1);
                    }
                    catch
                    {
                       
                    }
                    
                }
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text = "";
            }

        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                try
                {
                    if (guardarValor())
                    {
                        operacao = "+";
                        txt.Text = "";
                    }
                }
                catch 
                {
                    MessageBox.Show("Primeiro selecione um número");
                }
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {

            if (txt.Enabled)
            {
                double valor2;
                try
                {
                    valor2 = double.Parse(txt.Text);
                }
                catch 
                {
                    txt.Text = "";
                    MessageBox.Show("Número invalido");
                    return;
                }
                try
                {
                    if (operacao == "+")
                    {
                        double resultado = valor + valor2;
                        txt.Text = resultado.ToString();

                    }
                    if (operacao == "-")
                    {
                        double resultado = valor - valor2;
                        txt.Text = resultado.ToString();

                    }
                    if (operacao == "*")
                    {
                        double resultado = valor * valor2;
                        txt.Text = resultado.ToString();

                    }
                    if (operacao == "/")
                    {
                        if (valor2 != 0)
                        {
                            double resultado = valor / valor2;
                            txt.Text = resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Divisor não pode ser 0");
                        }
                    }
                    if (operacao == "x²")
                    {
                        double resultado = Math.Pow(valor, valor2);
                        txt.Text = resultado.ToString();
                    }
                    if (operacao == "sqrt")
                    {
                        double resultado = Math.Sqrt(valor2);
                        txt.Text = resultado.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Primeiro selecione um número");
                }
            } 
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                try
                {
                    if (guardarValor())
                    {
                        operacao = "-";
                        txt.Text = "";
                    } 
                }
                catch
                {
                    MessageBox.Show("Primeiro selecione um número");
                }
            }

        }

        private void btnporcento_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                try
                {
                    if (guardarValor())
                    {
                        operacao = "%";
                        double resultado = valor / 100;
                        txt.Text = resultado.ToString();
                    }
                }
                catch 
                {
                    MessageBox.Show("Primeiro selecione um número");
                }
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                try
                {
                    if (guardarValor())
                    { 
                        operacao = "/";
                        txt.Text = "";
                    }
                }
                catch 
                {
                    MessageBox.Show("Primeiro selecione um número");
                }
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                try
                {
                    if (guardarValor())
                    {
                        operacao = "*";
                        txt.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Primeiro selecione um número");
                }
            }
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                try
                {
                    if (guardarValor())
                    {
                        operacao = "x²";
                        txt.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Primeiro selecione um número");
                }
            }
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                try
                {
                    operacao = "sqrt";
                }
                catch 
                {
                    MessageBox.Show("Primeiro selecione um número"); 
                }
               
            }

        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += "3.14159265359";
            }
        }

        private void btnpponto_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Text += ",";
            }
        }

        private void btnpower_Click(object sender, EventArgs e)
        {
            if (txt.Enabled)
            {
                txt.Enabled = false;
            }
            else
            {
                txt.Enabled = true;
            }
            txt.Text = "";

        }


    }
}
