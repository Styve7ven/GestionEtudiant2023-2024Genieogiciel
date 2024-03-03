namespace GestionEtudiants
{
    partial class frmPersonne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonne));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPNane = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSexe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdnav1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd1 = new System.Windows.Forms.ToolStripButton();
            this.btnSave1 = new System.Windows.Forms.ToolStripButton();
            this.btnDelete1 = new System.Windows.Forms.ToolStripButton();
            this.dgvTelephone = new System.Windows.Forms.DataGridView();
            this.colIDTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId_proprietaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtInitial = new System.Windows.Forms.MaskedTextBox();
            this.bdnav2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd2 = new System.Windows.Forms.ToolStripButton();
            this.btnSave2 = new System.Windows.Forms.ToolStripButton();
            this.btnDelete2 = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnav1)).BeginInit();
            this.bdnav1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnav2)).BeginInit();
            this.bdnav2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtMatricule);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.dgvPersonne);
            this.splitContainer1.Panel1.Controls.Add(this.txtPNane);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrenom);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cboSexe);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.bdnav1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTelephone);
            this.splitContainer1.Panel2.Controls.Add(this.txtNumero);
            this.splitContainer1.Panel2.Controls.Add(this.txtInitial);
            this.splitContainer1.Panel2.Controls.Add(this.bdnav2);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtIDTel);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1508, 610);
            this.splitContainer1.SplitterDistance = 701;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(94, 116);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(586, 22);
            this.txtMatricule.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Matricule";
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.AllowUserToDeleteRows = false;
            this.dgvPersonne.AllowUserToOrderColumns = true;
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNom,
            this.colPostnom,
            this.colPrenom,
            this.colNomComplet});
            this.dgvPersonne.Location = new System.Drawing.Point(14, 277);
            this.dgvPersonne.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.RowHeadersVisible = false;
            this.dgvPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonne.Size = new System.Drawing.Size(666, 266);
            this.dgvPersonne.TabIndex = 31;
            this.dgvPersonne.SelectionChanged += new System.EventHandler(this.dgvPersonne_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Code";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 80;
            // 
            // colNom
            // 
            this.colNom.DataPropertyName = "Nom";
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.Visible = false;
            // 
            // colPostnom
            // 
            this.colPostnom.DataPropertyName = "Postnom";
            this.colPostnom.HeaderText = "Postnom";
            this.colPostnom.Name = "colPostnom";
            this.colPostnom.Visible = false;
            // 
            // colPrenom
            // 
            this.colPrenom.DataPropertyName = "Prenom";
            this.colPrenom.HeaderText = "Prenom";
            this.colPrenom.Name = "colPrenom";
            this.colPrenom.Visible = false;
            // 
            // colNomComplet
            // 
            this.colNomComplet.DataPropertyName = "NomComplet";
            this.colNomComplet.HeaderText = "Nom";
            this.colNomComplet.Name = "colNomComplet";
            this.colNomComplet.ReadOnly = true;
            this.colNomComplet.Width = 366;
            // 
            // txtPNane
            // 
            this.txtPNane.Location = new System.Drawing.Point(92, 174);
            this.txtPNane.Margin = new System.Windows.Forms.Padding(4);
            this.txtPNane.Name = "txtPNane";
            this.txtPNane.Size = new System.Drawing.Size(586, 22);
            this.txtPNane.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Postnom :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 84);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(586, 22);
            this.txtID.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sexe :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(92, 202);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(586, 22);
            this.txtPrenom.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Prénom :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 146);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(586, 22);
            this.txtName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nom :";
            // 
            // cboSexe
            // 
            this.cboSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexe.FormattingEnabled = true;
            this.cboSexe.Location = new System.Drawing.Point(92, 231);
            this.cboSexe.Margin = new System.Windows.Forms.Padding(4);
            this.cboSexe.Name = "cboSexe";
            this.cboSexe.Size = new System.Drawing.Size(586, 24);
            this.cboSexe.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Code :";
            // 
            // bdnav1
            // 
            this.bdnav1.AddNewItem = null;
            this.bdnav1.CountItem = this.bindingNavigatorCountItem;
            this.bdnav1.DeleteItem = null;
            this.bdnav1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnav1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdd1,
            this.btnSave1,
            this.btnDelete1});
            this.bdnav1.Location = new System.Drawing.Point(0, 0);
            this.bdnav1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnav1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnav1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnav1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnav1.Name = "bdnav1";
            this.bdnav1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnav1.Size = new System.Drawing.Size(701, 27);
            this.bdnav1.TabIndex = 20;
            this.bdnav1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAdd1
            // 
            this.btnAdd1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd1.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd1.Image")));
            this.btnAdd1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(24, 24);
            this.btnAdd1.Text = "Ajouter Personne";
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave1.Image = ((System.Drawing.Image)(resources.GetObject("btnSave1.Image")));
            this.btnSave1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(24, 24);
            this.btnSave1.Text = "Enregistrer Personne";
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete1.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete1.Image")));
            this.btnDelete1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(24, 24);
            this.btnDelete1.Text = "Supprimer Personne";
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // dgvTelephone
            // 
            this.dgvTelephone.AllowUserToDeleteRows = false;
            this.dgvTelephone.AllowUserToOrderColumns = true;
            this.dgvTelephone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelephone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDTel,
            this.colId_proprietaire,
            this.colInitial,
            this.colNumero,
            this.dataGridViewTextBoxColumn5});
            this.dgvTelephone.Location = new System.Drawing.Point(20, 277);
            this.dgvTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTelephone.Name = "dgvTelephone";
            this.dgvTelephone.RowHeadersVisible = false;
            this.dgvTelephone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelephone.Size = new System.Drawing.Size(455, 266);
            this.dgvTelephone.TabIndex = 29;
            this.dgvTelephone.SelectionChanged += new System.EventHandler(this.dgvTelephone_SelectionChanged);
            // 
            // colIDTel
            // 
            this.colIDTel.DataPropertyName = "Id";
            this.colIDTel.HeaderText = "Code";
            this.colIDTel.Name = "colIDTel";
            this.colIDTel.ReadOnly = true;
            this.colIDTel.Width = 150;
            // 
            // colId_proprietaire
            // 
            this.colId_proprietaire.DataPropertyName = "Id_proprietaire";
            this.colId_proprietaire.HeaderText = "Id_proprietaire";
            this.colId_proprietaire.Name = "colId_proprietaire";
            this.colId_proprietaire.ReadOnly = true;
            this.colId_proprietaire.Visible = false;
            // 
            // colInitial
            // 
            this.colInitial.DataPropertyName = "Initial";
            this.colInitial.HeaderText = "Initial";
            this.colInitial.Name = "colInitial";
            this.colInitial.Visible = false;
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "Numero";
            this.colNumero.HeaderText = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NumeroComplet";
            this.dataGridViewTextBoxColumn5.HeaderText = "Numéro Tél.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 186;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(99, 169);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Mask = "000000000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(375, 22);
            this.txtNumero.TabIndex = 28;
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(99, 141);
            this.txtInitial.Margin = new System.Windows.Forms.Padding(4);
            this.txtInitial.Mask = "+000";
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(375, 22);
            this.txtInitial.TabIndex = 27;
            // 
            // bdnav2
            // 
            this.bdnav2.AddNewItem = null;
            this.bdnav2.CountItem = this.bindingNavigatorCountItem1;
            this.bdnav2.DeleteItem = null;
            this.bdnav2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnav2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.btnAdd2,
            this.btnSave2,
            this.btnDelete2});
            this.bdnav2.Location = new System.Drawing.Point(0, 0);
            this.bdnav2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bdnav2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bdnav2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bdnav2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bdnav2.Name = "bdnav2";
            this.bdnav2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bdnav2.Size = new System.Drawing.Size(803, 27);
            this.bdnav2.TabIndex = 26;
            this.bdnav2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAdd2
            // 
            this.btnAdd2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd2.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd2.Image")));
            this.btnAdd2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(24, 24);
            this.btnAdd2.Text = "Ajouter Téléphone";
            // 
            // btnSave2
            // 
            this.btnSave2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave2.Image = ((System.Drawing.Image)(resources.GetObject("btnSave2.Image")));
            this.btnSave2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(24, 24);
            this.btnSave2.Text = "Enregistrer Téléphone";
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete2.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete2.Image")));
            this.btnDelete2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(24, 24);
            this.btnDelete2.Text = "Supprimer Téléphone";
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Numéro :";
            // 
            // txtIDTel
            // 
            this.txtIDTel.Location = new System.Drawing.Point(99, 111);
            this.txtIDTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDTel.Name = "txtIDTel";
            this.txtIDTel.ReadOnly = true;
            this.txtIDTel.Size = new System.Drawing.Size(375, 22);
            this.txtIDTel.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Code :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Initial :";
            // 
            // frmPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 610);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmPersonne";
            this.Text = "Saisie des etudiants,adresses et des Téléphones";
            this.Load += new System.EventHandler(this.frmPersonne_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnav1)).EndInit();
            this.bdnav1.ResumeLayout(false);
            this.bdnav1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnav2)).EndInit();
            this.bdnav2.ResumeLayout(false);
            this.bdnav2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPersonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomComplet;
        private System.Windows.Forms.TextBox txtPNane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bdnav1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd1;
        private System.Windows.Forms.ToolStripButton btnSave1;
        private System.Windows.Forms.ToolStripButton btnDelete1;
        private System.Windows.Forms.DataGridView dgvTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId_proprietaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtInitial;
        private System.Windows.Forms.BindingNavigator bdnav2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton btnAdd2;
        private System.Windows.Forms.ToolStripButton btnSave2;
        private System.Windows.Forms.ToolStripButton btnDelete2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}