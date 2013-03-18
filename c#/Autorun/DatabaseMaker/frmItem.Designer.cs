namespace DatabaseMaker
{
    partial class frmItem
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
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label iCONLabel;
            System.Windows.Forms.Label cATEGORYLabel;
            System.Windows.Forms.Label iMAGELabel;
            System.Windows.Forms.Label vERSIONLabel;
            System.Windows.Forms.Label fILE_SIZELabel;
            System.Windows.Forms.Label dISKLabel;
            System.Windows.Forms.Label pATHLabel;
            System.Windows.Forms.Label hELPLabel;
            System.Windows.Forms.Label tAGSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItem));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.iTEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new DatabaseMaker.DataSet();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.iCONPictureBox = new System.Windows.Forms.PictureBox();
            this.cATEGORYListBox = new System.Windows.Forms.ListBox();
            this.iMAGEPictureBox = new System.Windows.Forms.PictureBox();
            this.vERSIONTextBox = new System.Windows.Forms.TextBox();
            this.fILE_SIZETextBox = new System.Windows.Forms.TextBox();
            this.dISKTextBox = new System.Windows.Forms.TextBox();
            this.pATHTextBox = new System.Windows.Forms.TextBox();
            this.hELPTextBox = new System.Windows.Forms.TextBox();
            this.tAGSTextBox = new System.Windows.Forms.TextBox();
            this.btnIconBrowse = new System.Windows.Forms.Button();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.iTEMTableAdapter = new DatabaseMaker.DataSetTableAdapters.ITEMTableAdapter();
            this.tableAdapterManager = new DatabaseMaker.DataSetTableAdapters.TableAdapterManager();
            this.iTEMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTEMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            iCONLabel = new System.Windows.Forms.Label();
            cATEGORYLabel = new System.Windows.Forms.Label();
            iMAGELabel = new System.Windows.Forms.Label();
            vERSIONLabel = new System.Windows.Forms.Label();
            fILE_SIZELabel = new System.Windows.Forms.Label();
            dISKLabel = new System.Windows.Forms.Label();
            pATHLabel = new System.Windows.Forms.Label();
            hELPLabel = new System.Windows.Forms.Label();
            tAGSLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCONPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGEPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingNavigator)).BeginInit();
            this.iTEMBindingNavigator.SuspendLayout();
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
            nAMELabel.Location = new System.Drawing.Point(296, 0);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(41, 13);
            nAMELabel.TabIndex = 2;
            nAMELabel.Text = "NAME:";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(3, 25);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(83, 13);
            dESCRIPTIONLabel.TabIndex = 4;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // iCONLabel
            // 
            iCONLabel.AutoSize = true;
            iCONLabel.Location = new System.Drawing.Point(296, 25);
            iCONLabel.Name = "iCONLabel";
            iCONLabel.Size = new System.Drawing.Size(36, 13);
            iCONLabel.TabIndex = 6;
            iCONLabel.Text = "ICON:";
            // 
            // cATEGORYLabel
            // 
            cATEGORYLabel.AutoSize = true;
            cATEGORYLabel.Location = new System.Drawing.Point(3, 95);
            cATEGORYLabel.Name = "cATEGORYLabel";
            cATEGORYLabel.Size = new System.Drawing.Size(69, 13);
            cATEGORYLabel.TabIndex = 8;
            cATEGORYLabel.Text = "CATEGORY:";
            // 
            // iMAGELabel
            // 
            iMAGELabel.AutoSize = true;
            iMAGELabel.Location = new System.Drawing.Point(296, 95);
            iMAGELabel.Name = "iMAGELabel";
            iMAGELabel.Size = new System.Drawing.Size(44, 13);
            iMAGELabel.TabIndex = 10;
            iMAGELabel.Text = "IMAGE:";
            // 
            // vERSIONLabel
            // 
            vERSIONLabel.AutoSize = true;
            vERSIONLabel.Location = new System.Drawing.Point(3, 182);
            vERSIONLabel.Name = "vERSIONLabel";
            vERSIONLabel.Size = new System.Drawing.Size(58, 13);
            vERSIONLabel.TabIndex = 12;
            vERSIONLabel.Text = "VERSION:";
            // 
            // fILE_SIZELabel
            // 
            fILE_SIZELabel.AutoSize = true;
            fILE_SIZELabel.Location = new System.Drawing.Point(296, 182);
            fILE_SIZELabel.Name = "fILE_SIZELabel";
            fILE_SIZELabel.Size = new System.Drawing.Size(59, 13);
            fILE_SIZELabel.TabIndex = 14;
            fILE_SIZELabel.Text = "FILE SIZE:";
            // 
            // dISKLabel
            // 
            dISKLabel.AutoSize = true;
            dISKLabel.Location = new System.Drawing.Point(3, 207);
            dISKLabel.Name = "dISKLabel";
            dISKLabel.Size = new System.Drawing.Size(35, 13);
            dISKLabel.TabIndex = 16;
            dISKLabel.Text = "DISK:";
            // 
            // pATHLabel
            // 
            pATHLabel.AutoSize = true;
            pATHLabel.Location = new System.Drawing.Point(296, 207);
            pATHLabel.Name = "pATHLabel";
            pATHLabel.Size = new System.Drawing.Size(39, 13);
            pATHLabel.TabIndex = 18;
            pATHLabel.Text = "PATH:";
            // 
            // hELPLabel
            // 
            hELPLabel.AutoSize = true;
            hELPLabel.Location = new System.Drawing.Point(3, 232);
            hELPLabel.Name = "hELPLabel";
            hELPLabel.Size = new System.Drawing.Size(38, 13);
            hELPLabel.TabIndex = 20;
            hELPLabel.Text = "HELP:";
            // 
            // tAGSLabel
            // 
            tAGSLabel.AutoSize = true;
            tAGSLabel.Location = new System.Drawing.Point(296, 232);
            tAGSLabel.Name = "tAGSLabel";
            tAGSLabel.Size = new System.Drawing.Size(39, 13);
            tAGSLabel.TabIndex = 22;
            tAGSLabel.Text = "TAGS:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Controls.Add(iDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iDTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(nAMELabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nAMETextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(dESCRIPTIONLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dESCRIPTIONTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(iCONLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.iCONPictureBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(cATEGORYLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cATEGORYListBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(iMAGELabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.iMAGEPictureBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(vERSIONLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.vERSIONTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(fILE_SIZELabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.fILE_SIZETextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(dISKLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dISKTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(pATHLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.pATHTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(hELPLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.hELPTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(tAGSLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tAGSTextBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnIconBrowse, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnImageBrowse, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(96, 3);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(120, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // iTEMBindingSource
            // 
            this.iTEMBindingSource.DataMember = "ITEM";
            this.iTEMBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(367, 3);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(120, 20);
            this.nAMETextBox.TabIndex = 3;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(96, 28);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(120, 20);
            this.dESCRIPTIONTextBox.TabIndex = 5;
            // 
            // iCONPictureBox
            // 
            this.iCONPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iTEMBindingSource, "ICON", true));
            this.iCONPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iCONPictureBox.Location = new System.Drawing.Point(367, 28);
            this.iCONPictureBox.Name = "iCONPictureBox";
            this.iCONPictureBox.Size = new System.Drawing.Size(194, 64);
            this.iCONPictureBox.TabIndex = 7;
            this.iCONPictureBox.TabStop = false;
            // 
            // cATEGORYListBox
            // 
            this.cATEGORYListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTEMBindingSource, "CATEGORY", true));
            this.cATEGORYListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cATEGORYListBox.FormattingEnabled = true;
            this.cATEGORYListBox.Location = new System.Drawing.Point(96, 98);
            this.cATEGORYListBox.Name = "cATEGORYListBox";
            this.cATEGORYListBox.Size = new System.Drawing.Size(194, 81);
            this.cATEGORYListBox.TabIndex = 9;
            // 
            // iMAGEPictureBox
            // 
            this.iMAGEPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iTEMBindingSource, "IMAGE", true));
            this.iMAGEPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMAGEPictureBox.Location = new System.Drawing.Point(367, 98);
            this.iMAGEPictureBox.Name = "iMAGEPictureBox";
            this.iMAGEPictureBox.Size = new System.Drawing.Size(194, 81);
            this.iMAGEPictureBox.TabIndex = 11;
            this.iMAGEPictureBox.TabStop = false;
            // 
            // vERSIONTextBox
            // 
            this.vERSIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "VERSION", true));
            this.vERSIONTextBox.Location = new System.Drawing.Point(96, 185);
            this.vERSIONTextBox.Name = "vERSIONTextBox";
            this.vERSIONTextBox.Size = new System.Drawing.Size(120, 20);
            this.vERSIONTextBox.TabIndex = 13;
            // 
            // fILE_SIZETextBox
            // 
            this.fILE_SIZETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "FILE_SIZE", true));
            this.fILE_SIZETextBox.Location = new System.Drawing.Point(367, 185);
            this.fILE_SIZETextBox.Name = "fILE_SIZETextBox";
            this.fILE_SIZETextBox.Size = new System.Drawing.Size(120, 20);
            this.fILE_SIZETextBox.TabIndex = 15;
            // 
            // dISKTextBox
            // 
            this.dISKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "DISK", true));
            this.dISKTextBox.Location = new System.Drawing.Point(96, 210);
            this.dISKTextBox.Name = "dISKTextBox";
            this.dISKTextBox.Size = new System.Drawing.Size(120, 20);
            this.dISKTextBox.TabIndex = 17;
            // 
            // pATHTextBox
            // 
            this.pATHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "PATH", true));
            this.pATHTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pATHTextBox.Location = new System.Drawing.Point(367, 210);
            this.pATHTextBox.Name = "pATHTextBox";
            this.pATHTextBox.Size = new System.Drawing.Size(194, 20);
            this.pATHTextBox.TabIndex = 19;
            // 
            // hELPTextBox
            // 
            this.hELPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "HELP", true));
            this.hELPTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hELPTextBox.Location = new System.Drawing.Point(96, 235);
            this.hELPTextBox.Multiline = true;
            this.hELPTextBox.Name = "hELPTextBox";
            this.hELPTextBox.Size = new System.Drawing.Size(194, 132);
            this.hELPTextBox.TabIndex = 21;
            // 
            // tAGSTextBox
            // 
            this.tAGSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMBindingSource, "TAGS", true));
            this.tAGSTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAGSTextBox.Location = new System.Drawing.Point(367, 235);
            this.tAGSTextBox.Multiline = true;
            this.tAGSTextBox.Name = "tAGSTextBox";
            this.tAGSTextBox.Size = new System.Drawing.Size(194, 132);
            this.tAGSTextBox.TabIndex = 23;
            // 
            // btnIconBrowse
            // 
            this.btnIconBrowse.Location = new System.Drawing.Point(567, 28);
            this.btnIconBrowse.Name = "btnIconBrowse";
            this.btnIconBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnIconBrowse.TabIndex = 24;
            this.btnIconBrowse.Text = "Browse";
            this.btnIconBrowse.UseVisualStyleBackColor = true;
            this.btnIconBrowse.Click += new System.EventHandler(this.btnIconBrowse_Click);
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.Location = new System.Drawing.Point(567, 98);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnImageBrowse.TabIndex = 25;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // iTEMTableAdapter
            // 
            this.iTEMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.ITEM_PLATFORMTableAdapter = null;
            this.tableAdapterManager.ITEMTableAdapter = this.iTEMTableAdapter;
            this.tableAdapterManager.PLATFORMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DatabaseMaker.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iTEMBindingNavigator
            // 
            this.iTEMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTEMBindingNavigator.BindingSource = this.iTEMBindingSource;
            this.iTEMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTEMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTEMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTEMBindingNavigatorSaveItem});
            this.iTEMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTEMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTEMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTEMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTEMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTEMBindingNavigator.Name = "iTEMBindingNavigator";
            this.iTEMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTEMBindingNavigator.Size = new System.Drawing.Size(648, 25);
            this.iTEMBindingNavigator.TabIndex = 1;
            this.iTEMBindingNavigator.Text = "bindingNavigator1";
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
            // iTEMBindingNavigatorSaveItem
            // 
            this.iTEMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTEMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTEMBindingNavigatorSaveItem.Image")));
            this.iTEMBindingNavigatorSaveItem.Name = "iTEMBindingNavigatorSaveItem";
            this.iTEMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTEMBindingNavigatorSaveItem.Text = "Save Data";
            this.iTEMBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTEMBindingNavigatorSaveItem_Click);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.iTEMBindingNavigator);
            this.Name = "frmItem";
            this.Text = "frmItem";
            this.Load += new System.EventHandler(this.frmItem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCONPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGEPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingNavigator)).EndInit();
            this.iTEMBindingNavigator.ResumeLayout(false);
            this.iTEMBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource iTEMBindingSource;
        private DataSetTableAdapters.ITEMTableAdapter iTEMTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTEMBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTEMBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.PictureBox iCONPictureBox;
        private System.Windows.Forms.ListBox cATEGORYListBox;
        private System.Windows.Forms.PictureBox iMAGEPictureBox;
        private System.Windows.Forms.TextBox vERSIONTextBox;
        private System.Windows.Forms.TextBox fILE_SIZETextBox;
        private System.Windows.Forms.TextBox dISKTextBox;
        private System.Windows.Forms.TextBox pATHTextBox;
        private System.Windows.Forms.TextBox hELPTextBox;
        private System.Windows.Forms.TextBox tAGSTextBox;
        private System.Windows.Forms.Button btnIconBrowse;
        private System.Windows.Forms.Button btnImageBrowse;

    }
}