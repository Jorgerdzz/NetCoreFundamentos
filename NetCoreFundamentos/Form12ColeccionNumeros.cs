using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                int numero = new Random().Next(1, 101);
                this.lstNumeros.Items.Add(numero);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {


            int sumaTotal = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            foreach(int numero in this.lstNumeros.Items)
            {
                sumaTotal += numero;

                if(numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }

            }
            this.txtSumaTotal.Text = sumaTotal.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
