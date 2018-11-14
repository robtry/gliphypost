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
    public partial class GestionUsuarios : MaterialSkin.Controls.MaterialForm
    {
        Menu m = new Menu();

        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            //toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.pictureBox2, "Mis publicaciones");
            toolTip1.SetToolTip(this.pictureBox1, "Nueva publiación");
            toolTip1.SetToolTip(this.pictureBox3, "Publicados");
            toolTip1.SetToolTip(this.pictureBox6, "Por publicar");
            toolTip1.SetToolTip(this.pictureBox5, "Por autorizar");
            toolTip1.SetToolTip(this.pictureBox4, "Lista de Usuarios");
            toolTip1.SetToolTip(this.pictureBox7, "Resdes Sociales");

            //llenar
            llenarGrid();
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

        private void llenarGrid()
        {
            DataTable tabla = new DataTable();
            DataRow Renglon;

            // Llenado de datos del DataGridView //
            tabla.Columns.Add(new DataColumn("Usuario"));
            tabla.Columns.Add(new DataColumn("Nivel"));
            tabla.Columns.Add(new DataColumn("Publicaciones"));

            Renglon = tabla.NewRow();
            Renglon[0] = "Carlos Rosales";
            Renglon[1] = "1";
            Renglon[2] = "15";
            tabla.Rows.Add(Renglon);

            Renglon = tabla.NewRow();
            Renglon[0] = "Gabriel Garcia";
            Renglon[1] = "2";
            Renglon[2] = "12";
            tabla.Rows.Add(Renglon);

            Renglon = tabla.NewRow();
            Renglon[0] = "Madeline Vazquéz";
            Renglon[1] = "3";
            Renglon[2] = "3";
            tabla.Rows.Add(Renglon);

            Renglon = tabla.NewRow();
            Renglon[0] = "Luis Flores";
            Renglon[1] = "3";
            Renglon[2] = "8";
            tabla.Rows.Add(Renglon);


            metroGrid1.DataSource = tabla;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }

        private void GestionUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado;
            resultado = MetroMessageBox.Show(this, "Gliphy Post", "¿Seguro que deseas salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
                System.Environment.Exit(0);
            else
                e.Cancel = true;
        }
    }
}
