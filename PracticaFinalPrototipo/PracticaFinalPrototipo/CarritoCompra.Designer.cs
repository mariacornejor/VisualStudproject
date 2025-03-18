namespace PracticaFinalPrototipo
{
    partial class CarritoCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCarritoCompras = new System.Windows.Forms.ListView();
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preciototal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preciofinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.labeltotalcompra = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonProcesarCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carrito de Compras";
            // 
            // listViewCarritoCompras
            // 
            this.listViewCarritoCompras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.producto,
            this.preciototal,
            this.cantidad,
            this.preciofinal});
            this.listViewCarritoCompras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCarritoCompras.HideSelection = false;
            this.listViewCarritoCompras.Location = new System.Drawing.Point(7, 122);
            this.listViewCarritoCompras.Name = "listViewCarritoCompras";
            this.listViewCarritoCompras.Size = new System.Drawing.Size(786, 186);
            this.listViewCarritoCompras.TabIndex = 5;
            this.listViewCarritoCompras.UseCompatibleStateImageBehavior = false;
            this.listViewCarritoCompras.View = System.Windows.Forms.View.Details;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 153;
            // 
            // preciototal
            // 
            this.preciototal.Text = "Precio Unitario";
            this.preciototal.Width = 187;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 181;
            // 
            // preciofinal
            // 
            this.preciofinal.Text = "Precio Total";
            this.preciofinal.Width = 221;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total compra:";
            // 
            // labeltotalcompra
            // 
            this.labeltotalcompra.AutoSize = true;
            this.labeltotalcompra.BackColor = System.Drawing.Color.Transparent;
            this.labeltotalcompra.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalcompra.Location = new System.Drawing.Point(567, 370);
            this.labeltotalcompra.Name = "labeltotalcompra";
            this.labeltotalcompra.Size = new System.Drawing.Size(21, 25);
            this.labeltotalcompra.TabIndex = 7;
            this.labeltotalcompra.Text = "-";
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonBorrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(36, 314);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(156, 32);
            this.buttonBorrar.TabIndex = 9;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonProcesarCompra
            // 
            this.buttonProcesarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonProcesarCompra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonProcesarCompra.Location = new System.Drawing.Point(625, 349);
            this.buttonProcesarCompra.Name = "buttonProcesarCompra";
            this.buttonProcesarCompra.Size = new System.Drawing.Size(138, 64);
            this.buttonProcesarCompra.TabIndex = 10;
            this.buttonProcesarCompra.Text = "Realizar compra";
            this.buttonProcesarCompra.UseVisualStyleBackColor = false;
            this.buttonProcesarCompra.Click += new System.EventHandler(this.buttonProcesarCompra_Click);
            // 
            // CarritoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.buttonProcesarCompra);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.labeltotalcompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewCarritoCompras);
            this.Controls.Add(this.label1);
            this.Name = "CarritoCompra";
            this.Text = "CarritoCompra";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.listViewCarritoCompras, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.labeltotalcompra, 0);
            this.Controls.SetChildIndex(this.buttonBorrar, 0);
            this.Controls.SetChildIndex(this.buttonProcesarCompra, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewCarritoCompras;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader preciototal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeltotalcompra;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonProcesarCompra;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.ColumnHeader preciofinal;
    }
}