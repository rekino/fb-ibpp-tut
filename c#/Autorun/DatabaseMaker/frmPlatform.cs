using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseMaker
{
    public partial class frmPlatform : Form
    {
        public frmPlatform()
        {
            InitializeComponent();
        }

        private void pLATFORMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pLATFORMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmPlatform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.PLATFORM' table. You can move, or remove it, as needed.
            this.pLATFORMTableAdapter.Fill(this.dataSet.PLATFORM);

        }

        private void btnBrowse_Click(object sender, EventArgs e)
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
