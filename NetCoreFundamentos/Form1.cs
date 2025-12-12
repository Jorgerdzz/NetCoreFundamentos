namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.label2.Text = "Hola " + this.txtNombre.Text;
            this.txtNombre.BackColor = Color.Bisque;

            //NO ES CONVERSION AUTOMATICA
            short pequeño = 88;
            int mayor = pequeño;
            

            //STRING A PRIMITIVO
            string textoNumero = "888";
            int numero = int.Parse(textoNumero);

            //CASTING
            int my = 88;
            short peque = (short) my;
            string dato = peque.ToString();

        }
    }
}
