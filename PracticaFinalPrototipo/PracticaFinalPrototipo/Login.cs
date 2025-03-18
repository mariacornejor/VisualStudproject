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
    public partial class Login : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
       
        public Login()
        {
            InitializeComponent();
        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            Registro ventanaRegistro = new Registro();
            ventanaRegistro.ShowDialog();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text!="" && textBoxUser.Text != "")
            {
                //Recuperamos de la base de datos las coincidencias respecto a los datos introducidos
                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "Select dni from usuario where dni ='" + textBoxUser.Text + "' ";
                SqlDataReader midatareader = comandosql.ExecuteReader();
                string dato1 = "a";
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetString(0);
                }
                conexion.Close();


                conexion.Open();
                comandosql.CommandText = "Select contra from usuario where dni ='" + textBoxUser.Text + "' ";
                SqlDataReader midatareader2 = comandosql.ExecuteReader();

                string dato2 = "a";
                while (midatareader2.Read())
                {
                    dato2 = midatareader2.GetString(0);
                }
                conexion.Close();


                //Compramos las coincidencias con los datos colocados
                if ((dato1.Contains(textBoxUser.Text)) && (dato2.Contains(textBoxPassword.Text)))
                {
                    conexion.Open();
                    comandosql.CommandText = "Select nombre from usuario where dni ='" + textBoxUser.Text + "' ";
                    SqlDataReader midatareader3 = comandosql.ExecuteReader();

                    string dato3 = "a";
                    while (midatareader3.Read())
                    {
                        dato3 = midatareader3.GetString(0);
                    }
                    conexion.Close();

                    conexion.Open();
                    comandosql.CommandText = "Select rol from usuario where dni ='" + textBoxUser.Text + "' ";
                    SqlDataReader midatareader4 = comandosql.ExecuteReader();

                    string dato4 = "a";
                    while (midatareader4.Read())
                    {
                        dato4 = midatareader4.GetString(0);
                    }
                    conexion.Close();

                    Global.rol = dato4;
                    Global.name = dato3;
                    Global.id = textBoxUser.Text;
                    MessageBox.Show("Se ha loggeado correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, intentelo nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos correctamente");
            }


            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RecuperarContra ventanaRecuperar = new RecuperarContra();
            ventanaRecuperar.ShowDialog();
        }
    }
}
