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
    public partial class ModificarProducto : PlantillaBase2
    {

        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        
        public ModificarProducto(string dni)
        {
            InitializeComponent();
            labelProducto.Text = dni;

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int stock;
            double aux;
            if(textBoxPrecio.Text!="" && textBoxStock.Text != "" && Int32.TryParse(textBoxStock.Text,out stock) && double.TryParse(textBoxPrecio.Text, out aux))
            {
                try
                {
                    conexion.Open();
                    comandosql.Connection = conexion;
                    String precioString = textBoxPrecio.Text;
                    precioString = precioString.Replace(",", ".");
                    comandosql.CommandText = "update productos set Stock=" + Int32.Parse(textBoxStock.Text) + " , Precio=" + precioString + " where id = " + Int32.Parse(labelProducto.Text) + "";
                    comandosql.ExecuteNonQuery();
                    
                    
                    Close();
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base datos");
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete los campos correctamente");
            }
            
                
            
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
