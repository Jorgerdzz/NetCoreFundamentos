using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {

        public string Path { get; set; }

        public Form21Files()
        {
            InitializeComponent();
            //TENEMOS DOS FORMAS PARA ESCRIBIR LAS RUTAS
            //1) C:\carperta\1.txt
            //this.Path = "C:\\carpeta\\1.txt"; CON DOBLE BARRA
            //2) Utilizar @ antes del String y fuera del String
            //this.Path = @"C:\\carpeta\\1.txt";

            this.Path = "file1.txt";

        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.Path);
            using (TextReader reader = file.OpenText())
            {
                string content = await reader.ReadToEndAsync();
                reader.Close();
                this.txtContenido.Text = content;
            }
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            //TENEMOS LA CLASE FileInfo QUE NOS DEVUELVE UN FILE Y PODEMOS GENERAR UN WRITER/READER
            FileInfo file = new FileInfo(this.Path);

            //CREAMOS FICHERO
            using (TextWriter writer = file.CreateText())
            {
                string content = this.GetNombresListBox();

                //ESCRIBIMOS EN EL FICHERO
                await writer.WriteAsync(content);

                //DESPUES DE ESCRIBIR EN CUALQUIER FICHERO, DEBEMOS LIBERAR LA MEMORIA PARA HACERLO FIJO
                await writer.FlushAsync();

                //CERRAMOS EL FICHERO
                writer.Close();
                MessageBox.Show("Fichero almacenado");
            }
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach(string name in this.lstNombres.Items)
            {
                data += name + ", ";
            }
            data = data.Trim(',');
            return data;
        }
    }
}
