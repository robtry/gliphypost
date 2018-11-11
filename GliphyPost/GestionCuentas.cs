using System;
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
        Menu m = new Menu();
        private int contador;
        private int con2;
        public GestionCuentas()
        {
            InitializeComponent();
            contador = 0;
            con2 = 0;
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

            if (is_valid())
            {
                errorProvider1.Clear();
                metroButton1.Enabled = false;
                metroProgressBar1.Visible = true;
                label4.Text = "Validando..";
                label4.Visible = true;
                //selenium();
                metroButton1.Enabled = true;
                //label4.Visible = false;
                //metroProgressBar1.Visible = false;
            }

        }
        
        private void selenium()
        {

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
                //new Actions(driver).SendKeys("abc").Perform(); ====

                //MessageBox.Show("esperado");
                //System.Threading.Thread.Sleep(5000);
                //MessageBox.Show("acabo espera");

                // hace el post ===
                //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div[2]/div/div[3]/div/div/div[2]/div[1]/div/div/div/div[2]/div/div[2]/div[3]/div[2]/div/div/span/button")).Click();

                MetroMessageBox.Show(this, "\n\nSe agregó la cuenta correctamente", "Cuenta agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception e)
            {
                MetroMessageBox.Show(this, "\n\nNo se puedo acceder", "Error al agregar cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            finally
            {
                driver.Quit();
            }
        }

        private bool is_valid()
        {
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
            if (metroComboBox2.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(metroComboBox2, "Se debe seleccionar algo");
                return false;
            }

            return true;

        }
    }
}
