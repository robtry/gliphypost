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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm // MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (is_valid())
            {
                errorProvider1.Clear();
                Boolean pasa = true;
                if (pasa){
                    Publicaciones x = new Publicaciones();
                    x.Show();
                    x.misPublicaciones();
                    this.Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nUsuario o Contraseña Incorrecto\nDEBE FORMAR PARTE DE LA ASOCIASIÓN PARA INGRESAR", "Error de autentificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if(materialSingleLineTextField2.Text. Trim() == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(materialSingleLineTextField2, "Se debe llenar este campo");
                return false;
            }

            return true;

        }
    }
}
