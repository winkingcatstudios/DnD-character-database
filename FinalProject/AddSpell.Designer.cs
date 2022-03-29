namespace FinalProject
{
    partial class AddSpell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appSQLDB = new FinalProject.AppSQLDB();
            this.spellsByCharacterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spellsByCharacterTableAdapter = new FinalProject.AppSQLDBTableAdapters.SpellsByCharacterTableAdapter();
            this.spellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spellsTableAdapter = new FinalProject.AppSQLDBTableAdapters.SpellsTableAdapter();
            this.spellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concentrationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSQLDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsByCharacterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spellDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.castTimeDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.concentrationDataGridViewCheckBoxColumn,
            this.rangeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spellsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // appSQLDB
            // 
            this.appSQLDB.DataSetName = "AppSQLDB";
            this.appSQLDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spellsByCharacterBindingSource
            // 
            this.spellsByCharacterBindingSource.DataMember = "SpellsByCharacter";
            this.spellsByCharacterBindingSource.DataSource = this.appSQLDB;
            // 
            // spellsByCharacterTableAdapter
            // 
            this.spellsByCharacterTableAdapter.ClearBeforeFill = true;
            // 
            // spellsBindingSource
            // 
            this.spellsBindingSource.DataMember = "Spells";
            this.spellsBindingSource.DataSource = this.appSQLDB;
            // 
            // spellsTableAdapter
            // 
            this.spellsTableAdapter.ClearBeforeFill = true;
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
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "School";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concentrationDataGridViewCheckBoxColumn
            // 
            this.concentrationDataGridViewCheckBoxColumn.DataPropertyName = "Concentration";
            this.concentrationDataGridViewCheckBoxColumn.HeaderText = "Concentration";
            this.concentrationDataGridViewCheckBoxColumn.Name = "concentrationDataGridViewCheckBoxColumn";
            this.concentrationDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "Range";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            this.rangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddSpell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddSpell";
            this.Text = "AddSpell";
            this.Load += new System.EventHandler(this.AddSpell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSQLDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsByCharacterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AppSQLDB appSQLDB;
        private System.Windows.Forms.BindingSource spellsByCharacterBindingSource;
        private AppSQLDBTableAdapters.SpellsByCharacterTableAdapter spellsByCharacterTableAdapter;
        private System.Windows.Forms.BindingSource spellsBindingSource;
        private AppSQLDBTableAdapters.SpellsTableAdapter spellsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn concentrationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}