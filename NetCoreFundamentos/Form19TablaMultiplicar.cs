using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones;
        List<TextBox> cajas;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.botones.Add(button1);
            this.botones.Add(button2);
            this.botones.Add(button3);
            this.botones.Add(button4);

            this.cajas = new List<TextBox>();
            this.cajas.Add(textBox1);
            this.cajas.Add(textBox2);
            this.cajas.Add(textBox3);
            this.cajas.Add(textBox4);
            this.cajas.Add(textBox5);

            foreach (Control control in this.Controls)
            {
                if(control is Button)
                {

                    control.Click += TablaMultiplicar;
                }
            }

        }

        private void TablaMultiplicar(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int numero = int.Parse(botonPulsado.Text);
            for(int i=0; i<=this.cajas.Count-1; i++)
            {
                int resultado = numero * i;
                this.cajas[i].Text = resultado.ToString();
            }
        }
    }
}
