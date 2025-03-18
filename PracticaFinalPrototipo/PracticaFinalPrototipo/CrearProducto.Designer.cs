
namespace PracticaFinalPrototipo
{
    partial class CrearProducto
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
            this.listViewIngredientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewListaFinal = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPFinal = new System.Windows.Forms.Label();
            this.buttonTerminar = new System.Windows.Forms.Button();
            this.textBoxNProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxIngrediente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIngrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewIngredientes
            // 
            this.listViewIngredientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewIngredientes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewIngredientes.HideSelection = false;
            this.listViewIngredientes.Location = new System.Drawing.Point(43, 151);
            this.listViewIngredientes.Name = "listViewIngredientes";
            this.listViewIngredientes.Size = new System.Drawing.Size(384, 370);
            this.listViewIngredientes.TabIndex = 4;
            this.listViewIngredientes.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientes.View = System.Windows.Forms.View.Details;
            this.listViewIngredientes.Click += new System.EventHandler(this.listViewIngredientes_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.Width = 183;
            // 
            // listViewListaFinal
            // 
            this.listViewListaFinal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewListaFinal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewListaFinal.HideSelection = false;
            this.listViewListaFinal.Location = new System.Drawing.Point(774, 151);
            this.listViewListaFinal.Name = "listViewListaFinal";
            this.listViewListaFinal.Size = new System.Drawing.Size(384, 370);
            this.listViewListaFinal.TabIndex = 5;
            this.listViewListaFinal.UseCompatibleStateImageBehavior = false;
            this.listViewListaFinal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            this.columnHeader3.Width = 191;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 184;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(43, 614);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(156, 33);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Cancelar";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonInsertar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.Location = new System.Drawing.Point(485, 423);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(167, 67);
            this.buttonInsertar.TabIndex = 8;
            this.buttonInsertar.Text = "Añadir ingrediente";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(774, 527);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(183, 28);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar ingrediente";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingredientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(769, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Producto Final";
            // 
            // labelPFinal
            // 
            this.labelPFinal.AutoSize = true;
            this.labelPFinal.BackColor = System.Drawing.Color.Transparent;
            this.labelPFinal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPFinal.Location = new System.Drawing.Point(963, 527);
            this.labelPFinal.Name = "labelPFinal";
            this.labelPFinal.Size = new System.Drawing.Size(152, 28);
            this.labelPFinal.TabIndex = 13;
            this.labelPFinal.Text = "Precio Final:";
            // 
            // buttonTerminar
            // 
            this.buttonTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonTerminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonTerminar.Location = new System.Drawing.Point(1030, 615);
            this.buttonTerminar.Name = "buttonTerminar";
            this.buttonTerminar.Size = new System.Drawing.Size(156, 33);
            this.buttonTerminar.TabIndex = 14;
            this.buttonTerminar.Text = "Terminar";
            this.buttonTerminar.UseVisualStyleBackColor = false;
            this.buttonTerminar.Click += new System.EventHandler(this.buttonTerminar_Click);
            // 
            // textBoxNProducto
            // 
            this.textBoxNProducto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNProducto.Location = new System.Drawing.Point(772, 615);
            this.textBoxNProducto.Multiline = true;
            this.textBoxNProducto.Name = "textBoxNProducto";
            this.textBoxNProducto.Size = new System.Drawing.Size(252, 33);
            this.textBoxNProducto.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre del producto:";
            // 
            // pictureBoxIngrediente
            // 
            this.pictureBoxIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxIngrediente.Location = new System.Drawing.Point(452, 151);
            this.pictureBoxIngrediente.Name = "pictureBoxIngrediente";
            this.pictureBoxIngrediente.Size = new System.Drawing.Size(223, 266);
            this.pictureBoxIngrediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIngrediente.TabIndex = 17;
            this.pictureBoxIngrediente.TabStop = false;
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 683);
            this.Controls.Add(this.pictureBoxIngrediente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNProducto);
            this.Controls.Add(this.buttonTerminar);
            this.Controls.Add(this.labelPFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.listViewListaFinal);
            this.Controls.Add(this.listViewIngredientes);
            this.Name = "CrearProducto";
            this.Text = "CrearProducto";
            this.Controls.SetChildIndex(this.listViewIngredientes, 0);
            this.Controls.SetChildIndex(this.listViewListaFinal, 0);
            this.Controls.SetChildIndex(this.buttonSalir, 0);
            this.Controls.SetChildIndex(this.buttonInsertar, 0);
            this.Controls.SetChildIndex(this.buttonEliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.labelPFinal, 0);
            this.Controls.SetChildIndex(this.buttonTerminar, 0);
            this.Controls.SetChildIndex(this.textBoxNProducto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pictureBoxIngrediente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIngrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewIngredientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewListaFinal;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPFinal;
        private System.Windows.Forms.Button buttonTerminar;
        private System.Windows.Forms.TextBox textBoxNProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxIngrediente;
    }
}