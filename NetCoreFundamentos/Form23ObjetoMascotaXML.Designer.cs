namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            Raza = new Label();
            txtRaza = new TextBox();
            Edad = new Label();
            txtEdad = new TextBox();
            btnLeerClase = new Button();
            btnGuardarClase = new Button();
            btnExaminar = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(45, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(45, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 1;
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Location = new Point(48, 103);
            Raza.Name = "Raza";
            Raza.Size = new Size(31, 15);
            Raza.TabIndex = 2;
            Raza.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(45, 130);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(130, 23);
            txtRaza.TabIndex = 3;
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Location = new Point(48, 169);
            Edad.Name = "Edad";
            Edad.Size = new Size(33, 15);
            Edad.TabIndex = 4;
            Edad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(48, 198);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(127, 23);
            txtEdad.TabIndex = 5;
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(206, 37);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(136, 48);
            btnLeerClase.TabIndex = 6;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(206, 103);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(136, 50);
            btnGuardarClase.TabIndex = 7;
            btnGuardarClase.Text = "Guardar clase";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(206, 171);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(136, 50);
            btnExaminar.TabIndex = 20;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(367, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardarClase);
            Controls.Add(btnLeerClase);
            Controls.Add(txtEdad);
            Controls.Add(Edad);
            Controls.Add(txtRaza);
            Controls.Add(Raza);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label Raza;
        private TextBox txtRaza;
        private Label Edad;
        private TextBox txtEdad;
        private Button btnLeerClase;
        private Button btnGuardarClase;
        private Button btnExaminar;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}