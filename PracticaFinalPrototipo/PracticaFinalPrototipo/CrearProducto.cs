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
    public partial class CrearProducto : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        double precioP;
        

        void Cargar(SqlConnection conexion, SqlCommand comandosql)
        {
            
                try
                {
                    listViewIngredientes.Items.Clear();
                    conexion.Open();
                    comandosql.Connection = conexion;
                    comandosql.CommandText = "SELECT nombre, precio FROM productos WHERE tipo = 'Ingrediente'";
                    SqlDataReader midatareader = comandosql.ExecuteReader();
                    string dato1;
                    double dato2;

                    while (midatareader.Read())
                    {
                        dato1 = midatareader.GetString(0);
                        dato2 = midatareader.GetDouble(1);

                        dato1 = dato1.Trim();

                        ListViewItem milista = listViewIngredientes.Items.Add(dato1);
                        milista.SubItems.Add(dato2.ToString());

                    }
                    midatareader.Close();
                    conexion.Close();
                    pictureBoxIngrediente.Image = null;
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                } 
          
            


        }
        void ActualizarPrecioFinal()
        {
            double acumulador = 0;
            
            for (int i = 0; i < listViewListaFinal.Items.Count ; i++)
            {

                acumulador += Double.Parse(listViewListaFinal.Items[i].SubItems[1].Text);
                
            }
            precioP = acumulador;
            labelPFinal.Text = "Precio final: "+acumulador.ToString();
        }

        public CrearProducto()
        {
            InitializeComponent();
            Cargar(conexion, comandosql);

        }

        private void listViewIngredientes_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = listViewIngredientes.SelectedItems[0].SubItems[0].Text;
                nombre = nombre.Trim();
                string path = Path.Combine((Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "images")), nombre + ".jpg");
                
                pictureBoxIngrediente.Image = Image.FromFile(@path);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al recuperar la imagen");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            if (listViewIngredientes.SelectedItems.Count > 0)
            {
                
                string nombre = listViewIngredientes.SelectedItems[0].SubItems[0].Text;
                string precio = listViewIngredientes.SelectedItems[0].SubItems[1].Text;
                bool aux = true;
                for (int i = 0; i < listViewListaFinal.Items.Count; i++)
                {
                    if (listViewListaFinal.Items[i].SubItems[0].Text.Contains(nombre))
                    {
                        aux = false;
                    }
                    
                }
                if (aux)
                {
                    ListViewItem milista = listViewListaFinal.Items.Add(nombre);
                    milista.SubItems.Add(precio);
                    ActualizarPrecioFinal();
                }
                else
                {
                    MessageBox.Show("Ya ha introducido ese elemento");
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista de ingredientes");
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewListaFinal.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecione una fila de la lista de producto final");
            }
            else
            {
                for (int i = listViewListaFinal.SelectedItems.Count - 1; i > -1; i--)
                {
                    listViewListaFinal.Items.Remove(listViewListaFinal.SelectedItems[i]);
                }
            }
        }

        private void buttonTerminar_Click(object sender, EventArgs e)
        {
        if (textBoxNProducto.Text != "")
        {
            try
                {
                    conexion.Open();
                    comandosql.Connection = conexion;
                    comandosql.CommandText = "Select max(id) from productos";
                    int id = -1;
                    SqlDataReader midatareader = comandosql.ExecuteReader();
                    while (midatareader.Read())
                    {
                        id = midatareader.GetInt32(0);
                    }
                    midatareader.Close();

                    String precioString = precioP.ToString();
                    precioString = precioString.Replace(",", ".");
                    precioP = double.Parse(precioString);
                    id++;

                    comandosql.CommandText = "insert into productos (id, nombre, stock, precio, tipo) values(" + id + ", '" + textBoxNProducto.Text + "', " + 1 + "," + precioP + ", '" + "Compuesto" + "')";
                    comandosql.ExecuteNonQuery();

                    for (int i = 0; i < listViewListaFinal.Items.Count; i++)
                    {
                        comandosql.CommandText = "Select id from productos where nombre = '" + listViewListaFinal.Items[i].SubItems[0].Text + "'";
                        int idproducto = -1;
                        midatareader = comandosql.ExecuteReader();
                        while (midatareader.Read())
                        {
                            idproducto = midatareader.GetInt32(0);
                        }
                        midatareader.Close();

                        comandosql.CommandText = "insert into Pfinal (IdPfinal, id) values(" + id + ", " + idproducto + ")";
                        comandosql.ExecuteNonQuery();
                    }

                    Carrito.listaNombres.Add(textBoxNProducto.Text);
                    Carrito.listaCantidad.Add(1);
                    Carrito.listaPrecios.Add(precioP);


                    MessageBox.Show("Producto creado correctamente");
                    Close();


                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                }
                finally
                {
                    conexion.Close();
                }

                }
            else
            {
                MessageBox.Show("Complete el nombre del producto previamente");
            }


        }
    }
}
