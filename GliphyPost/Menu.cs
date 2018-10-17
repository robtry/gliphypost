using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GliphyPost
{
    class Menu
    {
        public void esconderMenu(System.Windows.Forms.Panel panel)
        {
            panel.Location = new Point(-150, 64);
            while (panel.Location.X != -13)
                panel.Location = new Point(panel.Location.X + 1, 64);
            while (panel.Location.X != 1)
            {
                panel.Location = new Point(panel.Location.X + 1, 64);
                //Refresh();
                System.Threading.Thread.Sleep(5);
            }
        }

        public void mostrarMenu(System.Windows.Forms.Panel panel)
        {
            panel.Location = new Point(10, 64);
            while (panel.Location.X != -140)
                panel.Location = new Point(panel.Location.X - 1, 64);
            while (panel.Location.X != -160)
            {
                panel.Location = new Point(panel.Location.X - 1, 64);
                //Refresh();
                System.Threading.Thread.Sleep(5);
            }
        }

        public void formularioPublicacion()
        {
            NuevaPublicacion x = new NuevaPublicacion();
            x.Show();
        }

        public void cuentas()
        {
            GestionCuentas x = new GestionCuentas();
            x.Show();
        }

        public void listaUsuarios()
        {
            GestionUsuarios x = new GestionUsuarios();
            x.Show();
        }

        public void misPublicaciones()
        {
            Publicaciones x = new Publicaciones();
            x.Show();
            x.misPublicaciones();
        }

        public void publicados()
        {
            Publicaciones x = new Publicaciones();
            x.Show();
            x.publicados();
        }

        public void porPublicar()
        {
            Publicaciones x = new Publicaciones();
            x.Show();
            x.porPublicar();
        }

        public void porAutorizar()
        {
            Publicaciones x = new Publicaciones();
            x.Show();
            x.porAutorizar();
        }


    }
}
