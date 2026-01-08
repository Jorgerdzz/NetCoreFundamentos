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

            Direccion domicilio = new Direccion();
            domicilio.Calle = "Avenida Europa";
            domicilio.Ciudad = "Madrid";
            domicilio.CodigoPostal = 28400;

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
                "Direccion: " + domicilio.Calle + ", " +
                domicilio.Ciudad + ", " +
                domicilio.CodigoPostal);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado emp = new Empleado("Nombre", "Apellidos");
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "tonto";
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacaciones empleado: " + emp.GetDiasVacaciones());

            Director dire = new Director();
            dire.Nombre = "Alberto";
            dire.Apellidos = "Rodriguez";
            this.lstClases.Items.Add("Director: " + dire.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dire.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacaciones director: " + dire.GetDiasVacaciones());

        }
    }
}
