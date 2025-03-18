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
    public partial class CarritoCompra : PlantillaBase2
    {

        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();

        void cargarElementos()
        {
            listViewCarritoCompras.Items.Clear();
            for(int i=0; i<Carrito.listaNombres.Count; i++)
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

                ListViewItem milista = listViewCarritoCompras.Items.Add(dato2);
                milista.SubItems.Add(dato1.ToString());
                milista.SubItems.Add(Carrito.listaCantidad[i].ToString());
                milista.SubItems.Add((dato1 * Carrito.listaCantidad[i]).ToString());

                midatareader.Close();
                conexion.Close();
            }

            double acumulador = 0;

            for (int i = 0; i < listViewCarritoCompras.Items.Count; i++)
            {
                acumulador += Double.Parse(listViewCarritoCompras.Items[i].SubItems[3].Text);
            }
            labeltotalcompra.Text = acumulador.ToString();
        }

        public CarritoCompra()
        {
            InitializeComponent();
            cargarElementos();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (listViewCarritoCompras.SelectedItems.Count > 0)
            {
                Carrito.listaNombres.Remove(listViewCarritoCompras.SelectedItems[0].SubItems[0].Text);
                cargarElementos();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista");
            }
        }

        private void buttonProcesarCompra_Click(object sender, EventArgs e)
        {
            CompraTotal ventanaCompra = new CompraTotal();
            ventanaCompra.ShowDialog();
            Close();
        }
    }

}
