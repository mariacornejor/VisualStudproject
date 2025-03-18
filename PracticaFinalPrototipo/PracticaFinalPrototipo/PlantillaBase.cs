using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PracticaFinalPrototipo
{
    public partial class PlantillaBase : Form
    {
        public PlantillaBase()
        {
            InitializeComponent();
            
            botonRestablecer.Visible = false;
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonRestablecer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            botonRestablecer.Visible = false;
            botonMaximizar.Visible = true;
        }

        private void botonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            botonRestablecer.Visible = true;
            botonMaximizar.Visible = false;
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Global.name == "1")
            {
                buttonMicuenta.Visible = true;
                buttonSalirCuenta.Visible = true;
            }
            else
            {
                buttonIniciarSesion.Visible = true;
            }
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            Login ventanaLogin = new Login();
            ventanaLogin.ShowDialog();
            
            if (Global.id != "-1")
            {
                if(Global.rol.Contains("Administrador"))
                {
                    labelIdemAdmin.Text = Global.rol;
                    labelIdemAdmin.Visible = true;
                    buttonGestionClientes.Visible = true;
                    buttonGestionProductos.Visible = true;
                }

                labelNombre.Text = "Has iniciado sesión como: "+Global.name;
                labelNombre.Visible = true;
                buttonIniciarSesion.Visible = false;
                buttonMicuenta.Visible = true;
                buttonSalirCuenta.Visible = true;
                pictureBoxCarrito.Visible = true;
            }

        }

        private void buttonSalirCuenta_Click(object sender, EventArgs e)
        {
            buttonIniciarSesion.Visible = true;
            buttonMicuenta.Visible = false;
            buttonSalirCuenta.Visible = false;
            labelNombre.Visible = false;
            labelIdemAdmin.Visible = false;
            pictureBoxCarrito.Visible = false;
            buttonGestionClientes.Visible = false;
            buttonGestionProductos.Visible = false;

            Carrito.listaCantidad.Clear();
            Carrito.listaNombres.Clear();
            Global.id = "-1";
            Global.name = "-1";
            Global.rol = "-1";
        }

        private void buttonMicuenta_Click(object sender, EventArgs e)
        {
            MiCuenta ventanaCuenta = new MiCuenta();
            ventanaCuenta.ShowDialog();
        }

        private void buttonGestionProductos_Click(object sender, EventArgs e)
        {
            GestionProductos ventanaProductos = new GestionProductos();
            ventanaProductos.ShowDialog();
            
        }

        private void buttonGestionClientes_Click(object sender, EventArgs e)
        {
            GestionUsuarios usuarios = new GestionUsuarios();
            usuarios.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if (Global.name == "1")
            //{
                CarritoCompra ventanaCarrito = new CarritoCompra();
                ventanaCarrito.ShowDialog();
            //}
        }
    }
}
