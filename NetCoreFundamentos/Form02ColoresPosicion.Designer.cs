namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            txtPosicionX = new TextBox();
            label2 = new Label();
            txtPosicionY = new TextBox();
            btnCambiarPosicion = new Button();
            txtVerde = new TextBox();
            Verde = new Label();
            txtRojo = new TextBox();
            Rojo = new Label();
            Azul = new Label();
            txtAzul = new TextBox();
            btnCambiarFondo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 32);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Posicion X";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(66, 62);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 113);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Posicion Y";
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(66, 145);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 3;
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(68, 206);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(98, 40);
            btnCambiarPosicion.TabIndex = 4;
            btnCambiarPosicion.Text = "Cambiar posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(378, 83);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 8;
            // 
            // Verde
            // 
            Verde.AutoSize = true;
            Verde.Location = new Point(321, 86);
            Verde.Name = "Verde";
            Verde.Size = new Size(36, 15);
            Verde.TabIndex = 7;
            Verde.Text = "Verde";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(378, 32);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 6;
            // 
            // Rojo
            // 
            Rojo.AutoSize = true;
            Rojo.Location = new Point(321, 32);
            Rojo.Name = "Rojo";
            Rojo.Size = new Size(31, 15);
            Rojo.TabIndex = 5;
            Rojo.Text = "Rojo";
            // 
            // Azul
            // 
            Azul.AutoSize = true;
            Azul.Location = new Point(321, 145);
            Azul.Name = "Azul";
            Azul.Size = new Size(30, 15);
            Azul.TabIndex = 9;
            Azul.Text = "Azul";
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(378, 137);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 10;
            // 
            // btnCambiarFondo
            // 
            btnCambiarFondo.Location = new Point(321, 191);
            btnCambiarFondo.Name = "btnCambiarFondo";
            btnCambiarFondo.Size = new Size(157, 38);
            btnCambiarFondo.TabIndex = 11;
            btnCambiarFondo.Text = "Cambiar fondo";
            btnCambiarFondo.UseVisualStyleBackColor = true;
            btnCambiarFondo.Click += btnCambiarFondo_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarFondo);
            Controls.Add(txtAzul);
            Controls.Add(Azul);
            Controls.Add(txtVerde);
            Controls.Add(Verde);
            Controls.Add(txtRojo);
            Controls.Add(Rojo);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(txtPosicionY);
            Controls.Add(label2);
            Controls.Add(txtPosicionX);
            Controls.Add(label1);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPosicionX;
        private Label label2;
        private TextBox txtPosicionY;
        private Button btnCambiarPosicion;
        private TextBox txtVerde;
        private Label Verde;
        private TextBox txtRojo;
        private Label Rojo;
        private Label Azul;
        private TextBox txtAzul;
        private Button btnCambiarFondo;
    }
}