namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            txtProducto = new TextBox();
            btnAnadir = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            label2 = new Label();
            label3 = new Label();
            lstTienda = new ListBox();
            lstAlmacen = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 37);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(43, 65);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(134, 23);
            txtProducto.TabIndex = 1;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(43, 110);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(134, 28);
            btnAnadir.TabIndex = 2;
            btnAnadir.Text = "Nuevo";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(43, 159);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 31);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(43, 211);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(134, 36);
            btnBorrarTodo.TabIndex = 4;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 34);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Tienda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 35);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Almacen";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(260, 67);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(120, 169);
            lstTienda.TabIndex = 7;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(532, 65);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(120, 169);
            lstAlmacen.TabIndex = 8;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(414, 100);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 9;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(414, 163);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 10;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(692, 100);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(692, 163);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 23);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(lstAlmacen);
            Controls.Add(lstTienda);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnAnadir);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnAnadir;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label label2;
        private Label label3;
        private ListBox lstTienda;
        private ListBox lstAlmacen;
        private Button btnSeleccion;
        private Button btnTodos;
        private Button btnSubir;
        private Button btnBajar;
    }
}