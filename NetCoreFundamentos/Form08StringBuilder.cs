using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertirString_Click(object sender, EventArgs e)
        {
            string cadena = this.txtTexto.Text;
            string cadenaInvertida = "";

            Stopwatch crono = new Stopwatch();

            crono.Start();

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                cadenaInvertida += cadena[i];
            }
            crono.Stop();
            this.lblTiempo.Text = "Segundos: " + crono.Elapsed.Seconds + ", Milisegundos: " + crono.Elapsed.Microseconds;
            this.lblInvertirString.Text = cadenaInvertida;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(this.txtTexto.Text);
            string cadenaInvertida = "";

            Stopwatch crono = new Stopwatch();

            crono.Start();

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                cadenaInvertida += cadena[i];
            }
            crono.Stop();
            this.lblTiempo.Text = "Segundos: " + crono.Elapsed.Seconds + ", Milisegundos: " + crono.Elapsed.Microseconds;
            this.lblStringBuilder.Text = cadenaInvertida;
        }
    }
}
