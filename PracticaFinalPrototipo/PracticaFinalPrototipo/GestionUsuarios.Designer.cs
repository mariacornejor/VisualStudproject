
namespace PracticaFinalPrototipo
{
    partial class GestionUsuarios
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
            this.listViewDatosUsuarios = new System.Windows.Forms.ListView();
            this.ColumnaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAnnadir = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewDatosUsuarios
            // 
            this.listViewDatosUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaID,
            this.ColumnaNombre,
            this.ColumnaStock,
            this.ColumnaPrecio,
            this.columnHeader1});
            this.listViewDatosUsuarios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDatosUsuarios.HideSelection = false;
            this.listViewDatosUsuarios.Location = new System.Drawing.Point(7, 119);
            this.listViewDatosUsuarios.Name = "listViewDatosUsuarios";
            this.listViewDatosUsuarios.Size = new System.Drawing.Size(1186, 357);
            this.listViewDatosUsuarios.TabIndex = 4;
            this.listViewDatosUsuarios.UseCompatibleStateImageBehavior = false;
            this.listViewDatosUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // ColumnaID
            // 
            this.ColumnaID.Text = "DNI";
            this.ColumnaID.Width = 230;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.Text = "Nombre";
            this.ColumnaNombre.Width = 219;
            // 
            // ColumnaStock
            // 
            this.ColumnaStock.Text = "Apellidos";
            this.ColumnaStock.Width = 233;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.Text = "Rol";
            this.ColumnaPrecio.Width = 218;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Correo";
            this.columnHeader1.Width = 257;
            // 
            // buttonAnnadir
            // 
            this.buttonAnnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonAnnadir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnadir.Location = new System.Drawing.Point(561, 62);
            this.buttonAnnadir.Name = "buttonAnnadir";
            this.buttonAnnadir.Size = new System.Drawing.Size(193, 32);
            this.buttonAnnadir.TabIndex = 7;
            this.buttonAnnadir.Text = "Añadir";
            this.buttonAnnadir.UseVisualStyleBackColor = false;
            this.buttonAnnadir.Click += new System.EventHandler(this.buttonAnnadir_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonBorrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(958, 62);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(193, 32);
            this.buttonBorrar.TabIndex = 8;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(760, 62);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(193, 32);
            this.buttonModificar.TabIndex = 9;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(313, 64);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(180, 32);
            this.textBoxBuscar.TabIndex = 10;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.Location = new System.Drawing.Point(55, 62);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(206, 34);
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
            this.label2.Location = new System.Drawing.Point(267, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "DNI:";
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonAnnadir);
            this.Controls.Add(this.listViewDatosUsuarios);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "GestionUsuarios";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.listViewDatosUsuarios, 0);
            this.Controls.SetChildIndex(this.buttonAnnadir, 0);
            this.Controls.SetChildIndex(this.buttonBorrar, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.Controls.SetChildIndex(this.textBoxBuscar, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDatosUsuarios;
        private System.Windows.Forms.ColumnHeader ColumnaID;
        private System.Windows.Forms.ColumnHeader ColumnaNombre;
        private System.Windows.Forms.ColumnHeader ColumnaStock;
        private System.Windows.Forms.ColumnHeader ColumnaPrecio;
        private System.Windows.Forms.Button buttonAnnadir;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

