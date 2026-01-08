using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Alumno";
            person.Apellidos = "Reyes";
            person.Edad = 20;
            person.Genero = (TipoGenero)1;
            person.Nacionalidad = Paises.España;

            person.Domicilio.Calle = "Avenida Europa";
            person.Domicilio.Ciudad = "Madrid";
            person.Domicilio.CodigoPostal = 28400;

            person[0] = "Vamos 1";
            person[1] = "Vamos 2";


            this.lstClases.Items.Add(
                "Nombre: " + person.Nombre + 
                ", Apellidos: " + person.Apellidos + 
                ", Edad: " + person.Edad + 
                ", Genero: " + person.Genero
            );

            this.lstClases.Items.Add(
                "Nombre completo: " + person.GetNombreCompleto()
            );

            this.lstClases.Items.Add(
                "Direccion: " + person.Domicilio.Calle + ", " +
                person.Domicilio.Ciudad + ", " +
                person.Domicilio.CodigoPostal);
        }
    }
}
