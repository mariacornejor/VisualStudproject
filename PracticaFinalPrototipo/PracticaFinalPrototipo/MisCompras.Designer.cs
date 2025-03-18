
namespace PracticaFinalPrototipo
{
    partial class MisCompras
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
            this.listViewCompras = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelEstadoPag = new System.Windows.Forms.Label();
            this.labelNPedido = new System.Windows.Forms.Label();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.buttonAvanzar = new System.Windows.Forms.Button();
            this.buttonFactura = new System.Windows.Forms.Button();
            this.buttonSalilr = new System.Windows.Forms.Button();
            this.comboBoxNombres = new System.Windows.Forms.ComboBox();
            this.labelPTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCompras
            // 
            this.listViewCompras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCompras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCompras.HideSelection = false;
            this.listViewCompras.Location = new System.Drawing.Point(52, 116);
            this.listViewCompras.Name = "listViewCompras";
            this.listViewCompras.Size = new System.Drawing.Size(472, 294);
            this.listViewCompras.TabIndex = 4;
            this.listViewCompras.UseCompatibleStateImageBehavior = false;
            this.listViewCompras.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Productos";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio Unitario";
            this.columnHeader3.Width = 129;
            // 
            // labelEstadoPag
            // 
            this.labelEstadoPag.AutoSize = true;
            this.labelEstadoPag.BackColor = System.Drawing.Color.Transparent;
            this.labelEstadoPag.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoPag.Location = new System.Drawing.Point(281, 423);
            this.labelEstadoPag.Name = "labelEstadoPag";
            this.labelEstadoPag.Size = new System.Drawing.Size(29, 32);
            this.labelEstadoPag.TabIndex = 5;
            this.labelEstadoPag.Text = "1";
            this.labelEstadoPag.Click += new System.EventHandler(this.labelEstadoPag_Click);
            // 
            // labelNPedido
            // 
            this.labelNPedido.AutoSize = true;
            this.labelNPedido.BackColor = System.Drawing.Color.Transparent;
            this.labelNPedido.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNPedido.Location = new System.Drawing.Point(46, 70);
            this.labelNPedido.Name = "labelNPedido";
            this.labelNPedido.Size = new System.Drawing.Size(281, 36);
            this.labelNPedido.TabIndex = 6;
            this.labelNPedido.Text = "Pedido número: xd";
            // 
            // buttonRetroceder
            // 
            this.buttonRetroceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonRetroceder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetroceder.Location = new System.Drawing.Point(52, 423);
            this.buttonRetroceder.Name = "buttonRetroceder";
            this.buttonRetroceder.Size = new System.Drawing.Size(75, 34);
            this.buttonRetroceder.TabIndex = 7;
            this.buttonRetroceder.Text = "0";
            this.buttonRetroceder.UseVisualStyleBackColor = false;
            this.buttonRetroceder.Visible = false;
            this.buttonRetroceder.Click += new System.EventHandler(this.buttonRetroceder_Click);
            // 
            // buttonAvanzar
            // 
            this.buttonAvanzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonAvanzar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvanzar.Location = new System.Drawing.Point(449, 421);
            this.buttonAvanzar.Name = "buttonAvanzar";
            this.buttonAvanzar.Size = new System.Drawing.Size(75, 34);
            this.buttonAvanzar.TabIndex = 8;
            this.buttonAvanzar.Text = "2";
            this.buttonAvanzar.UseVisualStyleBackColor = false;
            this.buttonAvanzar.Click += new System.EventHandler(this.buttonAvanzar_Click);
            // 
            // buttonFactura
            // 
            this.buttonFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonFactura.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFactura.Location = new System.Drawing.Point(544, 217);
            this.buttonFactura.Name = "buttonFactura";
            this.buttonFactura.Size = new System.Drawing.Size(178, 113);
            this.buttonFactura.TabIndex = 9;
            this.buttonFactura.Text = "Generar Factura";
            this.buttonFactura.UseVisualStyleBackColor = false;
            this.buttonFactura.Click += new System.EventHandler(this.buttonFactura_Click);
            // 
            // buttonSalilr
            // 
            this.buttonSalilr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonSalilr.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalilr.Location = new System.Drawing.Point(654, 444);
            this.buttonSalilr.Name = "buttonSalilr";
            this.buttonSalilr.Size = new System.Drawing.Size(84, 33);
            this.buttonSalilr.TabIndex = 10;
            this.buttonSalilr.Text = "Salir";
            this.buttonSalilr.UseVisualStyleBackColor = false;
            this.buttonSalilr.Click += new System.EventHandler(this.buttonSalilr_Click);
            // 
            // comboBoxNombres
            // 
            this.comboBoxNombres.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNombres.FormattingEnabled = true;
            this.comboBoxNombres.Location = new System.Drawing.Point(544, 116);
            this.comboBoxNombres.Name = "comboBoxNombres";
            this.comboBoxNombres.Size = new System.Drawing.Size(165, 31);
            this.comboBoxNombres.TabIndex = 11;
            this.comboBoxNombres.Visible = false;
            this.comboBoxNombres.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombres_SelectedIndexChanged);
            // 
            // labelPTotal
            // 
            this.labelPTotal.AutoSize = true;
            this.labelPTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelPTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPTotal.Location = new System.Drawing.Point(530, 385);
            this.labelPTotal.Name = "labelPTotal";
            this.labelPTotal.Size = new System.Drawing.Size(201, 25);
            this.labelPTotal.TabIndex = 12;
            this.labelPTotal.Text = "El precio total es: 1";
            // 
            // MisCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 508);
            this.Controls.Add(this.labelPTotal);
            this.Controls.Add(this.comboBoxNombres);
            this.Controls.Add(this.buttonSalilr);
            this.Controls.Add(this.buttonFactura);
            this.Controls.Add(this.buttonAvanzar);
            this.Controls.Add(this.buttonRetroceder);
            this.Controls.Add(this.labelNPedido);
            this.Controls.Add(this.labelEstadoPag);
            this.Controls.Add(this.listViewCompras);
            this.Name = "MisCompras";
            this.Text = "MisCompras";
            this.Controls.SetChildIndex(this.listViewCompras, 0);
            this.Controls.SetChildIndex(this.labelEstadoPag, 0);
            this.Controls.SetChildIndex(this.labelNPedido, 0);
            this.Controls.SetChildIndex(this.buttonRetroceder, 0);
            this.Controls.SetChildIndex(this.buttonAvanzar, 0);
            this.Controls.SetChildIndex(this.buttonFactura, 0);
            this.Controls.SetChildIndex(this.buttonSalilr, 0);
            this.Controls.SetChildIndex(this.comboBoxNombres, 0);
            this.Controls.SetChildIndex(this.labelPTotal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCompras;
        private System.Windows.Forms.Label labelEstadoPag;
        private System.Windows.Forms.Label labelNPedido;
        private System.Windows.Forms.Button buttonRetroceder;
        private System.Windows.Forms.Button buttonAvanzar;
        private System.Windows.Forms.Button buttonFactura;
        private System.Windows.Forms.Button buttonSalilr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox comboBoxNombres;
        private System.Windows.Forms.Label labelPTotal;
    }
}