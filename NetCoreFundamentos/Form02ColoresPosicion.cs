using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int posicionX = int.Parse(this.txtPosicionX.Text);
            int posicionY = int.Parse(this.txtPosicionY.Text);
            this.btnCambiarFondo.Location = new Point(posicionX, posicionY);
        }

        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            int numeroRojo = int.Parse(txtRojo.Text);
            int numeroAzul = int.Parse(txtAzul.Text);
            int numeroVerde = int.Parse(txtVerde.Text);
            if(numeroRojo < 0  || numeroRojo > 255)
            {
                MessageBox.Show("El valor de rojo debe estar comprendido entre 0 y 255");
            }
            else if (numeroVerde < 0 || numeroVerde > 255)
            {
                MessageBox.Show("El valor de verde debe estar comprendido entre 0 y 255");
            }
            else if (numeroAzul < 0 || numeroAzul > 255)
            {
                MessageBox.Show("El valor de azul debe estar comprendido entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(numeroRojo, numeroVerde, numeroAzul);
            }
        }
    }
}
