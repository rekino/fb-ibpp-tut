using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseMaker
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        private void iTEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTEMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.ITEM' table. You can move, or remove it, as needed.
            this.iTEMTableAdapter.Fill(this.dataSet.ITEM);

        }

        private void btnIconBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    iCONPictureBox.Load(dialog.FileName);
            }
            catch
            {
                MessageBox.Show(
                    "Image Format is not supported",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    iMAGEPictureBox.Load(dialog.FileName);
            }
            catch
            {
                MessageBox.Show(
                    "Image Format is not supported",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
