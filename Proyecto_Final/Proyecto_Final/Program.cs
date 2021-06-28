using Proyecto_Final.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    static class Program
    {
        public static bool OpenfrmPreCheckOnClose { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenfrmPreCheckOnClose = false;
            Application.Run(new frmGestorLogIn());
            if (OpenfrmPreCheckOnClose)
            {
                Application.Run(new frmPreCheck());
            }
        }
    }
}
