using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        #region PROPIEDADES
        protected int SalarioMinimo { get; set; }

        #endregion

        #region CONSTRUCTORES
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1000;
        }

        public Empleado(string nombre, string apellidos, int edad) : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            Debug.WriteLine("constructor EMPLEADO con dos parámetros");
        }
        #endregion

        #region METODOS
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVacaciones()
        {
            return 22;
        }

        #endregion

    }
}
