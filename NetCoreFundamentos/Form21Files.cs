using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {

        public string Path { get; set; }
        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();
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
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenido.Text = content;
            string [] nombres = content.Split(',');
            foreach(string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            string content = this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos almacenados");
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
