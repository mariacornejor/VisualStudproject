
namespace PracticaFinalPrototipo
{
    partial class GestionProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewDatosProductos = new System.Windows.Forms.ListView();
            this.ColumnaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAnnadir = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCompuesto = new System.Windows.Forms.Button();
            this.pictureBoxImagenProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDatosProductos
            // 
            this.listViewDatosProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaID,
            this.ColumnaNombre,
            this.ColumnaStock,
            this.ColumnaPrecio,
            this.columnHeader1});
            this.listViewDatosProductos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDatosProductos.HideSelection = false;
            this.listViewDatosProductos.Location = new System.Drawing.Point(7, 426);
            this.listViewDatosProductos.Name = "listViewDatosProductos";
            this.listViewDatosProductos.Size = new System.Drawing.Size(1161, 313);
            this.listViewDatosProductos.TabIndex = 4;
            this.listViewDatosProductos.UseCompatibleStateImageBehavior = false;
            this.listViewDatosProductos.View = System.Windows.Forms.View.Details;
            this.listViewDatosProductos.Click += new System.EventHandler(this.listViewDatosProductos_Click);
            // 
            // ColumnaID
            // 
            this.ColumnaID.Text = "Id";
            this.ColumnaID.Width = 57;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.Text = "Nombre";
            this.ColumnaNombre.Width = 474;
            // 
            // ColumnaStock
            // 
            this.ColumnaStock.Text = "Stock";
            this.ColumnaStock.Width = 176;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.Text = "Precio";
            this.ColumnaPrecio.Width = 199;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo";
            this.columnHeader1.Width = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imagen Producto";
            // 
            // buttonAnnadir
            // 
            this.buttonAnnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonAnnadir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnadir.Location = new System.Drawing.Point(962, 96);
            this.buttonAnnadir.Name = "buttonAnnadir";
            this.buttonAnnadir.Size = new System.Drawing.Size(157, 64);
            this.buttonAnnadir.TabIndex = 7;
            this.buttonAnnadir.Text = "Añadir";
            this.buttonAnnadir.UseVisualStyleBackColor = false;
            this.buttonAnnadir.Click += new System.EventHandler(this.buttonAnnadir_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonBorrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(962, 236);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(157, 64);
            this.buttonBorrar.TabIndex = 8;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(962, 166);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(157, 64);
            this.buttonModificar.TabIndex = 9;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(323, 338);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(248, 32);
            this.textBoxBuscar.TabIndex = 10;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.Location = new System.Drawing.Point(323, 386);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(248, 34);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // buttonCompuesto
            // 
            this.buttonCompuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonCompuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonCompuesto.Location = new System.Drawing.Point(962, 306);
            this.buttonCompuesto.Name = "buttonCompuesto";
            this.buttonCompuesto.Size = new System.Drawing.Size(157, 64);
            this.buttonCompuesto.TabIndex = 13;
            this.buttonCompuesto.Text = "Productos Compuestos";
            this.buttonCompuesto.UseVisualStyleBackColor = false;
            this.buttonCompuesto.Visible = false;
            this.buttonCompuesto.Click += new System.EventHandler(this.buttonCompuesto_Click);
            // 
            // pictureBoxImagenProducto
            // 
            this.pictureBoxImagenProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImagenProducto.Location = new System.Drawing.Point(51, 84);
            this.pictureBoxImagenProducto.Name = "pictureBoxImagenProducto";
            this.pictureBoxImagenProducto.Size = new System.Drawing.Size(248, 336);
            this.pictureBoxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenProducto.TabIndex = 15;
            this.pictureBoxImagenProducto.TabStop = false;
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 747);
            this.Controls.Add(this.pictureBoxImagenProducto);
            this.Controls.Add(this.buttonCompuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonAnnadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDatosProductos);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "GestionProductos";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.listViewDatosProductos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonAnnadir, 0);
            this.Controls.SetChildIndex(this.buttonBorrar, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.Controls.SetChildIndex(this.textBoxBuscar, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.buttonCompuesto, 0);
            this.Controls.SetChildIndex(this.pictureBoxImagenProducto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDatosProductos;
        private System.Windows.Forms.ColumnHeader ColumnaID;
        private System.Windows.Forms.ColumnHeader ColumnaNombre;
        private System.Windows.Forms.ColumnHeader ColumnaStock;
        private System.Windows.Forms.ColumnHeader ColumnaPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnnadir;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonCompuesto;
        private System.Windows.Forms.PictureBox pictureBoxImagenProducto;
    }
}

