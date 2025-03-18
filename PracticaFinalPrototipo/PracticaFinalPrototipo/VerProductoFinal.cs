using System;
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
    public partial class VerProductoFinal : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();


        public void cargarInformacion(int idP)
        {
            
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "Select id from Pfinal where idPfinal = "+idP+"";
            string id = "a";
            List<string> ids = new List<string>();
            SqlDataReader midatareader = comandosql.ExecuteReader();
            while (midatareader.Read())
            {
                id = midatareader.GetString(0);
                ids.Add(id) ;
            }
            midatareader.Close();

            foreach(string p in ids)
            {
                comandosql.CommandText = "Select nombre, precio from productos where id = " + p + "";
                string nombre = "a";
                double precio = -1;
                midatareader = comandosql.ExecuteReader();
                while (midatareader.Read())
                {
                    nombre = midatareader.GetString(0);
                    precio = midatareader.GetDouble(1);
                    nombre = nombre.Trim();
                    ListViewItem milista = listView1.Items.Add(p);
                    milista.SubItems.Add(nombre);
                    milista.SubItems.Add(precio.ToString());

                }
                midatareader.Close();
            }


            conexion.Close();
        }




        public VerProductoFinal(string idProducto)
        {
            InitializeComponent();
            cargarInformacion(Int32.Parse(idProducto));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
