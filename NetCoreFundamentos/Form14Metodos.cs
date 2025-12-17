using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        void GetDobleValor(int numero)
        {
            numero = numero * 2;
        }

        int GetDoble(int num)
        {
            return num * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            int resultado = this.GetDoble(numero);
            this.lblResultado.Text = resultado.ToString();
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightBlue;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleValor);
            this.CambiarColor(this.btnDobleReferencia);
        }

        void GetDobleValorReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValorReferencia(ref numero);
            this.lblResultado.Text = numero.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + " Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char) Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar!= teclaBorrar)
            {
                //Indica si nos hacemos cargo del evento de key
                e.Handled = true;

            }
            
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
