using MaterialSkin;
using MetroFramework;
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
    public partial class Publicaciones : MaterialSkin.Controls.MaterialForm
    {
        Menu m = new Menu();

        public Publicaciones()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Publicaciones_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Publicaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado;
            resultado = MetroMessageBox.Show(this, "Gliphy Post", "¿Seguro que deseas salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
                System.Environment.Exit(0);
            else
                e.Cancel = true;
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            misPublicaciones();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            misPublicaciones();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            publicados();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            publicados();
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            porPublicar();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            porPublicar();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            porAutorizar();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            porAutorizar();
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

        //================================================================
        public void misPublicaciones()
        {
            label3.Text = "Mis Publicaciones";
        }

        public void publicados()
        {
            label3.Text = "Publicados";
        }

        public void porPublicar()
        {
            label3.Text = "Por Publicar";
        }

        public void porAutorizar()
        {
            label3.Text = "Por Autorizar";
        }
    }
}
