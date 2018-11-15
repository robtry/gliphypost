using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GliphyPost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GestionCuentas());
            //Application.Run(new GestionUsuarios());
            Application.Run(new Form1());
            //Application.Run(new Publicaciones());
            //Application.Run(new NuevaPublicacion());
        }
    }
}
