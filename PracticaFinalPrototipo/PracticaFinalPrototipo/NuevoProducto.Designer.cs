
namespace PracticaFinalPrototipo
{
    partial class NuevoProducto
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonFinal = new System.Windows.Forms.RadioButton();
            this.radioButtonIngrediente = new System.Windows.Forms.RadioButton();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(65, 98);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(323, 28);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(66, 237);
            this.textBoxPrecio.Multiline = true;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(322, 28);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(65, 165);
            this.textBoxStock.Multiline = true;
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(323, 28);
            this.textBoxStock.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(61, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(61, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonCrear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(66, 448);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(652, 36);
            this.buttonCrear.TabIndex = 11;
            this.buttonCrear.Text = "Crear Producto";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.Location = new System.Drawing.Point(462, 360);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(256, 37);
            this.buttonCargar.TabIndex = 12;
            this.buttonCargar.Text = "Cargar imagen";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(62, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de producto";
            // 
            // radioButtonFinal
            // 
            this.radioButtonFinal.AutoSize = true;
            this.radioButtonFinal.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFinal.Checked = true;
            this.radioButtonFinal.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.radioButtonFinal.Location = new System.Drawing.Point(66, 345);
            this.radioButtonFinal.Name = "radioButtonFinal";
            this.radioButtonFinal.Size = new System.Drawing.Size(73, 27);
            this.radioButtonFinal.TabIndex = 14;
            this.radioButtonFinal.TabStop = true;
            this.radioButtonFinal.Text = "Final";
            this.radioButtonFinal.UseVisualStyleBackColor = false;
            // 
            // radioButtonIngrediente
            // 
            this.radioButtonIngrediente.AutoSize = true;
            this.radioButtonIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonIngrediente.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.radioButtonIngrediente.Location = new System.Drawing.Point(293, 345);
            this.radioButtonIngrediente.Name = "radioButtonIngrediente";
            this.radioButtonIngrediente.Size = new System.Drawing.Size(140, 27);
            this.radioButtonIngrediente.TabIndex = 15;
            this.radioButtonIngrediente.Text = "Ingrediente";
            this.radioButtonIngrediente.UseVisualStyleBackColor = false;
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImagen.Location = new System.Drawing.Point(466, 63);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(248, 291);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 16;
            this.pictureBoxImagen.TabStop = false;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 542);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.radioButtonIngrediente);
            this.Controls.Add(this.radioButtonFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxNombre);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "NuevoProducto";
            this.Text = "NuevoProducto";
            this.Controls.SetChildIndex(this.textBoxNombre, 0);
            this.Controls.SetChildIndex(this.textBoxPrecio, 0);
            this.Controls.SetChildIndex(this.textBoxStock, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.buttonCrear, 0);
            this.Controls.SetChildIndex(this.buttonCargar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.radioButtonFinal, 0);
            this.Controls.SetChildIndex(this.radioButtonIngrediente, 0);
            this.Controls.SetChildIndex(this.pictureBoxImagen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonFinal;
        private System.Windows.Forms.RadioButton radioButtonIngrediente;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
    }
}