using ProyectoClases.Helpers;
using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form22Mascotas : Form
    {

        HelperMascotas helper;
        public Form22Mascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            await helper.ReadMascotasAsync();
            this.DibujarMascotas();
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            await helper.WriteMascotasAsyc();
            this.lstMascotas.Items.Clear();
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != 1)
            {
                Mascota mascota = this.helper.Mascotas[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
