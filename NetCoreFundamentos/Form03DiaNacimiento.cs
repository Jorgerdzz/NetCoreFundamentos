using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anio = int.Parse(this.txtAnio.Text);
            string resultado = "";

            if (mes == 1)
            {
                mes = 13;
                anio--;
            }

            if (mes == 2)
            {
                mes = 14;
                anio--;
            }

            int paso1 = ((mes + 1) * 3) / 5;
            int paso2 = anio / 4;
            int paso3 = anio / 100;
            int paso4 = anio / 400;
            int paso5 = dia + (mes * 2) + anio + paso1 + paso2 - paso3 + paso4 + 2;
            int paso6 = paso5 / 7;
            int paso7 = paso5 - (paso6 * 7);

            if (paso7 == 0)
            {
                resultado = "SABADO";
            }
            else if (paso7 == 1)
            {
                resultado = "DOMINGO";
            }
            else if (paso7 == 2)
            {
                resultado = "LUNES";
            }
            else if (paso7 == 3)
            {
                resultado = "MARTES";
            }
            else if (paso7 == 4)
            {
                resultado = "MIERCOLES";
            }
            else if (paso7 == 5)
            {
                resultado = "JUEVES";
            }
            else if (paso7 == 6)
            {
                resultado = "VIERNES";
            }

            this.txtMostrarDia.Text = "El día de la semana es " + resultado;
            this.txtMostrarDia.ForeColor = Color.Blue;

        }
    }
}
