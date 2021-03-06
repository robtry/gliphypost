﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace GliphyPost
{
    public partial class GestionCuentas : MaterialSkin.Controls.MaterialForm
    {
        private Menu m = new Menu();
        public GestionCuentas()
        {
            InitializeComponent();
        }

        private void GestionCuentas_Load(object sender, EventArgs e)
        {
            metroProgressBar1.Visible = false;
            label4.Visible = false;
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



        //=======================================================================

        private void metroButton1_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private bool is_valid()
        {
            if (metroComboBox2.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(metroComboBox2, "Se debe seleccionar algo");
                return false;
            }
            //else
            if (materialSingleLineTextField1.Text.Trim() == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(materialSingleLineTextField1, "No puede esta vacío");
                return false;
            }
            //else
            if (materialSingleLineTextField2.Text.Trim() == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(materialSingleLineTextField2, "Se debe llenar este campo");
                return false;
            }
            //else
            if (materialSingleLineTextField3.Text.Trim() == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(materialSingleLineTextField3, "Se debe llenar este campo");
                return false;
            }


            return true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }

        private void GestionCuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado;
            resultado = MetroMessageBox.Show(this, "Gliphy Post", "¿Seguro que deseas salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
                System.Environment.Exit(0);
            else
                e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressBar1.Value != 100)
            {
                metroProgressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                MetroMessageBox.Show(this, "Gliphy Post", "Cuenta verificada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Question);
                metroButton1.Enabled = true;
                label4.Visible = false;
                metroProgressBar1.Visible = false;
                metroProgressBar1.Value = 0;
                metroComboBox2.SelectedIndex = -1;
                materialSingleLineTextField1.Clear();
                materialSingleLineTextField2.Clear();
                materialSingleLineTextField3.Clear();
            }
        }

        private void materialSingleLineTextField3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                agregar();
            }
        }

        private void agregar()
        {
            if (is_valid())
            {
                errorProvider1.Clear();
                metroButton1.Enabled = false;
                metroProgressBar1.Visible = true;
                label4.Text = "Validando..";
                label4.Visible = true;
                timer1.Start();
            }
        }
    }
}
