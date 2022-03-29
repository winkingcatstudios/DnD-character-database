namespace FinalProject
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCharStats = new System.Windows.Forms.Label();
            this.pnlCharList = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.characterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appSQLDB = new FinalProject.AppSQLDB();
            this.createCharButton = new System.Windows.Forms.Button();
            this.lblCharList = new System.Windows.Forms.Label();
            this.playingCharPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.spellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concentrationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellsByCharacterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddSpellButton = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PlayingSavesLabel = new System.Windows.Forms.Label();
            this.CaptionPlayingSaveLabel = new System.Windows.Forms.Label();
            this.PlayingSizeLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PlayingSpeedLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PlayingBackgroundLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PlayingClassLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PlayingRaceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PlayingChaLabel = new System.Windows.Forms.Label();
            this.PlayingWisLabel = new System.Windows.Forms.Label();
            this.PlayingIntLabel = new System.Windows.Forms.Label();
            this.PlayingConLabel = new System.Windows.Forms.Label();
            this.PlayingDexLabel = new System.Windows.Forms.Label();
            this.PlayingStrLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangePlayerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayingCharacterNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.characterTableAdapter1 = new FinalProject.AppSQLDBTableAdapters.CharacterTableAdapter();
            this.spellsByCharacterTableAdapter = new FinalProject.AppSQLDBTableAdapters.SpellsByCharacterTableAdapter();
            this.characterInventoryTableAdapter = new FinalProject.AppSQLDBTableAdapters.CharacterInventoryTableAdapter();
            this.pnlCharList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSQLDB)).BeginInit();
            this.playingCharPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsByCharacterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCharStats
            // 
            this.lblCharStats.AutoSize = true;
            this.lblCharStats.Location = new System.Drawing.Point(15, 300);
            this.lblCharStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharStats.Name = "lblCharStats";
            this.lblCharStats.Size = new System.Drawing.Size(114, 17);
            this.lblCharStats.TabIndex = 28;
            this.lblCharStats.Text = "Character Stats: ";
            // 
            // pnlCharList
            // 
            this.pnlCharList.Controls.Add(this.button1);
            this.pnlCharList.Controls.Add(this.dataGridView1);
            this.pnlCharList.Controls.Add(this.createCharButton);
            this.pnlCharList.Controls.Add(this.lblCharList);
            this.pnlCharList.Location = new System.Drawing.Point(4, 14);
            this.pnlCharList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCharList.Name = "pnlCharList";
            this.pnlCharList.Size = new System.Drawing.Size(737, 244);
            this.pnlCharList.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update My Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.characterNameDataGridViewTextBoxColumn,
            this.raceDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.characterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(501, 220);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // characterNameDataGridViewTextBoxColumn
            // 
            this.characterNameDataGridViewTextBoxColumn.DataPropertyName = "CharacterName";
            this.characterNameDataGridViewTextBoxColumn.HeaderText = "CharacterName";
            this.characterNameDataGridViewTextBoxColumn.Name = "characterNameDataGridViewTextBoxColumn";
            this.characterNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raceDataGridViewTextBoxColumn
            // 
            this.raceDataGridViewTextBoxColumn.DataPropertyName = "Race";
            this.raceDataGridViewTextBoxColumn.HeaderText = "Race";
            this.raceDataGridViewTextBoxColumn.Name = "raceDataGridViewTextBoxColumn";
            this.raceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataMember = "Character";
            this.characterBindingSource.DataSource = this.appSQLDB;
            // 
            // appSQLDB
            // 
            this.appSQLDB.DataSetName = "AppSQLDB";
            this.appSQLDB.Namespace = "http://tempuri.org/AppSQLDB.xsd";
            this.appSQLDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createCharButton
            // 
            this.createCharButton.Location = new System.Drawing.Point(556, 212);
            this.createCharButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createCharButton.Name = "createCharButton";
            this.createCharButton.Size = new System.Drawing.Size(177, 28);
            this.createCharButton.TabIndex = 1;
            this.createCharButton.Text = "Create New Character";
            this.createCharButton.UseVisualStyleBackColor = true;
            this.createCharButton.Click += new System.EventHandler(this.createCharButton_Click);
            // 
            // lblCharList
            // 
            this.lblCharList.AutoSize = true;
            this.lblCharList.Location = new System.Drawing.Point(3, 0);
            this.lblCharList.Name = "lblCharList";
            this.lblCharList.Size = new System.Drawing.Size(81, 17);
            this.lblCharList.TabIndex = 0;
            this.lblCharList.Text = "Characters:";
            this.lblCharList.Click += new System.EventHandler(this.lblCharList_Click);
            // 
            // playingCharPanel
            // 
            this.playingCharPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playingCharPanel.Controls.Add(this.dataGridView2);
            this.playingCharPanel.Controls.Add(this.AddSpellButton);
            this.playingCharPanel.Controls.Add(this.label14);
            this.playingCharPanel.Controls.Add(this.label10);
            this.playingCharPanel.Controls.Add(this.PlayingSavesLabel);
            this.playingCharPanel.Controls.Add(this.CaptionPlayingSaveLabel);
            this.playingCharPanel.Controls.Add(this.PlayingSizeLabel);
            this.playingCharPanel.Controls.Add(this.label12);
            this.playingCharPanel.Controls.Add(this.PlayingSpeedLabel);
            this.playingCharPanel.Controls.Add(this.label9);
            this.playingCharPanel.Controls.Add(this.PlayingBackgroundLabel);
            this.playingCharPanel.Controls.Add(this.label13);
            this.playingCharPanel.Controls.Add(this.PlayingClassLabel);
            this.playingCharPanel.Controls.Add(this.label11);
            this.playingCharPanel.Controls.Add(this.PlayingRaceLabel);
            this.playingCharPanel.Controls.Add(this.label8);
            this.playingCharPanel.Controls.Add(this.PlayingChaLabel);
            this.playingCharPanel.Controls.Add(this.PlayingWisLabel);
            this.playingCharPanel.Controls.Add(this.PlayingIntLabel);
            this.playingCharPanel.Controls.Add(this.PlayingConLabel);
            this.playingCharPanel.Controls.Add(this.PlayingDexLabel);
            this.playingCharPanel.Controls.Add(this.PlayingStrLabel);
            this.playingCharPanel.Controls.Add(this.label2);
            this.playingCharPanel.Controls.Add(this.ChangePlayerBtn);
            this.playingCharPanel.Controls.Add(this.label3);
            this.playingCharPanel.Controls.Add(this.label4);
            this.playingCharPanel.Controls.Add(this.PlayingCharacterNameLabel);
            this.playingCharPanel.Controls.Add(this.label5);
            this.playingCharPanel.Controls.Add(this.label1);
            this.playingCharPanel.Controls.Add(this.label6);
            this.playingCharPanel.Controls.Add(this.label7);
            this.playingCharPanel.Controls.Add(this.dataGridView3);
            this.playingCharPanel.Location = new System.Drawing.Point(4, 10);
            this.playingCharPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playingCharPanel.Name = "playingCharPanel";
            this.playingCharPanel.Size = new System.Drawing.Size(1092, 798);
            this.playingCharPanel.TabIndex = 63;
            this.playingCharPanel.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spellDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.castTimeDataGridViewTextBoxColumn,
            this.concentrationDataGridViewCheckBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.spellsByCharacterBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 470);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(1088, 310);
            this.dataGridView2.TabIndex = 38;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // spellDataGridViewTextBoxColumn
            // 
            this.spellDataGridViewTextBoxColumn.DataPropertyName = "Spell";
            this.spellDataGridViewTextBoxColumn.HeaderText = "Spell";
            this.spellDataGridViewTextBoxColumn.Name = "spellDataGridViewTextBoxColumn";
            this.spellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // castTimeDataGridViewTextBoxColumn
            // 
            this.castTimeDataGridViewTextBoxColumn.DataPropertyName = "CastTime";
            this.castTimeDataGridViewTextBoxColumn.HeaderText = "CastTime";
            this.castTimeDataGridViewTextBoxColumn.Name = "castTimeDataGridViewTextBoxColumn";
            this.castTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concentrationDataGridViewCheckBoxColumn
            // 
            this.concentrationDataGridViewCheckBoxColumn.DataPropertyName = "Concentration";
            this.concentrationDataGridViewCheckBoxColumn.HeaderText = "Concentration";
            this.concentrationDataGridViewCheckBoxColumn.Name = "concentrationDataGridViewCheckBoxColumn";
            this.concentrationDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 140;
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "Range";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            this.rangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "School";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spellsByCharacterBindingSource
            // 
            this.spellsByCharacterBindingSource.DataMember = "SpellsByCharacter";
            this.spellsByCharacterBindingSource.DataSource = this.appSQLDB;
            // 
            // AddSpellButton
            // 
            this.AddSpellButton.Location = new System.Drawing.Point(947, 436);
            this.AddSpellButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSpellButton.Name = "AddSpellButton";
            this.AddSpellButton.Size = new System.Drawing.Size(100, 27);
            this.AddSpellButton.TabIndex = 43;
            this.AddSpellButton.Text = "Add Spell";
            this.AddSpellButton.UseVisualStyleBackColor = true;
            this.AddSpellButton.Click += new System.EventHandler(this.AddSpellButton_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.characterInventoryBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 217);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView3.Size = new System.Drawing.Size(1088, 215);
            this.dataGridView3.TabIndex = 42;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // characterInventoryBindingSource
            // 
            this.characterInventoryBindingSource.DataMember = "CharacterInventory";
            this.characterInventoryBindingSource.DataSource = this.appSQLDB;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Items";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 450);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Spells";
            // 
            // PlayingSavesLabel
            // 
            this.PlayingSavesLabel.Location = new System.Drawing.Point(373, 96);
            this.PlayingSavesLabel.Name = "PlayingSavesLabel";
            this.PlayingSavesLabel.Size = new System.Drawing.Size(199, 16);
            this.PlayingSavesLabel.TabIndex = 37;
            this.PlayingSavesLabel.Text = "SAVES GOeS HERE";
            this.PlayingSavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaptionPlayingSaveLabel
            // 
            this.CaptionPlayingSaveLabel.AutoSize = true;
            this.CaptionPlayingSaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionPlayingSaveLabel.Location = new System.Drawing.Point(452, 80);
            this.CaptionPlayingSaveLabel.Name = "CaptionPlayingSaveLabel";
            this.CaptionPlayingSaveLabel.Size = new System.Drawing.Size(52, 17);
            this.CaptionPlayingSaveLabel.TabIndex = 36;
            this.CaptionPlayingSaveLabel.Text = "Saves";
            // 
            // PlayingSizeLabel
            // 
            this.PlayingSizeLabel.Location = new System.Drawing.Point(197, 96);
            this.PlayingSizeLabel.Name = "PlayingSizeLabel";
            this.PlayingSizeLabel.Size = new System.Drawing.Size(108, 16);
            this.PlayingSizeLabel.TabIndex = 35;
            this.PlayingSizeLabel.Text = "Size Goes Here";
            this.PlayingSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(228, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Size";
            // 
            // PlayingSpeedLabel
            // 
            this.PlayingSpeedLabel.Location = new System.Drawing.Point(47, 96);
            this.PlayingSpeedLabel.Name = "PlayingSpeedLabel";
            this.PlayingSpeedLabel.Size = new System.Drawing.Size(57, 16);
            this.PlayingSpeedLabel.TabIndex = 33;
            this.PlayingSpeedLabel.Text = "Speed";
            this.PlayingSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Speed";
            // 
            // PlayingBackgroundLabel
            // 
            this.PlayingBackgroundLabel.Location = new System.Drawing.Point(373, 54);
            this.PlayingBackgroundLabel.Name = "PlayingBackgroundLabel";
            this.PlayingBackgroundLabel.Size = new System.Drawing.Size(199, 16);
            this.PlayingBackgroundLabel.TabIndex = 31;
            this.PlayingBackgroundLabel.Text = "BACKGROUND GOES HERE";
            this.PlayingBackgroundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayingBackgroundLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(427, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Background";
            // 
            // PlayingClassLabel
            // 
            this.PlayingClassLabel.Location = new System.Drawing.Point(179, 54);
            this.PlayingClassLabel.Name = "PlayingClassLabel";
            this.PlayingClassLabel.Size = new System.Drawing.Size(143, 16);
            this.PlayingClassLabel.TabIndex = 29;
            this.PlayingClassLabel.Text = "CLASS GOES HERE";
            this.PlayingClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(228, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Class";
            // 
            // PlayingRaceLabel
            // 
            this.PlayingRaceLabel.Location = new System.Drawing.Point(4, 54);
            this.PlayingRaceLabel.Name = "PlayingRaceLabel";
            this.PlayingRaceLabel.Size = new System.Drawing.Size(136, 16);
            this.PlayingRaceLabel.TabIndex = 27;
            this.PlayingRaceLabel.Text = "RACE GOES HERE";
            this.PlayingRaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Race";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PlayingChaLabel
            // 
            this.PlayingChaLabel.Location = new System.Drawing.Point(595, 159);
            this.PlayingChaLabel.Name = "PlayingChaLabel";
            this.PlayingChaLabel.Size = new System.Drawing.Size(67, 16);
            this.PlayingChaLabel.TabIndex = 25;
            this.PlayingChaLabel.Text = "Charisma";
            this.PlayingChaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayingWisLabel
            // 
            this.PlayingWisLabel.Location = new System.Drawing.Point(468, 159);
            this.PlayingWisLabel.Name = "PlayingWisLabel";
            this.PlayingWisLabel.Size = new System.Drawing.Size(60, 16);
            this.PlayingWisLabel.TabIndex = 24;
            this.PlayingWisLabel.Text = "Wisdom";
            this.PlayingWisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayingIntLabel
            // 
            this.PlayingIntLabel.Location = new System.Drawing.Point(337, 159);
            this.PlayingIntLabel.Name = "PlayingIntLabel";
            this.PlayingIntLabel.Size = new System.Drawing.Size(81, 16);
            this.PlayingIntLabel.TabIndex = 23;
            this.PlayingIntLabel.Text = "Intelligence";
            this.PlayingIntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayingConLabel
            // 
            this.PlayingConLabel.Location = new System.Drawing.Point(224, 159);
            this.PlayingConLabel.Name = "PlayingConLabel";
            this.PlayingConLabel.Size = new System.Drawing.Size(83, 16);
            this.PlayingConLabel.TabIndex = 22;
            this.PlayingConLabel.Text = "Constitution";
            this.PlayingConLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayingDexLabel
            // 
            this.PlayingDexLabel.Location = new System.Drawing.Point(103, 159);
            this.PlayingDexLabel.Name = "PlayingDexLabel";
            this.PlayingDexLabel.Size = new System.Drawing.Size(64, 16);
            this.PlayingDexLabel.TabIndex = 21;
            this.PlayingDexLabel.Text = "Dexterity";
            this.PlayingDexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayingStrLabel
            // 
            this.PlayingStrLabel.Location = new System.Drawing.Point(5, 159);
            this.PlayingStrLabel.Name = "PlayingStrLabel";
            this.PlayingStrLabel.Size = new System.Drawing.Size(59, 16);
            this.PlayingStrLabel.TabIndex = 20;
            this.PlayingStrLabel.Text = "Stength";
            this.PlayingStrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Charisma";
            // 
            // ChangePlayerBtn
            // 
            this.ChangePlayerBtn.Location = new System.Drawing.Point(593, 4);
            this.ChangePlayerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangePlayerBtn.Name = "ChangePlayerBtn";
            this.ChangePlayerBtn.Size = new System.Drawing.Size(140, 28);
            this.ChangePlayerBtn.TabIndex = 2;
            this.ChangePlayerBtn.Text = "Back";
            this.ChangePlayerBtn.UseVisualStyleBackColor = true;
            this.ChangePlayerBtn.Click += new System.EventHandler(this.ChangePlayerBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Wisdom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Intelligence";
            // 
            // PlayingCharacterNameLabel
            // 
            this.PlayingCharacterNameLabel.AutoSize = true;
            this.PlayingCharacterNameLabel.Location = new System.Drawing.Point(60, 4);
            this.PlayingCharacterNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayingCharacterNameLabel.Name = "PlayingCharacterNameLabel";
            this.PlayingCharacterNameLabel.Size = new System.Drawing.Size(191, 17);
            this.PlayingCharacterNameLabel.TabIndex = 1;
            this.PlayingCharacterNameLabel.Text = "PLAYER NAME GOES HERE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Constitution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dexterity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stength";
            // 
            // characterTableAdapter1
            // 
            this.characterTableAdapter1.ClearBeforeFill = true;
            // 
            // spellsByCharacterTableAdapter
            // 
            this.spellsByCharacterTableAdapter.ClearBeforeFill = true;
            // 
            // characterInventoryTableAdapter
            // 
            this.characterInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 822);
            this.Controls.Add(this.playingCharPanel);
            this.Controls.Add(this.pnlCharList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCharList.ResumeLayout(false);
            this.pnlCharList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSQLDB)).EndInit();
            this.playingCharPanel.ResumeLayout(false);
            this.playingCharPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsByCharacterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCharStats;
        private System.Windows.Forms.Panel pnlCharList;
        private System.Windows.Forms.Label lblCharList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private AppSQLDB appSQLDB;
        private System.Windows.Forms.Button createCharButton;
        private AppSQLDBTableAdapters.CharacterTableAdapter characterTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel playingCharPanel;
        private System.Windows.Forms.Button ChangePlayerBtn;
        private System.Windows.Forms.Label PlayingCharacterNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PlayingChaLabel;
        private System.Windows.Forms.Label PlayingWisLabel;
        private System.Windows.Forms.Label PlayingIntLabel;
        private System.Windows.Forms.Label PlayingConLabel;
        private System.Windows.Forms.Label PlayingDexLabel;
        private System.Windows.Forms.Label PlayingStrLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PlayingBackgroundLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label PlayingClassLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label PlayingRaceLabel;
        private System.Windows.Forms.Label PlayingSavesLabel;
        private System.Windows.Forms.Label CaptionPlayingSaveLabel;
        private System.Windows.Forms.Label PlayingSizeLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label PlayingSpeedLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource spellsByCharacterBindingSource;
        private AppSQLDBTableAdapters.SpellsByCharacterTableAdapter spellsByCharacterTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource characterInventoryBindingSource;
        private AppSQLDBTableAdapters.CharacterInventoryTableAdapter characterInventoryTableAdapter;
        private System.Windows.Forms.Button AddSpellButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn concentrationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
    }
}

