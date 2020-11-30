namespace Komunala
{
    partial class frmTest
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label opombaLabel;
            System.Windows.Forms.Label enotaLabel;
            System.Windows.Forms.Label uraLabel;
            System.Windows.Forms.Label dDVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.komunala_ds = new Komunala.komunala_ds();
            this.tbl_DelovnamestaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DelovnamestaTableAdapter = new Komunala.komunala_dsTableAdapters.tbl_DelovnamestaTableAdapter();
            this.tableAdapterManager = new Komunala.komunala_dsTableAdapters.TableAdapterManager();
            this.tbl_DelovnamestaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_DelovnamestaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbl_EnoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbl_DDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEnoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EnoteTableAdapter = new Komunala.komunala_dsTableAdapters.tbl_EnoteTableAdapter();
            this.tbl_DDVTableAdapter = new Komunala.komunala_dsTableAdapters.tbl_DDVTableAdapter();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.opombaTextBox = new System.Windows.Forms.TextBox();
            this.uraTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            opombaLabel = new System.Windows.Forms.Label();
            enotaLabel = new System.Windows.Forms.Label();
            uraLabel = new System.Windows.Forms.Label();
            dDVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.komunala_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DelovnamestaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DelovnamestaBindingNavigator)).BeginInit();
            this.tbl_DelovnamestaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EnoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEnoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(252, 406);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(252, 432);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 4;
            nazivLabel.Text = "Naziv:";
            // 
            // opombaLabel
            // 
            opombaLabel.AutoSize = true;
            opombaLabel.Location = new System.Drawing.Point(252, 458);
            opombaLabel.Name = "opombaLabel";
            opombaLabel.Size = new System.Drawing.Size(50, 13);
            opombaLabel.TabIndex = 6;
            opombaLabel.Text = "Opomba:";
            // 
            // enotaLabel
            // 
            enotaLabel.AutoSize = true;
            enotaLabel.Location = new System.Drawing.Point(252, 484);
            enotaLabel.Name = "enotaLabel";
            enotaLabel.Size = new System.Drawing.Size(38, 13);
            enotaLabel.TabIndex = 8;
            enotaLabel.Text = "Enota:";
            // 
            // uraLabel
            // 
            uraLabel.AutoSize = true;
            uraLabel.Location = new System.Drawing.Point(252, 511);
            uraLabel.Name = "uraLabel";
            uraLabel.Size = new System.Drawing.Size(27, 13);
            uraLabel.TabIndex = 10;
            uraLabel.Text = "Ura:";
            // 
            // dDVLabel
            // 
            dDVLabel.AutoSize = true;
            dDVLabel.Location = new System.Drawing.Point(252, 537);
            dDVLabel.Name = "dDVLabel";
            dDVLabel.Size = new System.Drawing.Size(33, 13);
            dDVLabel.TabIndex = 12;
            dDVLabel.Text = "DDV:";
            // 
            // komunala_ds
            // 
            this.komunala_ds.DataSetName = "komunala_ds";
            this.komunala_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DelovnamestaBindingSource
            // 
            this.tbl_DelovnamestaBindingSource.DataMember = "tbl_Delovnamesta";
            this.tbl_DelovnamestaBindingSource.DataSource = this.komunala_ds;
            // 
            // tbl_DelovnamestaTableAdapter
            // 
            this.tbl_DelovnamestaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_DDVTableAdapter = null;
            this.tableAdapterManager.tbl_DelovnamestaTableAdapter = this.tbl_DelovnamestaTableAdapter;
            this.tableAdapterManager.tbl_DnevnikTableAdapter = null;
            this.tableAdapterManager.tbl_EnoteTableAdapter = null;
            this.tableAdapterManager.tbl_StrojiTableAdapter = null;
            this.tableAdapterManager.tbl_VozilaTableAdapter = null;
            this.tableAdapterManager.tbl_Vrstadela_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Komunala.komunala_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_DelovnamestaBindingNavigator
            // 
            this.tbl_DelovnamestaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_DelovnamestaBindingNavigator.BindingSource = this.tbl_DelovnamestaBindingSource;
            this.tbl_DelovnamestaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_DelovnamestaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_DelovnamestaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_DelovnamestaBindingNavigatorSaveItem});
            this.tbl_DelovnamestaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_DelovnamestaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_DelovnamestaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_DelovnamestaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_DelovnamestaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_DelovnamestaBindingNavigator.Name = "tbl_DelovnamestaBindingNavigator";
            this.tbl_DelovnamestaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_DelovnamestaBindingNavigator.Size = new System.Drawing.Size(1273, 25);
            this.tbl_DelovnamestaBindingNavigator.TabIndex = 0;
            this.tbl_DelovnamestaBindingNavigator.Text = "bindingNavigator1";
            this.tbl_DelovnamestaBindingNavigator.RefreshItems += new System.EventHandler(this.tbl_DelovnamestaBindingNavigator_RefreshItems);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // tbl_DelovnamestaBindingNavigatorSaveItem
            // 
            this.tbl_DelovnamestaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_DelovnamestaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_DelovnamestaBindingNavigatorSaveItem.Image")));
            this.tbl_DelovnamestaBindingNavigatorSaveItem.Name = "tbl_DelovnamestaBindingNavigatorSaveItem";
            this.tbl_DelovnamestaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_DelovnamestaBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_DelovnamestaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_DelovnamestaBindingNavigatorSaveItem_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.dgv1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tblEnoteBindingSource, "Id", true));
            this.dgv1.DataSource = this.tbl_DelovnamestaBindingSource;
            this.dgv1.Location = new System.Drawing.Point(42, 52);
            this.dgv1.Name = "dgv1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(751, 220);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_DelovnamestaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Opomba";
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Opomba";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Enota";
            this.dataGridViewTextBoxColumn4.DataSource = this.tbl_EnoteBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn4.DisplayMember = "em";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Enota";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Id";
            // 
            // tbl_EnoteBindingSource
            // 
            this.tbl_EnoteBindingSource.DataMember = "tbl_Enote";
            this.tbl_EnoteBindingSource.DataSource = this.komunala_ds;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ura";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ura";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DDV";
            this.dataGridViewTextBoxColumn7.DataSource = this.tbl_DDVBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Stopnja";
            this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn7.HeaderText = "DDV";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Id";
            // 
            // tbl_DDVBindingSource
            // 
            this.tbl_DDVBindingSource.DataMember = "tbl_DDV";
            this.tbl_DDVBindingSource.DataSource = this.komunala_ds;
            // 
            // tblEnoteBindingSource
            // 
            this.tblEnoteBindingSource.DataMember = "tbl_Enote";
            this.tblEnoteBindingSource.DataSource = this.komunala_ds;
            // 
            // tbl_EnoteTableAdapter
            // 
            this.tbl_EnoteTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_DDVTableAdapter
            // 
            this.tbl_DDVTableAdapter.ClearBeforeFill = true;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_DelovnamestaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(308, 403);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_DelovnamestaBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(308, 429);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(121, 20);
            this.nazivTextBox.TabIndex = 5;
            // 
            // opombaTextBox
            // 
            this.opombaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_DelovnamestaBindingSource, "Opomba", true));
            this.opombaTextBox.Location = new System.Drawing.Point(308, 455);
            this.opombaTextBox.Name = "opombaTextBox";
            this.opombaTextBox.Size = new System.Drawing.Size(121, 20);
            this.opombaTextBox.TabIndex = 7;
            // 
            // uraTextBox
            // 
            this.uraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_DelovnamestaBindingSource, "Ura", true));
            this.uraTextBox.Location = new System.Drawing.Point(308, 508);
            this.uraTextBox.Name = "uraTextBox";
            this.uraTextBox.Size = new System.Drawing.Size(121, 20);
            this.uraTextBox.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_DelovnamestaBindingSource, "DDV", true));
            this.comboBox1.DataSource = this.tbl_DDVBindingSource;
            this.comboBox1.DisplayMember = "Opis";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 582);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "Stopnja";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 840);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(opombaLabel);
            this.Controls.Add(this.opombaTextBox);
            this.Controls.Add(enotaLabel);
            this.Controls.Add(uraLabel);
            this.Controls.Add(this.uraTextBox);
            this.Controls.Add(dDVLabel);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.tbl_DelovnamestaBindingNavigator);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.komunala_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DelovnamestaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DelovnamestaBindingNavigator)).EndInit();
            this.tbl_DelovnamestaBindingNavigator.ResumeLayout(false);
            this.tbl_DelovnamestaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EnoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEnoteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private komunala_ds komunala_ds;
        private System.Windows.Forms.BindingSource tbl_DelovnamestaBindingSource;
        private komunala_dsTableAdapters.tbl_DelovnamestaTableAdapter tbl_DelovnamestaTableAdapter;
        private komunala_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_DelovnamestaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_DelovnamestaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.BindingSource tbl_EnoteBindingSource;
        private komunala_dsTableAdapters.tbl_EnoteTableAdapter tbl_EnoteTableAdapter;
        private System.Windows.Forms.BindingSource tblEnoteBindingSource;
        private System.Windows.Forms.BindingSource tbl_DDVBindingSource;
        private komunala_dsTableAdapters.tbl_DDVTableAdapter tbl_DDVTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox opombaTextBox;
        private System.Windows.Forms.TextBox uraTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}