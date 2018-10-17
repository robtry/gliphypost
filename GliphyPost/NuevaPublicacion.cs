using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GliphyPost
{
    public partial class NuevaPublicacion : MaterialSkin.Controls.MaterialForm
    {
        Menu m = new Menu();

        public NuevaPublicacion()
        {
            InitializeComponent();
        }

        private void NuevaPublicacion_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            m.esconderMenu(panel1);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            m.mostrarMenu(panel1);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            m.misPublicaciones();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            m.misPublicaciones();
            this.Hide();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            m.formularioPublicacion();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            m.formularioPublicacion();
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            m.publicados();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            m.publicados();
            this.Hide();
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            m.porPublicar();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            m.porPublicar();
            this.Hide();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            m.porAutorizar();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            m.porAutorizar();
            this.Hide();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            m.listaUsuarios();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            m.listaUsuarios();
            this.Hide();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            m.cuentas();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            m.cuentas();
            this.Hide();
        }
    }
}
