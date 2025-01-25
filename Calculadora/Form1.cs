﻿using System;
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
            this.KeyPreview = true; // Permet que el formulari gestioni les tecles abans dels controls
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }
        double resultatActual;


        //NUMEROS
        private void bt1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "0";
        }








        //TECLAT
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //NUMPAD
            if (e.KeyChar == '1')
            {
                txPantalla.Text = txPantalla.Text + "1";
            }
            else if (e.KeyChar == '2')
            {
                txPantalla.Text = txPantalla.Text + "2";
            }
            else if (e.KeyChar == '3')
            {
                txPantalla.Text = txPantalla.Text + "3";
            }
            else if (e.KeyChar == '4')
            {
                txPantalla.Text = txPantalla.Text + "4";
            }
            else if (e.KeyChar == '5')
            {
                txPantalla.Text = txPantalla.Text + "5";
            }
            else if (e.KeyChar == '6')
            {
                txPantalla.Text = txPantalla.Text + "6";
            }
            else if (e.KeyChar == '7')
            {
                txPantalla.Text = txPantalla.Text + "7";
            }
            else if (e.KeyChar == '8')
            {
                txPantalla.Text = txPantalla.Text + "8";
            }
            else if (e.KeyChar == '9')
            {
                txPantalla.Text = txPantalla.Text + "9";
            }
            else if (e.KeyChar == '0')
            {
                txPantalla.Text = txPantalla.Text + "0";
            }



            //TECLAT SIMBOLS
            else if (e.KeyChar == '+')
            {
                txPantalla.Text = txPantalla.Text + "+";                
            }
            else if (e.KeyChar == '-')
            {
                txPantalla.Text = txPantalla.Text + "-";
            }
            else if (e.KeyChar == '*')
            {
                txPantalla.Text = txPantalla.Text + "x";
            }
            else if (e.KeyChar == '/')
            {
                txPantalla.Text = txPantalla.Text + "/";
            }
        }

        //SIMBOLS

        private void btMes_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "+";
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "-";
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "x";
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + "/";
        }






        //SIMBOL IGUAL

        private void btIgual_Click(object sender, EventArgs e)
        {

            this.ActiveControl = null;

            try
            {
                // Llegeix el contingut del TextBox
                string expressio = txPantalla.Text;

                // Substitueix el símbol "x" per "*" per a la multiplicació
                expressio = expressio.Replace("x", "*");

                // Substitueix les comes per punts per gestionar nombres decimals
                expressio = expressio.Replace(",", ".");

                // Utilitza DataTable per calcular l'expressió
                var resultat = new System.Data.DataTable().Compute(expressio, null);

                if (expressio == "")
                {
                    MessageBox.Show("Has de posar la operació");
                }
                else
                {
                    // Mostra el resultat al TextBox
                    txHistorial.Text = txHistorial.Text + expressio.Replace(".", ",") + "=" + resultat.ToString() + Environment.NewLine;
                    txPantalla.Text = resultat.ToString().Replace(".", ",");
                }
            }
            catch (Exception ex)
            {
                // En cas d'error (per exemple, una expressió invàlida), mostra un missatge
                MessageBox.Show("Error al calcular l'expressió: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // doubleerceptar la tecla Enter per evitar l'execució automàtica del botó amb focus
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Evita que el botó amb focus rebi l'esdeveniment
                e.SuppressKeyPress = true; // Evita el so del sistema

                // Opcional: pots afegir aquí el comportament personalitzat per a Enter
                // Per exemple, executar el codi del botó igual
                btIgual_Click(null, null);
            }
        }





        //NATEJAR PANTALLA

        private void btC_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = "";
            simbol = "";
            valor = "";
            resultatActual = 0;
        }

        private void btComa_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txPantalla.Text = txPantalla.Text + ",";
        }

        private void btCanviSigne_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (simbol == "+")
            {
                resultatActual = resultatActual + double.Parse(valor);
                valor = "";
            }
            else if (simbol == "-")
            {
                resultatActual = resultatActual - double.Parse(valor);
                valor = "";
            }
            else if (simbol == "x")
            {
                resultatActual = resultatActual * double.Parse(valor);
                valor = "";
            }
            else if (simbol == "/")
            {
                resultatActual = resultatActual / double.Parse(valor);
                valor = "";
            }
            simbol = "";
            resultatActual = (-resultatActual);
            txPantalla.Text = txPantalla.Text + "=" + resultatActual;
        }

        private void bt100_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (simbol == "+")
            {
                resultatActual = resultatActual + double.Parse(valor);
                valor = "";
            }
            else if (simbol == "-")
            {
                resultatActual = resultatActual - double.Parse(valor);
                valor = "";
            }
            else if (simbol == "x")
            {
                resultatActual = resultatActual * double.Parse(valor);
                valor = "";
            }
            else if (simbol == "/")
            {
                resultatActual = resultatActual / double.Parse(valor);
                valor = "";
            }
            simbol = "";
            resultatActual = resultatActual/100;
            txPantalla.Text = txPantalla.Text + "=" + resultatActual;
        }
    }
}
