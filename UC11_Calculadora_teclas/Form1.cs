using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_Calculadora_teclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        double n1;
        double n2;
        double resultado;
        string operador;
        bool operacao = true;

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxRESULTADO.Text == "0")
            {
                return;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "0";
            }                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "1";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "2";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "3";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "4";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "5";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "6";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "7";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "8";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "9";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += "9";
            }
        }

        private void buttonIGUAL_Click(object sender, EventArgs e)
        {            
            
            n2 = Convert.ToDouble(textBoxRESULTADO.Text);
            operacao = true;

            switch(operador)
            {
                case "+":
                    {
                        resultado = n1 + n2;
                        textBoxRESULTADO.Text = resultado.ToString();
                        
                        break;
                    }
                case "-":
                    {
                        resultado = n1 - n2;
                        textBoxRESULTADO.Text = resultado.ToString();

                        break;
                    }
                case "*":
                    {
                        resultado = n1 * n2;
                        textBoxRESULTADO.Text = resultado.ToString();

                        break;
                    }
                case "/":
                    {
                        resultado = n1 / n2;
                        textBoxRESULTADO.Text = resultado.ToString();

                        break;
                    }                
            }            
        }

        private void buttonSOMA_Click(object sender, EventArgs e)
        {
            operador = "+";
            operacao = true;
            n1 = Convert.ToDouble(textBoxRESULTADO.Text);
            textBoxRESULTADO.Clear();
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Clear();
        }

        private void buttonSUBTRAI_Click(object sender, EventArgs e)
        {
            operador = "-";
            operacao = true;
            n1 = Convert.ToDouble(textBoxRESULTADO.Text);
            textBoxRESULTADO.Clear();
        }

        private void buttonMULTIPLICA_Click(object sender, EventArgs e)
        {
            operador = "*";
            operacao = true;
            n1 = Convert.ToDouble(textBoxRESULTADO.Text);
            textBoxRESULTADO.Clear();
        }

        private void buttonDIVIDE_Click(object sender, EventArgs e)
        {
            operador = "/";
            operacao = true;
            n1 = Convert.ToDouble(textBoxRESULTADO.Text);
            textBoxRESULTADO.Clear();
        }

        private void buttonVIRGULA_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = "";
                textBoxRESULTADO.Text = textBoxRESULTADO.Text = ",";
                operacao = false;
            }
            else
            {
                textBoxRESULTADO.Text = textBoxRESULTADO.Text += ",";
            }
        }

        private void textBoxDISPLAYSUP_TextChanged(object sender, EventArgs e)
        {
            textBoxDISPLAYSUP.Text = n1.ToString();
        }

        private void textBoxRESULTADO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
