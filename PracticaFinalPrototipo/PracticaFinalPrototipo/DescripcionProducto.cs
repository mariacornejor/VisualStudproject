using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinalPrototipo
{
    public partial class DescripcionProducto : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        int stock;
        
        double precio = -1;

        void cargarDescripcion(string nombree)
        {
            try
            {
                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "SELECT nombre, precio, stock FROM productos WHERE nombre = '" + nombree + "'";
                SqlDataReader midatareader = comandosql.ExecuteReader();
                
                double dato1 = -1;
                string dato2 = "a";
                
                int cantidad = -1;

                while (midatareader.Read())
                {
                    dato1 = midatareader.GetDouble(1);
                    dato2 = midatareader.GetString(0);
                    stock = midatareader.GetInt32(2);
                }
                precio = dato1;
                midatareader.Close();
                dato2 = dato2.Trim();
                labelNombre.Text =dato2;
                comboBoxCantidad.Text = comboBoxCantidad.Items[0].ToString();
                cantidad = Int32.Parse(comboBoxCantidad.Text);

                try
                {
                    string path = Path.Combine((Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "images")), dato2 + ".jpg");
                    pictureBox1.Image = Image.FromFile(@path);
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al recuperar la imagen");
                }
            conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            finally
            {
                
            }
        }

        public DescripcionProducto(string nombre)
        {
            InitializeComponent();
            cargarDescripcion(nombre);
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAnnadir_Click(object sender, EventArgs e)
        {
           
            if (stock <= 0 || stock < Int32.Parse(comboBoxCantidad.Text))
            {
                MessageBox.Show("No hay stock suficiente para cubir su pedido");
            }
            else
            {
                if (Global.name != "-1")
                {
                    Carrito.listaNombres.Add(labelNombre.Text);
                    Carrito.listaCantidad.Add(Int32.Parse(comboBoxCantidad.Text));
                    Carrito.listaPrecios.Add(precio);
                    MessageBox.Show("Elemento añadido al carrito correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Debe iniciar sesión antes de poder añadir productos al carrito");
                }
            }

            
        }

        private void comboBoxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPrecio.Text = "Precio: "+precio* Int32.Parse(comboBoxCantidad.Text);
        }
    }

}
