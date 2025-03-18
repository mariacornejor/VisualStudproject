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
    public partial class Registro : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        SqlTransaction transaccion;
        public Registro()
        {
            InitializeComponent();
        }

        private void radioButtonAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAdministrador.Checked == true)
            {
                MessageBox.Show("Introduzca la clave");
                textBox1ContraAdmin.Text = "";
                textBox1ContraAdmin.Visible = true;
            }
        }

        private void radioButtonCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCliente.Checked == true)
            {
                textBox1ContraAdmin.Visible = false;
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        { 
            if (textBoxApellido2.Text == " " || textBoxApellido1.Text == " " || textBoxContra.Text == " " || textBoxCorreo.Text == " " || textBoxNombre.Text == "" || textBoxDNI.Text == " ")
            {
                MessageBox.Show("Complete los campos correctamente");
            }
            else
            {
                if ((radioButtonAdministrador.Checked == true && textBox1ContraAdmin.Text == Global.contraAdmin)||(radioButtonCliente.Checked==true))
                {

                    try
                    {
                        conexion.Open();
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "Select dni from usuario where dni ='" + textBoxDNI.Text + "'";
                        SqlDataReader midatareader = comandosql.ExecuteReader();
                        string dato1 = "a";
                        while (midatareader.Read())
                        {
                            dato1 = midatareader.GetString(0);
                        }
                        midatareader.Close();
                        conexion.Close();

                        if (dato1 == "a")
                        {
                            try
                            {
                                string rol = "";
                                if (radioButtonAdministrador.Checked == true)
                                {
                                    rol = radioButtonAdministrador.Text;
                                }
                                else
                                {
                                    rol = radioButtonCliente.Text;
                                }
                                conexion.Open();
                                transaccion = conexion.BeginTransaction();
                                comandosql.Connection = conexion;
                                comandosql.Transaction = transaccion;
                                
                                comandosql.CommandText = "insert into usuario (dni, nombre, apellido1, apellido2, rol, correo, contra) values('" + textBoxDNI.Text + "', '" + textBoxNombre.Text + "', '" + textBoxApellido1.Text + "', '" + textBoxApellido2.Text + "', '" + rol + "', '" + textBoxCorreo.Text + "', '" + textBoxContra.Text + "')";
                                comandosql.ExecuteNonQuery();
                                transaccion.Commit();
                                MessageBox.Show("Usuario Creado");
                                Close();
                            }
                            catch
                            {
                                MessageBox.Show("Complete los campos correctamente error en insercion");
                                transaccion.Rollback();

                            }
                            finally
                            {
                                conexion.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ya hay un usuario registrado con DNI: " + textBoxDNI.Text);
                            textBoxApellido1.Text = "";
                            textBoxApellido2.Text = "";
                            textBoxContra.Text = "";
                            textBoxCorreo.Text = "";
                            textBoxDNI.Text = "";
                            textBoxNombre.Text = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Complete los campos correctamentelil");
                        conexion.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña del administrador incorrecta");
                }
            }
        }
    }
}
