using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinalPrototipo
{
    public partial class CompraTotal : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        SqlTransaction transaccion;

        void cargarElementos()
        {
            listViewCompra.Items.Clear();
            for (int i = 0; i < Carrito.listaNombres.Count; i++)
            {
                string nombre = Carrito.listaNombres[i];
                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "SELECT nombre, precio FROM productos WHERE nombre = '" + nombre + "'";
                SqlDataReader midatareader = comandosql.ExecuteReader();
                double dato1 = -1;
                string dato2 = "a";
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetDouble(1);
                    dato2 = midatareader.GetString(0);
                }
                midatareader.Close();
                dato2 = dato2.Trim();

                ListViewItem milista = listViewCompra.Items.Add(dato2);
                milista.SubItems.Add(dato1.ToString());
                milista.SubItems.Add(Carrito.listaCantidad[i].ToString());
                milista.SubItems.Add((dato1 * Carrito.listaCantidad[i]).ToString());

                midatareader.Close();
                conexion.Close();
            }

            double acumulador = 0;

            for (int i = 0; i < listViewCompra.Items.Count; i++)
            {
                acumulador += Double.Parse(listViewCompra.Items[i].SubItems[3].Text);
            }
            labeltotalcompra.Text = acumulador.ToString();
        }

        public CompraTotal()
        {
            InitializeComponent();
            cargarElementos();

            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT dni, nombre, apellido1, apellido2, correo FROM usuario WHERE dni ='" + Global.id + "' ";
            
            SqlDataReader midatareader = comandosql.ExecuteReader();
            string dato1 = "-";
            string dato2 = "-";
            string dato3 = "-";
            string dato4 = "-";
            string dato5 = "-";


            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0);
                dato2 = midatareader.GetString(1);
                dato3 = midatareader.GetString(2);
                dato4 = midatareader.GetString(3);
                dato5 = midatareader.GetString(4);


            }
            midatareader.Close();
            dato2 = dato2.Trim();
            conexion.Close();

            labelDNI.Text = dato1;
            labelNombre.Text = dato2;
            labelApellidos.Text = dato3 + dato4;
            labelCorreo.Text = dato5;
        }

        private void buttonGenerarBoleta_Click(object sender, EventArgs e)
        {
           //try
            //{
                conexion.Open();
                comandosql.Connection = conexion;
            transaccion = conexion.BeginTransaction();
            comandosql.Transaction = transaccion;
                
                comandosql.CommandText = "Select max(IdCompra) from compras";
                int Idcompra = -1;
                SqlDataReader midatareader = comandosql.ExecuteReader();
                while (midatareader.Read())
                {
                    Idcompra = midatareader.GetInt32(0);
                }
                midatareader.Close();
                Idcompra++;
                comandosql.CommandText = "INSERT INTO compras (IdCompra, FechaCompra, usuario) VALUES (" + Idcompra + ", '" + System.DateTime.Today.ToString("d")+"', '" + labelNombre.Text+"')";
                comandosql.ExecuteNonQuery();

                for (int i = 0; i < Carrito.listaNombres.Count; i++)
                {

                    comandosql.CommandText = "Select id from productos where nombre = '"+Carrito.listaNombres[i]+"'";
                    int id = -1;
                    midatareader = comandosql.ExecuteReader();
                    while (midatareader.Read())
                    {
                        id = midatareader.GetInt32(0);
                    }
                    midatareader.Close();


                    comandosql.CommandText = "INSERT INTO son (id, idCompra, cantidad) VALUES (" + id + ", " + Idcompra + ",'" + Carrito.listaCantidad[i] + "')";
                    comandosql.ExecuteNonQuery();

                    comandosql.CommandText = "UPDATE productos set Stock = Stock - "+Carrito.listaCantidad[i]+" WHERE nombre = '" + Carrito.listaNombres[i] + "'";
                    comandosql.ExecuteNonQuery();


                }
            transaccion.Commit();
            conexion.Close();




            Carrito.listaNombres.Clear();
            Carrito.listaCantidad.Clear();
            Carrito.listaPrecios.Clear();


            MessageBox.Show("Compra realizada, si desea obtener una factura diríjase a MisCompras");
                Close();


            //}
            
            /*catch
            {
                MessageBox.Show("Ups, algo ha salido mal");
                transaccion.Rollback();
            }*/
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
