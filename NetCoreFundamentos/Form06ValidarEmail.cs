using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;

            int indiceArroba = email.IndexOf('@');
            string dominioPunto = email.Substring(indiceArroba + 1);
            Boolean empiezaPunto =  dominioPunto.StartsWith('.');
            string dominio = dominioPunto.Substring(1);

            if (
                email.Contains('@') && !email.StartsWith('@') && !email.EndsWith('@') &&
                email.Contains('.') && !(email.Count('@')>1) && (dominio.Length>1 && dominio.Length<4) &&
                empiezaPunto
                )
            {
                this.lblResultado.Text = "Email correcto";
                this.lblResultado.ForeColor = Color.Green;
            }
            else
            {
                this.lblResultado.Text = "Email incorrecto";
                this.lblResultado.ForeColor = Color.Red;
            }


        }
    }
}
