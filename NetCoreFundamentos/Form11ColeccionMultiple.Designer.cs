namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblIndex = new Label();
            lblItem = new Label();
            btnEliminarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            btnVisualizarSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(232, 394);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(49, 15);
            lblIndex.TabIndex = 17;
            lblIndex.Text = "lblIndex";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(154, 394);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(44, 15);
            lblItem.TabIndex = 16;
            lblItem.Text = "lblItem";
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.Location = new Point(415, 256);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(235, 40);
            btnEliminarTodo.TabIndex = 15;
            btnEliminarTodo.Text = "Borrar todo";
            btnEliminarTodo.UseVisualStyleBackColor = true;
            btnEliminarTodo.Click += btnEliminarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(415, 196);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 32);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(415, 122);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(235, 36);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(416, 75);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(234, 23);
            txtElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 41);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "Nuevo elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(151, 81);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(153, 289);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 44);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // btnVisualizarSeleccionados
            // 
            btnVisualizarSeleccionados.Location = new Point(415, 324);
            btnVisualizarSeleccionados.Name = "btnVisualizarSeleccionados";
            btnVisualizarSeleccionados.Size = new Size(235, 35);
            btnVisualizarSeleccionados.TabIndex = 18;
            btnVisualizarSeleccionados.Text = "Seleccionados";
            btnVisualizarSeleccionados.UseVisualStyleBackColor = true;
            btnVisualizarSeleccionados.Click += btnVisualizarSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisualizarSeleccionados);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnEliminarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblItem;
        private Button btnEliminarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
        private Button btnVisualizarSeleccionados;
    }
}