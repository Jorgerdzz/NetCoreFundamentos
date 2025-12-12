namespace NetCoreFundamentos
{
    partial class Form01SumarNumeros
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
            label1 = new Label();
            txtNumero1 = new TextBox();
            label2 = new Label();
            btnSumar = new Button();
            label3 = new Label();
            txtNumero2 = new TextBox();
            txtNumero3 = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 35);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(92, 63);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 110);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero 2";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(274, 95);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(201, 67);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "Sumar numeros";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 199);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Numero 3";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(96, 139);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 5;
            // 
            // txtNumero3
            // 
            txtNumero3.Location = new Point(96, 226);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(100, 23);
            txtNumero3.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(626, 100);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "label4";
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero3);
            Controls.Add(txtNumero2);
            Controls.Add(label3);
            Controls.Add(btnSumar);
            Controls.Add(label2);
            Controls.Add(txtNumero1);
            Controls.Add(label1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private Button btnSumar;
        private Label label3;
        private TextBox txtNumero2;
        private TextBox txtNumero3;
        private Label lblResultado;
    }
}