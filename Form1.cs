using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2022
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        double numero1;
        double numero2;
        string operador;

        Clases.ClassDivision obj = new Clases.ClassDivision();
        Clases.ClassMultiplic obj1 = new Clases.ClassMultiplic();
        Clases.ClassResta obj2 = new Clases.ClassResta();
        Clases.ClassSuma obj3 = new Clases.ClassSuma();

        private void buttonCero_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }
        private void buttonUno_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }
        private void buttonDos_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }
        private void buttonTres_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }
        private void buttonCuatro_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }
        private void buttonCinco_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }
        private void buttonSeis_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }
        private void buttonSiete_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }
        private void buttonOcho_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }
        private void buttonNueve_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (! textBox.Text.Contains ("."))
            {
                textBox.Text = textBox.Text + ".";
            }
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = " ";
        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 1)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
            else
            {
                textBox.Text = "0";
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            numero1 = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }
        private void buttonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            numero1 = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }
        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            numero1 = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }
        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            numero1 = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBox.Text);

            if (operador == "+")
            {
                textBox.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(textBox.Text);
            }
            else if (operador == "-")
            {
                textBox.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(textBox.Text);
            }
            else if (operador == "*")
            {
                textBox.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(textBox.Text);
            }
            else if (operador == "/")
            {
                textBox.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(textBox.Text);
            }
        }
    }
}
