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
    public partial class MiCuenta : PlantillaBase2
    {

        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        public MiCuenta()
        {
            InitializeComponent();

            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT dni, nombre, apellido1, apellido2, correo FROM usuario WHERE dni ='" + Global.id + "' ";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            string dato1 = "a";
            string dato2 = "a";
            string dato3 = "a";
            string dato4 = "a";
            string dato5 = "a";
            

            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0); 
                dato2 = midatareader.GetString(1);
                dato3 = midatareader.GetString(2);
                dato4 = midatareader.GetString(3);
                dato5 = midatareader.GetString(4);
                

            }
            midatareader.Close();
            conexion.Close();
            dato1 = dato1.Trim();
            dato2 = dato2.Trim();
            dato3 = dato3.Trim();
            dato4 = dato4.Trim();
            dato5 = dato5.Trim();
            labelDNI.Text = dato1;
            labelNombre.Text = dato2;
            labelApellidos.Text = dato3+" "+dato4;
            labelCorreo.Text = dato5;
             
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            MisCompras ventanacompras = new MisCompras(labelNombre.Text);
            ventanacompras.ShowDialog();
        }
    }
}
