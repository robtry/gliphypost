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
    public partial class NuevaPublicacion : MaterialSkin.Controls.MaterialForm
    {
        Menu m = new Menu();

        public NuevaPublicacion()
        {
            InitializeComponent();
        }

        private void NuevaPublicacion_Load(object sender, EventArgs e)
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



            ///Llenar con cuentas
            metroComboBox1.Items.Add("Facebook");
            metroComboBox1.Items.Add("Twitter");
            //desabilitarl el otro
            materialLabel4.Enabled = false;
            metroComboBox2.Enabled = false;
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

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                materialLabel4.Enabled = true;
                metroComboBox2.Enabled = true;
            }
            else
            {
                materialLabel4.Enabled = false;
                metroComboBox2.Enabled = false;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (is_valid())
            {
                errorProvider1.Clear();
                MetroMessageBox.Show(this, "\n\nSe agendó la publicación correctamente", "Publicación programada", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private bool is_valid()
        {
            if (metroComboBox1.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(metroComboBox1 , "Debe seleccionar una cuenta");
                return false;
            }

            if (metroTextBox1.Text.Trim() == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(metroTextBox1, "No puede esta vacío");
                return false;
            }

            DateTime a = new DateTime(metroDateTime1.Value.Year,
                                      metroDateTime1.Value.Month,
                                      metroDateTime1.Value.Day,
                                      Int32.Parse(numericUpDown1.Value.ToString()),
                                      Int32.Parse(numericUpDown2.Value.ToString()),
                                      0);
            if(a.CompareTo(DateTime.Now) == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(metroDateTime1, "No se pueden programar fechas para el pasado");
                return false;
            }

            
            
            return true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Hide();
        }

        private void NuevaPublicacion_FormClosing(object sender, FormClosingEventArgs e)
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
