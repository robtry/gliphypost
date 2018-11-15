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
            // TODO: esta línea de código carga datos en la tabla 'glyphyPostDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.glyphyPostDataSet.Usuarios);
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

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glyphyPostDataSet);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy(this.glyphyPostDataSet.Usuarios, materialSingleLineTextField1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llenarGrid();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            actualizarANivel(1);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            actualizarANivel(2);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            actualizarANivel(3);
        }

        private void actualizarANivel(int a)
        {
            usuariosTableAdapter.UpdateLevel(a, usuariosDataGridView.SelectedCells[0].Value.ToString());
            llenarGrid();
        }
    }
}
