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
    public partial class borrar : Form
    {
        public borrar()
        {
            InitializeComponent();
        }

        private void nivelesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nivelesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glyphyPostDataSet);

        }

        private void borrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glyphyPostDataSet.Niveles' table. You can move, or remove it, as needed.
            this.nivelesTableAdapter.Fill(this.glyphyPostDataSet.Niveles);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void nivelesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void nivelesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
