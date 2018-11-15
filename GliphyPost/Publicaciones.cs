using MaterialSkin;
using MetroFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
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
            metroComboBox2.Items.Add("Facebook SATI");
            metroComboBox2.Items.Add("Twitter SATI");
            metroComboBox2.Items.Add("Facebook Rob");
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
            //fecha
            metroDateTime1.Value = DateTime.Now;

            llenarMISPUBLICACIONES();

        }

        public void publicados()
        {
            label3.Text = "Publicados";
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
            //fecha
            metroDateTime1.Value = DateTime.Now;

            llenarPUBLICADOS();
        }

        public void porPublicar()
        {
            label3.Text = "Por Publicar";
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
            //fecha
            metroDateTime1.Value = DateTime.Now;

            llenarPORPUBLICAR();
        }

        public void porAutorizar()
        {
            label3.Text = "Por Autorizar";
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
            //fecha
            metroDateTime1.Value = DateTime.Now;

            llenarPORAUTORIZAR();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Fecha";
            if (label3.Text == "Mis Publicaciones")
            {
                try
                {
                    publicacionesTableAdapter.MeFecha(glyphyPostDataSet.Publicaciones, metroDateTime1.Value.Year + "-" + metroDateTime1.Value.Month + "-" + metroDateTime1.Value.Day);

                }
                catch
                {
                    //
                }
            }
            else if (label3.Text == "Publicados")
            {
                try
                {
                    publicacionesTableAdapter.EstatusFecha(glyphyPostDataSet.Publicaciones, "Publicada", metroDateTime1.Value.Year + "-" + metroDateTime1.Value.Month + "-" + metroDateTime1.Value.Day);

                }
                catch
                {
                    //
                }
            }
            else
            {
                try
                {
                    publicacionesTableAdapter.EstatusFecha(glyphyPostDataSet.Publicaciones, label3.Text, metroDateTime1.Value.Year + "-" + metroDateTime1.Value.Month + "-" + metroDateTime1.Value.Day);

                }
                catch
                {
                    //
                }
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Estado";
            try
            {
                if(metroComboBox1.SelectedIndex == 0)
                {
                    publicacionesTableAdapter.MeEstatus(glyphyPostDataSet.Publicaciones, "Publicada");
                }
                else
                { 
                    publicacionesTableAdapter.MeEstatus(glyphyPostDataSet.Publicaciones, metroComboBox1.SelectedItem.ToString());
                }

            }
            catch
            {
                //
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Cuenta";
            if (label3.Text == "Mis Publicaciones")
            {
                try
                {
                    publicacionesTableAdapter.MeCuenta(glyphyPostDataSet.Publicaciones, metroComboBox2.SelectedItem.ToString());

                }
                catch
                {
                    //
                }
            }
            else if (label3.Text == "Publicados")
            {
                try
                {
                    publicacionesTableAdapter.EstatusCuenta(glyphyPostDataSet.Publicaciones, "Publicada", metroComboBox2.SelectedItem.ToString());

                }
                catch
                {
                    //
                }
            }
            else
            {
                try
                {
                    publicacionesTableAdapter.EstatusCuenta(glyphyPostDataSet.Publicaciones, label3.Text, metroComboBox2.SelectedItem.ToString());

                }
                catch
                {
                    //
                }
            }

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Contenido";
            contenido();

        }

        private void materialSingleLineTextField1_KeyDown(object sender, KeyEventArgs e)
        {
            contenido();
        }

        private void contenido()
        {
            if (label3.Text == "Mis Publicaciones")
            {
                try
                {
                    publicacionesTableAdapter.MeLike(glyphyPostDataSet.Publicaciones, materialSingleLineTextField1.Text);

                }
                catch
                {
                    //
                }
            }
            else if (label3.Text == "Publicados")
            {
                try
                {
                    publicacionesTableAdapter.EstatusLike(glyphyPostDataSet.Publicaciones, "Publicada", materialSingleLineTextField1.Text);

                }
                catch
                {
                    //
                }
            }
            else
            {
                try
                {
                    publicacionesTableAdapter.EstatusLike(glyphyPostDataSet.Publicaciones, label3.Text, materialSingleLineTextField1.Text);

                }
                catch
                {
                    //
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            materialLabel5.Text = "Filtro actual: Ninguno";
            if(label3.Text == "Mis Publicaciones")
            {
                llenarMISPUBLICACIONES();
            }else if (label3.Text == "Por Autorizar")
            {
                llenarPORAUTORIZAR();
            }else if (label3.Text == "Publicados")
            {
                llenarPUBLICADOS();
            }else if (label3.Text == "Por Publicar")
            {
                llenarPORPUBLICAR();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }

        private void publicacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publicacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glyphyPostDataSet);

        }

        private void llenarGrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'glyphyPostDataSet.Publicaciones' Puede moverla o quitarla según sea necesario.
            //this.publicacionesTableAdapter.Fill(this.glyphyPostDataSet.Publicaciones);
        }

        private void llenarMISPUBLICACIONES()
        {
            try
            {
                this.publicacionesTableAdapter.MinesPosts(this.glyphyPostDataSet.Publicaciones);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void llenarPUBLICADOS()
        {
            try
            {
                this.publicacionesTableAdapter.Published(this.glyphyPostDataSet.Publicaciones);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void llenarPORPUBLICAR()
        {
            try
            {
                this.publicacionesTableAdapter.ForPublish(this.glyphyPostDataSet.Publicaciones);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void llenarPORAUTORIZAR()
        {
            try
            {
                this.publicacionesTableAdapter.ForAuthorize(this.glyphyPostDataSet.Publicaciones);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            publicacionesTableAdapter.UpdateStatus("Por Publicar", Int32.Parse(metroGrid1.SelectedCells[0].Value.ToString()));
            llenarPORAUTORIZAR();
        }

        private void materialFlatButton8_Click_1(object sender, EventArgs e)
        {
            publicacionesTableAdapter.UpdateStatus("Rechazar", Int32.Parse(metroGrid1.SelectedCells[0].Value.ToString()));
            llenarPORAUTORIZAR();
        }

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {
            bool sePudo = false;
            var o = new FirefoxOptions();
            //o.AddArgument("-headless");
            o.SetPreference("dom.webnotifications.enabled", false);

            IWebDriver driver = new FirefoxDriver(o);

            driver.Url = "https://www.facebook.com";

            driver.FindElement(By.Id("email")).SendKeys("5513162012");
            driver.FindElement(By.Id("pass")).SendKeys("wtfwtf" + OpenQA.Selenium.Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            try
            {
                driver.FindElement(By.XPath("//*[@id=\"feedx_sprouts_container\"]/div")).Click(); //si no lo encuentra ps no se pudo logguear

                //ya entro
                new Actions(driver).SendKeys(metroGrid1.SelectedCells[4].Value.ToString()).Perform();

                //MessageBox.Show("esperado");
                //MessageBox.Show("acabo espera");

                // hace el post ===
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div[2]/div/div[3]/div/div/div[2]/div[1]/div/div/div/div[2]/div/div[2]/div[3]/div[2]/div/div/span/button")).Click();
                System.Threading.Thread.Sleep(5000);
                sePudo = true;
            }
            //catch(Exception e)
            catch
            {
                MetroMessageBox.Show(this, "\n\nNo se pudo publicar", "Error al publicar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            finally
            {
                driver.Quit();
            }

            if (sePudo)
            {
                MetroMessageBox.Show(this, "\n\nSe hizo la publicación correctamente", "Post Publicado", MessageBoxButtons.OK, MessageBoxIcon.Question);
                publicacionesTableAdapter.UpdateStatus("Publicada", Int32.Parse(metroGrid1.SelectedCells[0].Value.ToString()));
                llenarPORPUBLICAR();
            }
 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Details z = new Details();
            z.materialLabel2.Text = publicacionesTableAdapter.GetNombre(metroGrid1.SelectedCells[1].Value.ToString());
            z.materialLabel7.Text = metroGrid1.SelectedCells[2].Value.ToString();
            z.materialLabel3.Text = metroGrid1.SelectedCells[3].Value.ToString();
            z.metroTextBox1.Text = metroGrid1.SelectedCells[4].Value.ToString();
            z.materialLabel5.Text = metroGrid1.SelectedCells[5].Value.ToString();
            z.ShowDialog();
        }

        
    }
}
