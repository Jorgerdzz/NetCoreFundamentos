using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;


            if (isbn.Length == 10)
            {
                int mult = 0;
                int suma = 0;
                for(int i=0; i<=isbn.Length-1; i++)
                {
                    char digito = isbn[i];
                    int numero = int.Parse(digito.ToString());
                    mult = numero * (i+1);
                    suma += mult;
                }
                if(suma % 11 == 0)
                {
                    this.lblResultado.Text = "ISBN correcto";
                    this.lblResultado.ForeColor = Color.Green;
                }
                else
                {
                    this.lblResultado.Text = "ISBN incorrecto";
                    this.lblResultado.ForeColor = Color.Red;
                }
            }
            else
            {
                this.lblResultado.Text = "ISBN incorrecto";
                this.lblResultado.ForeColor = Color.Red;
            }

        }
    }
}
