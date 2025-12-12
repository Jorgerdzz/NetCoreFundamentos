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
        }
    }
}
