using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

            string expressio = txPantalla.Text;
            string signe;
            int countExp = 0;
            int countUltVal = 0;

            // Comprova si el TextBox està buit
            if (expressio == "")
            {
                MessageBox.Show("Has de posar la operació");
            }
            else
            {
                try
                {
                    // Substitueix el símbol "x" per "*" per a la multiplicació
                    expressio = expressio.Replace("x", "*");

                    // Substitueix les comes per punts per gestionar nombres decimals
                    expressio = expressio.Replace(",", ".");

                    var resultat = new System.Data.DataTable().Compute(expressio, null);

                    // Divideix el text en parts separades per operadors matemàtics
                    char[ ] operadors = { '+', '-', '*', '/', 'x' };
                    string[ ] parts = expressio.Split(operadors);

                    // Obté l'última part (últim número)
                    string ultimValor = parts[ parts.Length - 1 ];

                    // Comprova si l'últim valor és vàlid
                    if (string.IsNullOrWhiteSpace(ultimValor))
                    {
                        MessageBox.Show("No s'ha trobat cap número vàlid per canviar el signe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Identifica la posició de l'últim número al text original
                    int posicioUltimValor = expressio.LastIndexOf(ultimValor);

                    for (int i = 0; i < expressio.Length; i++)
                    {
                        // Comprova si el caràcter actual és una lletra
                        countExp++;
                    }

                    for (int i = 0; i < ultimValor.Length; i++)
                    {
                        // Comprova si el caràcter actual és una lletra
                        countUltVal++;
                    }

                    if (countExp == countUltVal)
                    {
                        signe = "-";

                        // Substitueix l'últim valor al TextBox
                        expressio = signe + ultimValor.Replace(".", ",");
                    }
                    else
                    {
                        signe = expressio[ posicioUltimValor - 1 ].ToString(); // Accedeix al caràcter de la posició 3 (quart caràcter)

                        // Canvia el signe del número
                        if (signe == "-")
                        {
                            // Si és negatiu, elimina el signe menys
                            signe = "+";
                        }
                        else if (signe == "+")
                        {
                            // Si és negatiu, elimina el signe menys
                            signe = "-";
                        }


                        // Substitueix l'últim valor al TextBox
                        expressio = expressio.Substring(0, posicioUltimValor - 1).Replace(".", ",") + signe + ultimValor.Replace(".", ",");
                    }
                    txPantalla.Text = expressio;
                }
                catch (Exception ex)
                {
                    // En cas d'error, mostra un missatge informatiu
                    MessageBox.Show("Error al canviar el signe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bt100_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            string expressio = txPantalla.Text;
            string signe;
            int countExp = 0;
            int countUltVal = 0;
            int cent = 100;
            double numDividit;

            // Comprova si el TextBox està buit
            if (expressio == "")
            {
                MessageBox.Show("Has de posar la operació");
            }
            else
            {
                try
                {
                    // Substitueix el símbol "x" per "*" per a la multiplicació
                    expressio = expressio.Replace("x", "*");

                    // Substitueix les comes per punts per gestionar nombres decimals
                    expressio = expressio.Replace(",", ".");

                    var resultat = new System.Data.DataTable().Compute(expressio, null);

                    // Divideix el text en parts separades per operadors matemàtics
                    char[ ] operadors = { '+', '-', '*', '/', 'x' };
                    string[ ] parts = expressio.Split(operadors);

                    // Obté l'última part (últim número)
                    string ultimValor = parts[ parts.Length - 1 ];


                    // Substitueix les comes per punts per gestionar nombres decimals
                    ultimValor = ultimValor.Replace(".", ",");

                    // Divideix l'últim número per 100
                    numDividit = (double.Parse(ultimValor) / cent);

                    // Identifica la posició de l'últim número al text original
                    int posicioUltimValor = expressio.LastIndexOf(ultimValor);

                    // Substitueix l'últim número al TextBox
                    expressio = expressio.Substring(0, posicioUltimValor).Replace(".", ",") + numDividit.ToString().Replace(".", ",");
                    txPantalla.Text = expressio;
                }
                catch (Exception ex)
                {
                    // En cas d'error, mostra un missatge informatiu
                    MessageBox.Show("Error al dividir l'últim número per 100: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
