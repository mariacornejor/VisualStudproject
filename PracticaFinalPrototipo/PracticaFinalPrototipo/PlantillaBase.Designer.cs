
namespace PracticaFinalPrototipo
{
    partial class PlantillaBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantillaBase));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.botonRestablecer = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.botonMaximizar = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxCarrito = new System.Windows.Forms.PictureBox();
            this.labelIdemAdmin = new System.Windows.Forms.Label();
            this.buttonGestionProductos = new System.Windows.Forms.Button();
            this.buttonGestionClientes = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonMicuenta = new System.Windows.Forms.Button();
            this.buttonSalirCuenta = new System.Windows.Forms.Button();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestablecer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(173)))), ((int)(((byte)(156)))));
            this.BarraSuperior.Controls.Add(this.botonRestablecer);
            this.BarraSuperior.Controls.Add(this.botonCerrar);
            this.BarraSuperior.Controls.Add(this.botonMaximizar);
            this.BarraSuperior.Controls.Add(this.botonMinimizar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1920, 49);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // botonRestablecer
            // 
            this.botonRestablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRestablecer.Image = ((System.Drawing.Image)(resources.GetObject("botonRestablecer.Image")));
            this.botonRestablecer.Location = new System.Drawing.Point(1822, 1);
            this.botonRestablecer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonRestablecer.Name = "botonRestablecer";
            this.botonRestablecer.Size = new System.Drawing.Size(52, 48);
            this.botonRestablecer.TabIndex = 4;
            this.botonRestablecer.TabStop = false;
            this.botonRestablecer.Click += new System.EventHandler(this.botonRestablecer_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(1881, 4);
            this.botonCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(35, 39);
            this.botonCerrar.TabIndex = 2;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonMaximizar
            // 
            this.botonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMaximizar.Image")));
            this.botonMaximizar.Location = new System.Drawing.Point(1831, 2);
            this.botonMaximizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonMaximizar.Name = "botonMaximizar";
            this.botonMaximizar.Size = new System.Drawing.Size(43, 47);
            this.botonMaximizar.TabIndex = 3;
            this.botonMaximizar.TabStop = false;
            this.botonMaximizar.Click += new System.EventHandler(this.botonMaximizar_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(1766, 0);
            this.botonMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(49, 58);
            this.botonMinimizar.TabIndex = 2;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.Controls.Add(this.pictureBoxCarrito);
            this.panelMenu.Controls.Add(this.labelIdemAdmin);
            this.panelMenu.Controls.Add(this.buttonGestionProductos);
            this.panelMenu.Controls.Add(this.buttonGestionClientes);
            this.panelMenu.Controls.Add(this.labelNombre);
            this.panelMenu.Controls.Add(this.buttonMicuenta);
            this.panelMenu.Controls.Add(this.buttonSalirCuenta);
            this.panelMenu.Controls.Add(this.pictureBoxUsuario);
            this.panelMenu.Controls.Add(this.buttonIniciarSesion);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 49);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1920, 92);
            this.panelMenu.TabIndex = 1;
            // 
            // pictureBoxCarrito
            // 
            this.pictureBoxCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBoxCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarrito.Image")));
            this.pictureBoxCarrito.Location = new System.Drawing.Point(1638, 15);
            this.pictureBoxCarrito.Name = "pictureBoxCarrito";
            this.pictureBoxCarrito.Size = new System.Drawing.Size(61, 55);
            this.pictureBoxCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarrito.TabIndex = 9;
            this.pictureBoxCarrito.TabStop = false;
            this.pictureBoxCarrito.Visible = false;
            this.pictureBoxCarrito.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelIdemAdmin
            // 
            this.labelIdemAdmin.AutoSize = true;
            this.labelIdemAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdemAdmin.Location = new System.Drawing.Point(3, 48);
            this.labelIdemAdmin.Name = "labelIdemAdmin";
            this.labelIdemAdmin.Size = new System.Drawing.Size(15, 23);
            this.labelIdemAdmin.TabIndex = 8;
            this.labelIdemAdmin.Text = "l";
            this.labelIdemAdmin.Visible = false;
            // 
            // buttonGestionProductos
            // 
            this.buttonGestionProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonGestionProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonGestionProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGestionProductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonGestionProductos.Location = new System.Drawing.Point(1348, 48);
            this.buttonGestionProductos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGestionProductos.Name = "buttonGestionProductos";
            this.buttonGestionProductos.Size = new System.Drawing.Size(236, 38);
            this.buttonGestionProductos.TabIndex = 7;
            this.buttonGestionProductos.Text = "Gestionar Productos";
            this.buttonGestionProductos.UseVisualStyleBackColor = false;
            this.buttonGestionProductos.Visible = false;
            this.buttonGestionProductos.Click += new System.EventHandler(this.buttonGestionProductos_Click);
            // 
            // buttonGestionClientes
            // 
            this.buttonGestionClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonGestionClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonGestionClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGestionClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonGestionClientes.Location = new System.Drawing.Point(1348, 4);
            this.buttonGestionClientes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGestionClientes.Name = "buttonGestionClientes";
            this.buttonGestionClientes.Size = new System.Drawing.Size(236, 39);
            this.buttonGestionClientes.TabIndex = 6;
            this.buttonGestionClientes.Text = "Gestionar Usuarios";
            this.buttonGestionClientes.UseVisualStyleBackColor = false;
            this.buttonGestionClientes.Visible = false;
            this.buttonGestionClientes.Click += new System.EventHandler(this.buttonGestionClientes_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(3, 4);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(263, 23);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Has iniciado sesión como: -";
            this.labelNombre.Visible = false;
            // 
            // buttonMicuenta
            // 
            this.buttonMicuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMicuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonMicuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMicuenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMicuenta.Location = new System.Drawing.Point(1734, 54);
            this.buttonMicuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMicuenta.Name = "buttonMicuenta";
            this.buttonMicuenta.Size = new System.Drawing.Size(99, 28);
            this.buttonMicuenta.TabIndex = 2;
            this.buttonMicuenta.Text = "MiCuenta";
            this.buttonMicuenta.UseVisualStyleBackColor = false;
            this.buttonMicuenta.Visible = false;
            this.buttonMicuenta.Click += new System.EventHandler(this.buttonMicuenta_Click);
            // 
            // buttonSalirCuenta
            // 
            this.buttonSalirCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalirCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonSalirCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalirCuenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalirCuenta.Location = new System.Drawing.Point(1734, 7);
            this.buttonSalirCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalirCuenta.Name = "buttonSalirCuenta";
            this.buttonSalirCuenta.Size = new System.Drawing.Size(100, 28);
            this.buttonSalirCuenta.TabIndex = 3;
            this.buttonSalirCuenta.Text = "Salir";
            this.buttonSalirCuenta.UseVisualStyleBackColor = false;
            this.buttonSalirCuenta.Visible = false;
            this.buttonSalirCuenta.Click += new System.EventHandler(this.buttonSalirCuenta_Click);
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(1844, 13);
            this.pictureBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(76, 79);
            this.pictureBoxUsuario.TabIndex = 2;
            this.pictureBoxUsuario.TabStop = false;
            this.pictureBoxUsuario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSesion.Location = new System.Drawing.Point(1746, 16);
            this.buttonIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(87, 54);
            this.buttonIniciarSesion.TabIndex = 2;
            this.buttonIniciarSesion.Text = "Iniciar Sesión";
            this.buttonIniciarSesion.UseVisualStyleBackColor = false;
            this.buttonIniciarSesion.Visible = false;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // PlantillaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.BarraSuperior);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlantillaBase";
            this.Text = "PlantillaBase";
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonRestablecer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.PictureBox botonRestablecer;
        private System.Windows.Forms.PictureBox botonMaximizar;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelIdemAdmin;
        public System.Windows.Forms.Button buttonMicuenta;
        public System.Windows.Forms.Button buttonSalirCuenta;
        public System.Windows.Forms.Button buttonIniciarSesion;
        public System.Windows.Forms.PictureBox pictureBoxUsuario;
        public System.Windows.Forms.Button buttonGestionProductos;
        public System.Windows.Forms.Button buttonGestionClientes;
        public System.Windows.Forms.PictureBox pictureBoxCarrito;
    }
}