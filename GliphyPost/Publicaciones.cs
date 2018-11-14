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
            //cuando viene de ingresar carga mis publicaciones

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

            ///Llenar con cuentas
            metroComboBox2.Items.Add("Facebook");
            metroComboBox2.Items.Add("Twitter");
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
            llenarGrid();
            
            //estado
            metroComboBox1.Enabled = true;
            materialLabel3.Enabled = true;
            metroComboBox1.SelectedIndex = -1;
            //cuenta
            metroComboBox2.SelectedIndex = -1;
            //field
            materialSingleLineTextField1.Clear();
            //filtro actual
            materialLabel5.Text = "Filtro actual: Ninguno";
            //botones
            materialFlatButton8.Visible = false;
            materialFlatButton9.Visible = false;
            //publica ahora
            materialFlatButton10.Visible = false;

        }

        public void publicados()
        {
            label3.Text = "Publicados";
            llenarGrid();
            //estado
            metroComboBox1.Enabled = false;
            materialLabel3.Enabled = false;
            metroComboBox1.SelectedIndex = 0;
            //cuenta
            metroComboBox2.SelectedIndex = -1;
            //field
            materialSingleLineTextField1.Clear();
            //filtro actual
            materialLabel5.Text = "Filtro actual: Ninguno";
            //botones
            materialFlatButton8.Visible = false;
            materialFlatButton9.Visible = false;
            //publica ahora
            materialFlatButton10.Visible = false;
        }

        public void porPublicar()
        {
            label3.Text = "Por Publicar";
            llenarGrid();
            //estado
            metroComboBox1.Enabled = false;
            materialLabel3.Enabled = false;
            metroComboBox1.SelectedIndex = 1;
            //cuenta
            metroComboBox2.SelectedIndex = -1;
            //field
            materialSingleLineTextField1.Clear();
            //filtro actual
            materialLabel5.Text = "Filtro actual: Ninguno";
            //botones
            materialFlatButton8.Visible = false;
            materialFlatButton9.Visible = false;
            //publica ahora
            materialFlatButton10.Visible = true;
        }

        public void porAutorizar()
        {
            label3.Text = "Por Autorizar";
            llenarGrid();
            //estado
            metroComboBox1.Enabled = false;
            materialLabel3.Enabled = false;
            metroComboBox1.SelectedIndex = 2;
            //cuenta
            metroComboBox2.SelectedIndex = -1;
            //field
            materialSingleLineTextField1.Clear();
            //filtro actual
            materialLabel5.Text = "Filtro actual: Ninguno";
            //botones
            materialFlatButton8.Visible = true;
            materialFlatButton9.Visible = true;
            //publica ahora
            materialFlatButton10.Visible = false;

        }

        private void llenarGrid()
        {
            DataTable tabla = new DataTable();
            DataRow Renglon;

            // Llenado de datos del DataGridView //
            tabla.Columns.Add(new DataColumn("Autor"));
            tabla.Columns.Add(new DataColumn("Cuenta"));
            tabla.Columns.Add(new DataColumn("Fecha"));
            tabla.Columns.Add(new DataColumn("Contenido"));

            Renglon = tabla.NewRow();
            Renglon[0] = "Carlos Rosales";
            Renglon[1] = "Facebook";
            Renglon[2] = "15-10-18";
            Renglon[3] = "Se venden las playeras....";
            tabla.Rows.Add(Renglon);

            Renglon = tabla.NewRow();
            Renglon[0] = "Gabriel Garcia";
            Renglon[1] = "Facebook";
            Renglon[2] = "31-9-18";
            Renglon[3] = "Visita de Microsoft....";
            tabla.Rows.Add(Renglon);

            Renglon = tabla.NewRow();
            Renglon[0] = "Madeline Vazquéz";
            Renglon[1] = "Twitter";
            Renglon[2] = "12-10-18";
            Renglon[3] = "Nueva Vacante ....";
            tabla.Rows.Add(Renglon);

            metroGrid1.DataSource = tabla;
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Fecha";
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Estado";
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Cuenta";
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Contenido";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Ninguno";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }
    }
}
