using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinalPrototipo
{
    public partial class RecuperarContra : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        string usuario = "cgarcia134@alu.ucam.edu";
        string contra = "Hermana1ymadre12$";

        public void EnviarCorreo(StringBuilder Mensaje, DateTime fechaenvio, string de, string para, string asunto, out string error)
        {
            error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("\nEste correo ha sido enviado el dia {0:dd/MM/yyyy} a las {0:HH:mm:ss}", fechaenvio));
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(de);
                mail.To.Add(para);
                mail.Subject = asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(usuario, contra);
                smtp.EnableSsl = true;
                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                error = "error: " + ex.Message;

            }

        }
        public RecuperarContra()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEnviarCorreo_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
               try
                {
                    conexion.Open();
                    comandosql.Connection = conexion;
                    comandosql.CommandText = "Select contra, correo from usuario where dni = '" + textBox1.Text + "'";
                    SqlDataReader midatareader = comandosql.ExecuteReader();
                    string contra = "a";
                    string correo = "a";
                    while (midatareader.Read())
                    {
                        contra = midatareader.GetString(0);
                        correo = midatareader.GetString(1);

                    }
                midatareader.Close();
                    if (contra != "a")
                    {
                        string error;
                        StringBuilder Mensaje = new StringBuilder();
                        Mensaje.Append("La contraseña del usuario con DNI: " + textBox1.Text + " Es: " + contra);
                        EnviarCorreo(Mensaje, DateTime.Now, "1024Pasteles@tarta.es", correo, "RECUPERACION CONTRASEÑA", out error);
                        MessageBox.Show("Correo de recuperacion enviado correctamente");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No hay ningun usuario con ese DNI");
                        textBox1.Text = "";
                    }
                    

                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un erro al conectar con la base de datos");
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete el campo");
            }
            
            




            


        }
    }
}
