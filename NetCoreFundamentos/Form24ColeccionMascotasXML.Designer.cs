namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
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
            txtEdad = new TextBox();
            Edad = new Label();
            txtRaza = new TextBox();
            Raza = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
            lstMascotas = new ListBox();
            btnLeerMascotas = new Button();
            btnGuardarMascotas = new Button();
            btnNuevaMascota = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(69, 196);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(127, 23);
            txtEdad.TabIndex = 11;
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Location = new Point(69, 167);
            Edad.Name = "Edad";
            Edad.Size = new Size(33, 15);
            Edad.TabIndex = 10;
            Edad.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(66, 128);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(130, 23);
            txtRaza.TabIndex = 9;
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Location = new Point(69, 101);
            Raza.Name = "Raza";
            Raza.Size = new Size(31, 15);
            Raza.TabIndex = 8;
            Raza.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(66, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 33);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 12;
            label1.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(231, 60);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(209, 214);
            lstMascotas.TabIndex = 13;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(468, 60);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(105, 54);
            btnLeerMascotas.TabIndex = 14;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(468, 125);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(105, 62);
            btnGuardarMascotas.TabIndex = 15;
            btnGuardarMascotas.Text = "Guardar mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(69, 258);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(127, 28);
            btnNuevaMascota.TabIndex = 16;
            btnNuevaMascota.Text = "Nueva mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(613, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(468, 208);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(105, 50);
            btnExaminar.TabIndex = 18;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 450);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaMascota);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label1);
            Controls.Add(txtEdad);
            Controls.Add(Edad);
            Controls.Add(txtRaza);
            Controls.Add(Raza);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdad;
        private Label Edad;
        private TextBox txtRaza;
        private Label Raza;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label1;
        private ListBox lstMascotas;
        private Button btnLeerMascotas;
        private Button btnGuardarMascotas;
        private Button btnNuevaMascota;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}