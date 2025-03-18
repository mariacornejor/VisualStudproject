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
    public partial class Principal : PlantillaBase
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();

         string RecuperarImagenes (string nombre)
        {
            try
            {
                
                nombre = nombre.Trim();
                string path = Path.Combine((Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "images")), nombre + ".jpg");
                return path;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al recuperar la imagen");
                return "-1";
            }
            
        }


        void EstadoBotones()
        {
            if (Int32.Parse(buttonAtras.Text) < 0)
            {
                buttonAtras.Visible = false;
            }
            else
            {
                buttonAtras.Visible = true;
            }

            if (pictureBoxProducto0.Visible == false && pictureBoxProducto1.Visible == false && pictureBoxProducto2.Visible == false && pictureBoxProducto3.Visible == false && pictureBoxProducto4.Visible == false && pictureBoxProducto5.Visible == false && pictureBoxProducto6.Visible == false && pictureBoxProducto7.Visible == false && pictureBoxProducto8.Visible == false && pictureBoxProducto9.Visible == false)
            {
               
                buttonAdelante.Visible = false;

            }
            else
            {
                buttonAdelante.Visible = true;
            }
            

            
        }

        public void RecuperarProductos(int pagina)
        {
            pictureBoxProducto0.Visible = false;
            pictureBoxProducto1.Visible = false;
            pictureBoxProducto2.Visible = false;
            pictureBoxProducto3.Visible = false;
            pictureBoxProducto4.Visible = false;
            pictureBoxProducto5.Visible = false;
            pictureBoxProducto6.Visible = false;
            pictureBoxProducto7.Visible = false;
            pictureBoxProducto8.Visible = false;
            pictureBoxProducto9.Visible = false;

            labelP1.Visible = false;
            labelP2.Visible = false;
            labelP3.Visible = false;
            labelP4.Visible = false;
            labelP5.Visible = false;
            labelP6.Visible = false;
            labelP7.Visible = false;
            labelP8.Visible = false;
            labelP9.Visible = false;
            labelP10.Visible = false;
            try
            {
                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "SELECT nombre FROM productos where tipo = 'final'";
                SqlDataReader midatareader = comandosql.ExecuteReader();
                string dato1 = "a";
                int contador = 0;
                int operacion = 1;
                int resto;
                while (midatareader.Read())
                {
                    operacion = contador / 10;
                    resto = contador % 10;
                    dato1 = midatareader.GetString(0);
                    if ((operacion >= Int32.Parse(labelEstadoPag.Text)) && operacion <= Int32.Parse(buttonAdelante.Text))
                    {
                        string aux;
                        switch (resto)
                        {
                            case 0:
                                aux = RecuperarImagenes(dato1);
                                pictureBoxProducto0.Image = Image.FromFile(@aux);
                                pictureBoxProducto0.Visible = true;
                                labelP1.Text = dato1;
                                labelP1.Visible = true;
                                break;

                            case 1:
                                pictureBoxProducto1.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto1.Visible = true;
                                labelP2.Text = dato1;
                                labelP2.Visible = true;

                                break;

                            case 2:
                                pictureBoxProducto2.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto2.Visible = true;
                                labelP3.Text = dato1;
                                labelP3.Visible = true;
                                break;

                            case 3:
                                pictureBoxProducto3.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto3.Visible = true;
                                labelP4.Text = dato1;
                                labelP4.Visible = true;
                                break;

                            case 4:
                                pictureBoxProducto4.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto4.Visible = true;
                                labelP5.Text = dato1;
                                labelP5.Visible = true;
                                break;

                            case 5:
                                pictureBoxProducto5.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto5.Visible = true;
                                labelP6.Text = dato1;
                                labelP6.Visible = true;
                                break;

                            case 6:
                                pictureBoxProducto6.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto6.Visible = true;
                                labelP7.Text = dato1;
                                labelP7.Visible = true;
                                break;

                            case 7:
                                pictureBoxProducto7.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto7.Visible = true;
                                labelP8.Text = dato1;
                                labelP8.Visible = true;
                                break;

                            case 8:
                                pictureBoxProducto8.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto8.Visible = true;
                                labelP9.Text = dato1;
                                labelP9.Visible = true;
                                break;

                            case 9:
                                pictureBoxProducto9.Image = Image.FromFile(@RecuperarImagenes(dato1));
                                pictureBoxProducto9.Visible = true;
                                labelP10.Text = dato1;
                                labelP10.Visible = true;
                                break;
                            default:
                                break;
                        }
                    }

                    contador++;
                }
                midatareader.Close();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al recuperar las imágenes");
            }
            

            
        }


        public Principal()
        {
            InitializeComponent();
            RecuperarProductos(Int32.Parse(labelEstadoPag.Text));
            EstadoBotones();
            buttonAdelante.Visible = true;
            
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (Global.name != "-1")
            {
                CrearProducto ventanaProducto = new CrearProducto();
                ventanaProducto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Antes de poder utilizar esta funición debe iniciar sesión");
            }

            
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            buttonAtras.Text = (Int32.Parse(buttonAtras.Text) - 1).ToString();
            labelEstadoPag.Text = (Int32.Parse(labelEstadoPag.Text) - 1).ToString();
            buttonAdelante.Text = (Int32.Parse(buttonAdelante.Text) - 1).ToString();
            RecuperarProductos(Int32.Parse(labelEstadoPag.Text));
            EstadoBotones();
        }

        private void buttonAdelante_Click(object sender, EventArgs e)
        {
            labelEstadoPag.Text = (Int32.Parse(labelEstadoPag.Text) + 1).ToString();
            buttonAtras.Text = (Int32.Parse(buttonAtras.Text) + 1).ToString();
            buttonAdelante.Text = (Int32.Parse(buttonAdelante.Text) + 1).ToString();
            RecuperarProductos(Int32.Parse(labelEstadoPag.Text));
            EstadoBotones();
        }

        private void pictureBoxProducto0_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP1.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto1_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP2.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto2_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP3.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto3_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP4.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto4_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP5.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto5_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP6.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto6_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP7.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto7_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP8.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto8_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP9.Text);
            ventanaProducto.ShowDialog();
        }

        private void pictureBoxProducto9_Click(object sender, EventArgs e)
        {
            DescripcionProducto ventanaProducto = new DescripcionProducto(labelP10.Text);
            ventanaProducto.ShowDialog();
        }

        private void buttonGestionProductos_Click(object sender, EventArgs e)
        {
            RecuperarProductos(Int32.Parse(labelEstadoPag.Text));
        }
    }
}
