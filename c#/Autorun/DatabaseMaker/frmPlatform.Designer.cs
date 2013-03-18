namespace DatabaseMaker
{
    partial class frmPlatform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label iMAGELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlatform));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.pLATFORMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new DatabaseMaker.DataSet();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.iMAGEPictureBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pLATFORMTableAdapter = new DatabaseMaker.DataSetTableAdapters.PLATFORMTableAdapter();
            this.tableAdapterManager = new DatabaseMaker.DataSetTableAdapters.TableAdapterManager();
            this.pLATFORMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pLATFORMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            iMAGELabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLATFORMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGEPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLATFORMBindingNavigator)).BeginInit();
            this.pLATFORMBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(3, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(3, 27);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(41, 13);
            nAMELabel.TabIndex = 2;
            nAMELabel.Text = "NAME:";
            // 
            // iMAGELabel
            // 
            iMAGELabel.AutoSize = true;
            iMAGELabel.Location = new System.Drawing.Point(3, 54);
            iMAGELabel.Name = "iMAGELabel";
            iMAGELabel.Size = new System.Drawing.Size(44, 13);
            iMAGELabel.TabIndex = 4;
            iMAGELabel.Text = "IMAGE:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(iDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iDTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(nAMELabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nAMETextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(iMAGELabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.iMAGEPictureBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLATFORMBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(60, 3);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // pLATFORMBindingSource
            // 
            this.pLATFORMBindingSource.DataMember = "PLATFORM";
            this.pLATFORMBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLATFORMBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(60, 30);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMETextBox.TabIndex = 3;
            // 
            // iMAGEPictureBox
            // 
            this.iMAGEPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pLATFORMBindingSource, "IMAGE", true));
            this.iMAGEPictureBox.Location = new System.Drawing.Point(60, 57);
            this.iMAGEPictureBox.Name = "iMAGEPictureBox";
            this.iMAGEPictureBox.Size = new System.Drawing.Size(100, 81);
            this.iMAGEPictureBox.TabIndex = 5;
            this.iMAGEPictureBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(173, 57);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pLATFORMTableAdapter
            // 
            this.pLATFORMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.ITEM_PLATFORMTableAdapter = null;
            this.tableAdapterManager.ITEMTableAdapter = null;
            this.tableAdapterManager.PLATFORMTableAdapter = this.pLATFORMTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseMaker.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pLATFORMBindingNavigator
            // 
            this.pLATFORMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pLATFORMBindingNavigator.BindingSource = this.pLATFORMBindingSource;
            this.pLATFORMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pLATFORMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pLATFORMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pLATFORMBindingNavigatorSaveItem});
            this.pLATFORMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pLATFORMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pLATFORMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pLATFORMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pLATFORMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pLATFORMBindingNavigator.Name = "pLATFORMBindingNavigator";
            this.pLATFORMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pLATFORMBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.pLATFORMBindingNavigator.TabIndex = 1;
            this.pLATFORMBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pLATFORMBindingNavigatorSaveItem
            // 
            this.pLATFORMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pLATFORMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pLATFORMBindingNavigatorSaveItem.Image")));
            this.pLATFORMBindingNavigatorSaveItem.Name = "pLATFORMBindingNavigatorSaveItem";
            this.pLATFORMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pLATFORMBindingNavigatorSaveItem.Text = "Save Data";
            this.pLATFORMBindingNavigatorSaveItem.Click += new System.EventHandler(this.pLATFORMBindingNavigatorSaveItem_Click);
            // 
            // frmPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pLATFORMBindingNavigator);
            this.Name = "frmPlatform";
            this.Text = "Platform";
            this.Load += new System.EventHandler(this.frmPlatform_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLATFORMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGEPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLATFORMBindingNavigator)).EndInit();
            this.pLATFORMBindingNavigator.ResumeLayout(false);
            this.pLATFORMBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource pLATFORMBindingSource;
        private DataSetTableAdapters.PLATFORMTableAdapter pLATFORMTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pLATFORMBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pLATFORMBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.PictureBox iMAGEPictureBox;
        private System.Windows.Forms.Button btnBrowse;
    }
}

