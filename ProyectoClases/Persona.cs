using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    #region ENUMERACIONES
    //LAS ENUMERACIONES ESTAN DENTRO DEL NAMESPACE
    public enum TipoGenero { Masculino = 0, Femenino = 1 } //No es necesario poner los numeros
    public enum Paises { España, Francia, Alemania, Portugal, Colombia }
    #endregion

    public class Persona
    {
        #region CONSTRUCTORES

        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacio");
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("constructor PERSONA con dos parámetros");
        }

        #endregion

        #region PROPIEDADES
        public string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set {
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + dato;
            }
        }
        public TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if(value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("Donde vas, listo...");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }


        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //CAMPO PROPIEDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set 
            {
                if(value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else 
                {
                    this._Edad = value;
                }
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        #endregion

        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }

        public string GetNombreCompleto(int num1, int num2)
        {
            return this.GetNombreCompleto().ToLower();
        }

        #endregion
    }
}
