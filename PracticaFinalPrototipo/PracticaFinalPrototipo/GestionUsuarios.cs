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
    

    public partial class GestionUsuarios : PlantillaBase2
    {

        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        SqlTransaction transaccion;

        void Cargar(SqlConnection conexion, SqlCommand comandosql)
        {
            listViewDatosUsuarios.Items.Clear();
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT * FROM usuario";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            string dato1;
            string dato2 = "a";
            string dato3;
            string dato4;
            string dato5;
            string dato6;
            string datoaux;
            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0);
                dato2 = midatareader.GetString(1);
                dato3 = midatareader.GetString(2);
                dato4 = midatareader.GetString(3);
                dato5 = midatareader.GetString(4);
                dato6 = midatareader.GetString(5);
                dato1 = dato1.Trim();
                dato2 = dato2.Trim();
                dato3 = dato3.Trim();
                dato4 = dato4.Trim();
                dato5 = dato5.Trim();
                dato6 = dato6.Trim();
                datoaux = dato3 + " " + dato4;

                ListViewItem milista = listViewDatosUsuarios.Items.Add(dato1);
                milista.SubItems.Add(dato2);
                milista.SubItems.Add(datoaux);
                milista.SubItems.Add(dato5);
                milista.SubItems.Add(dato6);


            }
            midatareader.Close();
            conexion.Close();
        }

        public GestionUsuarios()
        {
            InitializeComponent();
            Cargar(conexion, comandosql);
            
        }

     
        private void buttonAnnadir_Click(object sender, EventArgs e)
        {
            Registro ventanaUsuario = new Registro();
            ventanaUsuario.ShowDialog();
            Cargar(conexion, comandosql);
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           
                if (textBoxBuscar.Text!= "")
                {
                    try
                    {
                        listViewDatosUsuarios.Items.Clear();
                        conexion.Open();
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "SELECT * FROM usuario where dni like '%" + textBoxBuscar.Text + "%'";
                        SqlDataReader midatareader = comandosql.ExecuteReader();
                        string dato1;
                        string dato2 = "a";
                        string dato3;
                        string dato4;
                        string dato5;
                        string dato6;
                        string datoaux;
                        while (midatareader.Read())
                        {
                            dato1 = midatareader.GetString(0);
                            dato2 = midatareader.GetString(1);
                            dato3 = midatareader.GetString(2);
                            dato4 = midatareader.GetString(3);
                            dato5 = midatareader.GetString(4);
                            dato6 = midatareader.GetString(5);
                            dato3 = dato3.Trim();
                            datoaux = dato3 + " " + dato4;

                            ListViewItem milista = listViewDatosUsuarios.Items.Add(dato1);
                            milista.SubItems.Add(dato2);
                            milista.SubItems.Add(datoaux);
                            milista.SubItems.Add(dato5);
                            milista.SubItems.Add(dato6);
                        }
                        if (dato2 == "a")
                            {
                                MessageBox.Show("No hay resultados para la palabra: " + textBoxBuscar.Text);
                            }
                        midatareader.Close();
                    }
                    catch
                    {
                    MessageBox.Show("Ha ocurrido un error, intentelo de nuevo" );
                }
                finally
                {
                    conexion.Close();
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
            if (listViewDatosUsuarios.SelectedItems.Count < 1)
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
                    comandosql.CommandText = "delete from usuario where nombre = '" + listViewDatosUsuarios.SelectedItems[0].SubItems[1].Text + "' ";
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
            if (listViewDatosUsuarios.SelectedItems.Count < 1)
            {
                MessageBox.Show("Seleccione un elemento de la lista");
            }
            else
            {
                ModificarUsuario ventanaModificar = new ModificarUsuario(listViewDatosUsuarios.SelectedItems[0].SubItems[0].Text);
                ventanaModificar.ShowDialog();
                Cargar(conexion, comandosql);
            }
        }
    }
}
