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
        public Form1()
        {
            InitializeComponent();
        }
        string aux;
        string valor;
        string simbol;
        int resultatActual;
        bool entrada=true;

        private void bt1_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "1";
            valor = valor + 1;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "2";
            valor = valor + 2;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "3";
            valor = valor + 3;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "4";
            valor = valor + 4;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "5";
            valor = valor + 5;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "6";
            valor = valor + 6;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "7";
            valor = valor + 7;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "8";
            valor = valor + 8;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "9";
            valor = valor + 9;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "0";
            valor = valor + 0;
        }

        private void btMes_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "+";
            if (entrada == true)
            {
                resultatActual = int.Parse(valor);
                entrada = false;
                valor = "";
            }
            if (simbol == "+")
            {
                resultatActual = resultatActual + int.Parse(valor);
                valor = "";
            }
            else if (simbol == "-")
            {
                resultatActual = resultatActual - int.Parse(valor);
                valor = "";
            }
            else if (simbol == "x")
            {
                resultatActual = resultatActual * int.Parse(valor);
                valor = "";
            }

            simbol = "+";
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "-";
            if (entrada == true)
            {
                resultatActual = int.Parse(valor);
                entrada = false;
                valor = "";
            }
            if (simbol == "+")
            {
                resultatActual = resultatActual + int.Parse(valor);
                valor = "";
            }
            else if (simbol == "-")
            {
                resultatActual = resultatActual - int.Parse(valor);
                valor = "";
            }
            else if (simbol == "x")
            {
                resultatActual = resultatActual * int.Parse(valor);
                valor = "";
            }

            simbol = "-";
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "x";
            if (entrada == true)
            {
                resultatActual = int.Parse(valor);
                entrada = false;
                valor = "";
            }
            if (simbol == "+")
            {
                resultatActual = resultatActual + int.Parse(valor);
                valor = "";
            }
            else if (simbol == "-")
            {
                resultatActual = resultatActual - int.Parse(valor);
                valor = "";
            }
            else if (simbol == "x")
            {
                resultatActual = resultatActual * int.Parse(valor);
                valor = "";
            }

            simbol = "x";
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "/";
            aux = valor;
            simbol = "/";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            if (simbol == "+")
            {
                resultatActual = resultatActual + int.Parse(valor);
                valor = "";
            }
            else if (simbol == "-")
            {
                resultatActual = resultatActual - int.Parse(valor);
                valor = "";
            }
            else if (simbol == "x")
            {
                resultatActual = resultatActual * int.Parse(valor);
                valor = "";
            }
            simbol = "";
            txPantalla.Text = txPantalla.Text + "=" + resultatActual;
        }

        private void btC_Click(object sender, EventArgs e)
        {

            txPantalla.Text = "";
            simbol = "";
            valor = "";
            resultatActual = 0;
            entrada = true;
        }
    }
}
