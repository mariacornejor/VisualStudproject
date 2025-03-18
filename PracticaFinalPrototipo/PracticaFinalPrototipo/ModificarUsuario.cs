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
    public partial class ModificarUsuario : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();

        public ModificarUsuario(string dni)
        {
            InitializeComponent();
            labelUsuario.Text = dni;

            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "select nombre, apellido1, apellido2, correo from usuario where dni = '"+labelUsuario.Text+"'";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            string nombrea = " ";
            string apellido1a = " ";
            string apellido2a = " ";
            string correoa = " ";

            while (midatareader.Read())
            {
                nombrea = midatareader.GetString(0);
                apellido1a = midatareader.GetString(1);
                apellido2a = midatareader.GetString(2);
                correoa = midatareader.GetString(3);
            }
            conexion.Close();
            textBoxNombre.Text = nombrea;
            textBoxApellido1.Text = apellido1a;
            textBoxApellido2.Text = apellido2a;
            textBoxCorreo.Text = correoa;

            conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxApellido1.Text != "" && textBoxApellido2.Text != "" && textBoxCorreo.Text != "")
            {

                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "update usuario set nombre = '" +textBoxNombre.Text + "' , apellido1 = '"+textBoxApellido1.Text+"', apellido2 = '"+textBoxApellido2.Text+"', correo = '"+textBoxCorreo.Text+"' where dni ='" + labelUsuario.Text + "'";
                comandosql.ExecuteNonQuery();
                Close();
                MessageBox.Show("Datos modificados correctamente.");
            }   
        }
    }

}
