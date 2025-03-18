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
    public partial class NuevoProducto : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        SqlTransaction transaccion;
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            int sstock;
            double aux;
            if (textBoxNombre.Text != " " && textBoxPrecio.Text != " " && textBoxStock.Text != " " && pictureBoxImagen.Image != null && Int32.TryParse(textBoxStock.Text, out sstock) && double.TryParse(textBoxPrecio.Text, out aux))
            {
                try
                {
                    conexion.Open();
                    comandosql.Connection = conexion;
                    comandosql.CommandText = "Select nombre from productos where nombre ='" + textBoxNombre.Text + "'";
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
                        conexion.Open();
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "Select max(id) from productos";
                        int id = -1;
                        midatareader = comandosql.ExecuteReader();
                        while (midatareader.Read())
                        {
                            id = midatareader.GetInt32(0);
                        }
                        midatareader.Close();
                        conexion.Close();



                        conexion.Open();
                        transaccion = conexion.BeginTransaction();
                        comandosql.Connection = conexion;
                        comandosql.Transaction = transaccion;


                        string tipo;
                        if (radioButtonFinal.Checked == true)
                        {
                            tipo = radioButtonFinal.Text;
                        }
                        else
                        {
                            tipo = radioButtonIngrediente.Text;
                        }
                        id = id + 1;
                        String precioString = textBoxPrecio.Text;
                        precioString = precioString.Replace(",", ".");
                        double precio = double.Parse(precioString);

                        int stock = Int32.Parse(textBoxStock.Text);



                        comandosql.CommandText = "insert into productos (id, nombre, stock, precio, tipo) values(" + id + ", '" + textBoxNombre.Text + "', " + stock + "," + precioString + ", '" +tipo + "')";
                        comandosql.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Producto Creado");
                        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "images/" + textBoxNombre.Text + ".jpg");                       
                        pictureBoxImagen.Image.Save(path);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Un producto con ese nombre ya ha sido registrado");
                    }
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                }
                   
               
            }
            else
            {
                MessageBox.Show("Complete todos los campos correctamente");
            }     
        }
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdfoto = new OpenFileDialog();
            ofdfoto.Filter = "Imagen JPG(*.jpg) | *.jpg";
            ofdfoto.Title = "Inserte una imagen JPG";
            if (ofdfoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagen.Image = Image.FromFile(ofdfoto.FileName);
            }

        }
    }
}
