 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinalPrototipo
{

    public static class Global
    {
        public static string id= "-1";
        public static string name = "-1";
        public static string rol = "-1";
        public static string CadenaDeConexion= "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
        public static string contraAdmin = "admin";
    }
    public static class Carrito
    {
        public static List<string> listaNombres = new List<string>();
        public static List<int> listaCantidad = new List<int>();
        public static List<double> listaPrecios = new List<double>();
    }
    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());

        }
    }
}
