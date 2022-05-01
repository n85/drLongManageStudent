using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDiemSV.Entities;
using QLDiemSV.GUI;
using System.Configuration;

namespace QLDiemSV
{
    
    internal static class Program
    {
        public static string strcon;
        public static Users user;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            strcon = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
            Application.Run(new frmLogin());
        }
    }
}
