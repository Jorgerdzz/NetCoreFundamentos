using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> lista;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.lista = new List<CheckBox>();
            foreach(CheckBox checkbox in this.panel1.Controls)
            {
                this.lista.Add(checkbox);
                checkbox.CheckedChanged += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            CheckBox checkboxMarcado = (CheckBox)sender;
            int numero = int.Parse(checkboxMarcado.Text);
            int suma = int.Parse(this.txtSuma.Text);
            suma += numero;
            if (!checkboxMarcado.Checked)
            {
                suma -= numero;
            }
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach(CheckBox checkbox in this.lista)
            {
                int aleatorio = random.Next(1, 50);
                checkbox.Text = aleatorio.ToString();
            }
        }
    }
}
