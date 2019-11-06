using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECSystem
{
    static class Program
    {
        //Privilegios
        public static String cargo = null;
        public static String user = null;
        public static String pass = null;
        public static String nombre = null;
        public static String apellidos = null;
        public static String correo = null;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
