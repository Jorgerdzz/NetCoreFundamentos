using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        public int SumarNumeros()
        {
            int suma = 0;
            int numero1 = int.Parse(this.txtNumero1.Text);
            int numero2 = int.Parse(this.txtNumero2.Text);
            int numero3 = int.Parse(this.txtNumero3.Text);
            suma = numero1 + numero2 + numero3;
            return suma;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text =  "Resultado: " + this.SumarNumeros();
        }
    }
}
