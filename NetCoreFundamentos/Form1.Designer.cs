namespace NetCoreFundamentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPulsar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(76, 117);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(226, 38);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsar";
            btnPulsar.UseVisualStyleBackColor = true;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 46);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduzca su nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(76, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 174);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnPulsar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
    }
}
