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
            this.BackColor = Color.FromArgb(numeroRojo, numeroVerde, numeroAzul);
        }
    }
}
