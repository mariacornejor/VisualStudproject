using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PracticaFinalPrototipo
{
    public partial class MisCompras : PlantillaBase2
    {
        SqlConnection conexion = new SqlConnection(Global.CadenaDeConexion);
        SqlCommand comandosql = new SqlCommand();
        SqlCommand comandosql2 = new SqlCommand();
        
        String nombreG;
        
        List<String> aux = new List<string>();


        void EstadoBotones()
        {
            if (Int32.Parse(buttonRetroceder.Text) < 1)
            {
                buttonRetroceder.Visible = false;
            }
            else
            {
                buttonRetroceder.Visible = true;
            }

            if (Int32.Parse(labelEstadoPag.Text) + 1 > aux.Count())
            {

                buttonAvanzar.Visible = false;

            }
            else
            {
                buttonAvanzar.Visible = true;
            }



        }
        void cargarTabla()
        {
            string nombre = comboBoxNombres.Text;
            nombreG = nombre;
            List<String> nombresAux = new List<string>();
            List<int> idAux = new List<int>();
            List<double> precioAux = new List<double>();
            List<int> cantidadAux = new List<int>();
            listViewCompras.Items.Clear();
            aux.Clear();
            conexion.Open();
            comandosql.Connection = conexion;





            comandosql.CommandText = "SELECT FechaCompra, IdCompra FROM compras WHERE usuario ='" + nombre + "'";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            string fecha;
            string fechaAux;
            int idCompra = -1;
            int contador = 1;

            while (midatareader.Read())
            {
                fechaAux = midatareader.GetString(0);
                aux.Add(fechaAux);
                if (contador == Int32.Parse(labelEstadoPag.Text))
                {
                    fecha = midatareader.GetString(0);
                    idCompra = midatareader.GetInt32(1);
                    labelNPedido.Text = "El pedido numero: " + idCompra.ToString() + " de la fecha: " + fecha;
                }

                contador++;
            }
            midatareader.Close();

            int id;
            int cantidad;
            comandosql.CommandText = "SELECT id, cantidad FROM son WHERE idCompra =" + idCompra + "";
            midatareader = comandosql.ExecuteReader();
            while (midatareader.Read())
            {
                id = midatareader.GetInt32(0);
                idAux.Add(id);

                cantidad = midatareader.GetInt32(1);
                cantidadAux.Add(cantidad);
            }
            midatareader.Close();

            for (int i = 0; i < idAux.Count; i++)
            {
                comandosql.CommandText = "SELECT nombre, precio FROM productos WHERE id =" + idAux[i] + "";
                midatareader = comandosql.ExecuteReader();
                string nombreP;
                double precioP;
                while (midatareader.Read())
                {
                    nombreP = midatareader.GetString(0);
                    precioP = midatareader.GetDouble(1);
                    nombreP = nombreP.Trim();

                    nombresAux.Add(nombreP);
                    precioAux.Add(precioP);

                }
                midatareader.Close();
            }
           

            conexion.Close();



            for (int i = 0; i < nombresAux.Count; i++)
            {
                ListViewItem milista = listViewCompras.Items.Add(nombresAux[i]);
                milista.SubItems.Add(cantidadAux[i].ToString());
                milista.SubItems.Add(precioAux[i].ToString());
            }

            double acumulador = 0;
            for (int i = 0; i < listViewCompras.Items.Count; i++)
            {
                 acumulador += Double.Parse(listViewCompras.Items[i].SubItems[1].Text)* Double.Parse(listViewCompras.Items[i].SubItems[2].Text);
            }
            labelPTotal.Text = "El precio total es: " + acumulador.ToString();

        }

        public MisCompras(string nombre)
        {
            InitializeComponent();


            if(Global.rol.Contains("Administrador"))
            {
                comboBoxNombres.Visible = true;
                List<string> listaNombresAux = new List<string>();

                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "Select nombre from usuario ";
                SqlDataReader midatareader = comandosql.ExecuteReader();
                string dato1 = "a";
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetString(0);
                    listaNombresAux.Add(dato1);
                }
                conexion.Close();


                foreach(string nombrea in listaNombresAux)
                {
                    comboBoxNombres.Items.Add(nombrea);
                }
            }
            comboBoxNombres.Text = nombre;
            
            cargarTabla();
            EstadoBotones();
        }

        private void buttonSalilr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            labelEstadoPag.Text = (Int32.Parse(labelEstadoPag.Text) + 1).ToString();
            buttonRetroceder.Text = (Int32.Parse(buttonRetroceder.Text) + 1).ToString();
            buttonAvanzar.Text = (Int32.Parse(buttonAvanzar.Text) + 1).ToString();
            EstadoBotones();
            cargarTabla();
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            buttonRetroceder.Text = (Int32.Parse(buttonRetroceder.Text) - 1).ToString();
            labelEstadoPag.Text = (Int32.Parse(labelEstadoPag.Text) - 1).ToString();
            buttonAvanzar.Text = (Int32.Parse(buttonAvanzar.Text) - 1).ToString();
            EstadoBotones();
            cargarTabla();
        }

        private void comboBoxNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelEstadoPag.Text = "1";
            cargarTabla();
            EstadoBotones();
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            Excel.Application objExcel = new Excel.Application();
            Excel.Workbook objLibro;
            Excel.Worksheet objHoja; //hoja 1.

            objLibro = objExcel.Workbooks.Add(Missing.Value);
            objHoja = (Excel.Worksheet)objLibro.Worksheets.get_Item(1);
            objHoja.Cells[1, 1] = "Producto";      //Celda A1
            objHoja.Cells[1, 2] = "Cantidad";      //Celda B1
            objHoja.Cells[1, 3] = "Precio";        //Celda C1
            objHoja.Cells[1, 4] = "Precio Total";  //Celda C1

            for (int i = 1; i <= listViewCompras.Items.Count; i++)
            {
                objHoja.Cells[1 + i, 1] = listViewCompras.Items[i - 1].SubItems[0].Text;     //Celda Ai
                objHoja.Cells[1 + i, 2] = Int32.Parse(listViewCompras.Items[i - 1].SubItems[1].Text);     //Celda Bi
                objHoja.Cells[1 + i, 3] = Double.Parse(listViewCompras.Items[i - 1].SubItems[2].Text);       //Celda Ci

                Excel.Range objRango;
                objRango = objHoja.get_Range("D" + (i + 1), Missing.Value);
                objRango.FormulaLocal = "=PRODUCTO(B" + (i + 1) + ":C" + (i + 1) + ")";
                objRango.NumberFormat = "0.00 €";
                objRango.Font.Bold = true;
            }
            Excel.Range objRango2;
            objRango2 = objHoja.get_Range("D" + (listViewCompras.Items.Count + 2), Missing.Value);
            objRango2.FormulaLocal = "=SUMA(D" + 2 + ":D" + (listViewCompras.Items.Count + 1) + ")";
            objRango2.NumberFormat = "0.00 €";
            objRango2.Font.Bold = true;

            objExcel.Visible = true;


            

                
            
               
            







        }

        private void labelEstadoPag_Click(object sender, EventArgs e)
        {

        }
    }
}
