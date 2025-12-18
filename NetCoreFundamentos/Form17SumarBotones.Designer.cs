namespace NetCoreFundamentos
{
    partial class Form17SumarBotones
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
            txtSuma = new TextBox();
            btnIniciarApp = new Button();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 33);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(116, 30);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 1;
            txtSuma.Text = "0";
            // 
            // btnIniciarApp
            // 
            btnIniciarApp.Location = new Point(255, 30);
            btnIniciarApp.Name = "btnIniciarApp";
            btnIniciarApp.Size = new Size(91, 23);
            btnIniciarApp.TabIndex = 2;
            btnIniciarApp.Text = "Iniciar App";
            btnIniciarApp.UseVisualStyleBackColor = true;
            btnIniciarApp.Click += btnIniciarApp_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(58, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 258);
            panel1.TabIndex = 3;
            // 
            // button7
            // 
            button7.Location = new Point(159, 144);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 5;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(23, 144);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 4;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(159, 80);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(23, 80);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(159, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(23, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form17SumarBotones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 374);
            Controls.Add(panel1);
            Controls.Add(btnIniciarApp);
            Controls.Add(txtSuma);
            Controls.Add(label1);
            Name = "Form17SumarBotones";
            Text = "Form17SumarBotones";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSuma;
        private Button btnIniciarApp;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button7;
        private Button button6;
        private Button button5;
    }
}