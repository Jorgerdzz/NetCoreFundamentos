using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            if (!this.lstTienda.Items.Contains(producto))
            {
                this.lstTienda.Items.Add(producto);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int indices = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(indices);
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            foreach (string producto in this.lstTienda.SelectedItems)
            {
                this.lstAlmacen.Items.Add(producto);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string producto in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(producto);
            }
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            for(int i=0; i<=this.lstAlmacen.SelectedItems.Count-1; i++)
            {
                int index = this.lstAlmacen.SelectedIndices[i]
            }
        }
    }
}
