using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinalPrototipo
{
    

    public partial class GestionProductos : PlantillaBase2
    {

        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        SqlTransaction transaccion;


        void Cargar(SqlConnection conexion, SqlCommand comandosql)
        {
            try
            {
                listViewDatosProductos.Items.Clear();
                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "SELECT * FROM productos";
                SqlDataReader midatareader = comandosql.ExecuteReader();
                int dato1;
                string dato2;
                int dato3;
                double dato4;
                string dato5;
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetInt32(0);
                    dato2 = midatareader.GetString(1);
                    dato3 = midatareader.GetInt32(2);
                    dato4 = midatareader.GetDouble(3);
                    dato5 = midatareader.GetString(4);
                    dato2 = dato2.Trim();
                    dato5 = dato5.Trim();
                    ListViewItem milista = listViewDatosProductos.Items.Add(dato1.ToString());
                    milista.SubItems.Add(dato2);
                    milista.SubItems.Add(dato3.ToString());
                    milista.SubItems.Add(dato4.ToString());
                    milista.SubItems.Add(dato5);
                }
                midatareader.Close();
                conexion.Close();
                pictureBoxImagenProducto.Image = null;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
            }
            
        }

        public GestionProductos()
        {
            InitializeComponent();
            Cargar(conexion, comandosql);
            
        }

     
        private void buttonAnnadir_Click(object sender, EventArgs e)
        {
            NuevoProducto ventanaProducto = new NuevoProducto();
            ventanaProducto.ShowDialog();
            Cargar(conexion, comandosql);
        }

        private void listViewDatosProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDatosProductos.SelectedItems[0].SubItems[4].Text.Contains("Compuesto"))
                {
                    buttonCompuesto.Visible = true;
                    string nombre = "Pcompuesto";
                    nombre = nombre.Trim();
                    string path = Path.Combine((Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "images")), nombre + ".jpg");
                    pictureBoxImagenProducto.Image = Image.FromFile(@path);
                }
                else
                {
                    buttonCompuesto.Visible = false;
                    string nombre = listViewDatosProductos.SelectedItems[0].SubItems[1].Text;
                    nombre = nombre.Trim();
                    string path = Path.Combine((Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "images")), nombre + ".jpg");
                    pictureBoxImagenProducto.Image = Image.FromFile(@path);
                }

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al recuperar la imagen");
            }
           
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           
                if (textBoxBuscar.Text!= "")
                {
                    try
                    {
                        listViewDatosProductos.Items.Clear();
                        conexion.Open();
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "SELECT * FROM productos where nombre like '%" + textBoxBuscar.Text + "%'";
                        SqlDataReader midatareader = comandosql.ExecuteReader();
                        int dato1;
                        string dato2 = "a";
                        int dato3;
                        double dato4;
                        string dato5;
                    while (midatareader.Read())
                        {
                            dato1 = midatareader.GetInt32(0);
                            dato2 = midatareader.GetString(1);
                            dato3 = midatareader.GetInt32(2);
                            dato4 = midatareader.GetDouble(3);
                        dato5 = midatareader.GetString(4);
                        dato2 = dato2.Trim();
                        dato5 = dato5.Trim();
                        ListViewItem milista = listViewDatosProductos.Items.Add(dato1.ToString());
                            milista.SubItems.Add(dato2);
                            milista.SubItems.Add(dato3.ToString());
                            milista.SubItems.Add(dato4.ToString());
                        milista.SubItems.Add(dato5);
                    }
                        if (dato2 == "a")
                        {
                            MessageBox.Show("No hay resultados para la palabra: " + textBoxBuscar.Text);
                            
                    }
                        midatareader.Close();
                        conexion.Close();
                    }
                    catch
                    {
                    MessageBox.Show("Ha ocurrido un error, intentelo de nuevo" );
                }
                }
                else
                {
                Cargar(conexion, comandosql);
                }

            textBoxBuscar.Text = "";
            
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if(listViewDatosProductos.SelectedItems.Count<1)
            {
                MessageBox.Show("Seleccione un elemento de la lista");
            }
            else
            {
                try
                {
                    conexion.Open();
                    transaccion = conexion.BeginTransaction();
                    comandosql.Connection = conexion;
                    comandosql.Transaction = transaccion;
                    comandosql.CommandText = "delete from productos where nombre = '" + listViewDatosProductos.SelectedItems[0].SubItems[1].Text + "' ";
                    comandosql.ExecuteNonQuery();
                    transaccion.Commit();
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                    transaccion.Rollback();
                }
                finally
                {
                    conexion.Close();
                    Cargar(conexion, comandosql);
                }
            }

            
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (listViewDatosProductos.SelectedItems.Count < 1)
            {
                MessageBox.Show("Seleccione un elemento de la lista");
            }
            else
            {
                ModificarProducto ventanaModificar = new ModificarProducto(listViewDatosProductos.SelectedItems[0].SubItems[0].Text);
                ventanaModificar.ShowDialog();
                Cargar(conexion, comandosql);
            }

        }

        private void buttonCompuesto_Click(object sender, EventArgs e)
        {
            if (listViewDatosProductos.SelectedItems.Count < 1)
            {

            }
            else
            {
                VerProductoFinal ventanaP = new VerProductoFinal(listViewDatosProductos.SelectedItems[0].SubItems[0].Text);
                ventanaP.ShowDialog();

            }

        }
    }
}
