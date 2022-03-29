namespace FinalProject
{
    partial class CreatePlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.CharNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StrUpDown = new System.Windows.Forms.NumericUpDown();
            this.DexUpDown = new System.Windows.Forms.NumericUpDown();
            this.ConUpDown = new System.Windows.Forms.NumericUpDown();
            this.IntUpDown = new System.Windows.Forms.NumericUpDown();
            this.WisUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChaUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.RaceComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.BackgroundComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.appSQLDB = new FinalProject.AppSQLDB();
            this.backgroundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundTableAdapter = new FinalProject.AppSQLDBTableAdapters.BackgroundTableAdapter();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new FinalProject.AppSQLDBTableAdapters.ClassTableAdapter();
            this.raceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceTableAdapter = new FinalProject.AppSQLDBTableAdapters.RaceTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StrUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WisUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSQLDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Name";
            // 
            // CharNameTextbox
            // 
            this.CharNameTextbox.Location = new System.Drawing.Point(103, 10);
            this.CharNameTextbox.Name = "CharNameTextbox";
            this.CharNameTextbox.Size = new System.Drawing.Size(156, 20);
            this.CharNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rolled Stats";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Charisma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Wisdom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Intelligence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Constitution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Dexterity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Stength";
            // 
            // StrUpDown
            // 
            this.StrUpDown.Location = new System.Drawing.Point(18, 90);
            this.StrUpDown.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.StrUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.StrUpDown.Name = "StrUpDown";
            this.StrUpDown.Size = new System.Drawing.Size(48, 20);
            this.StrUpDown.TabIndex = 32;
            this.StrUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // DexUpDown
            // 
            this.DexUpDown.Location = new System.Drawing.Point(91, 90);
            this.DexUpDown.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.DexUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DexUpDown.Name = "DexUpDown";
            this.DexUpDown.Size = new System.Drawing.Size(48, 20);
            this.DexUpDown.TabIndex = 33;
            this.DexUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ConUpDown
            // 
            this.ConUpDown.Location = new System.Drawing.Point(185, 90);
            this.ConUpDown.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ConUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ConUpDown.Name = "ConUpDown";
            this.ConUpDown.Size = new System.Drawing.Size(48, 20);
            this.ConUpDown.TabIndex = 34;
            this.ConUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // IntUpDown
            // 
            this.IntUpDown.Location = new System.Drawing.Point(284, 90);
            this.IntUpDown.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.IntUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.IntUpDown.Name = "IntUpDown";
            this.IntUpDown.Size = new System.Drawing.Size(48, 20);
            this.IntUpDown.TabIndex = 35;
            this.IntUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // WisUpDown
            // 
            this.WisUpDown.Location = new System.Drawing.Point(384, 90);
            this.WisUpDown.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.WisUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.WisUpDown.Name = "WisUpDown";
            this.WisUpDown.Size = new System.Drawing.Size(48, 20);
            this.WisUpDown.TabIndex = 36;
            this.WisUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ChaUpDown
            // 
            this.ChaUpDown.Location = new System.Drawing.Point(484, 90);
            this.ChaUpDown.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ChaUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ChaUpDown.Name = "ChaUpDown";
            this.ChaUpDown.Size = new System.Drawing.Size(48, 20);
            this.ChaUpDown.TabIndex = 37;
            this.ChaUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Race";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RaceComboBox
            // 
            this.RaceComboBox.DataSource = this.raceBindingSource;
            this.RaceComboBox.DisplayMember = "Race";
            this.RaceComboBox.FormattingEnabled = true;
            this.RaceComboBox.Location = new System.Drawing.Point(12, 158);
            this.RaceComboBox.Name = "RaceComboBox";
            this.RaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.RaceComboBox.TabIndex = 39;
            this.RaceComboBox.ValueMember = "Race";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Class";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.DataSource = this.classBindingSource;
            this.ClassComboBox.DisplayMember = "Class";
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(152, 158);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 41;
            this.ClassComboBox.ValueMember = "Class";
            // 
            // BackgroundComboBox
            // 
            this.BackgroundComboBox.DataSource = this.backgroundBindingSource;
            this.BackgroundComboBox.DisplayMember = "Background";
            this.BackgroundComboBox.FormattingEnabled = true;
            this.BackgroundComboBox.Location = new System.Drawing.Point(293, 158);
            this.BackgroundComboBox.Name = "BackgroundComboBox";
            this.BackgroundComboBox.Size = new System.Drawing.Size(121, 21);
            this.BackgroundComboBox.TabIndex = 42;
            this.BackgroundComboBox.ValueMember = "Background";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Background";
            // 
            // appSQLDB
            // 
            this.appSQLDB.DataSetName = "AppSQLDB";
            this.appSQLDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundBindingSource
            // 
            this.backgroundBindingSource.DataMember = "Background";
            this.backgroundBindingSource.DataSource = this.appSQLDB;
            // 
            // backgroundTableAdapter
            // 
            this.backgroundTableAdapter.ClearBeforeFill = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.appSQLDB;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // raceBindingSource
            // 
            this.raceBindingSource.DataMember = "Race";
            this.raceBindingSource.DataSource = this.appSQLDB;
            // 
            // raceTableAdapter
            // 
            this.raceTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(457, 188);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 44;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 223);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BackgroundComboBox);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RaceComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ChaUpDown);
            this.Controls.Add(this.WisUpDown);
            this.Controls.Add(this.IntUpDown);
            this.Controls.Add(this.ConUpDown);
            this.Controls.Add(this.DexUpDown);
            this.Controls.Add(this.StrUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CharNameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "CreatePlayer";
            this.Text = "Create Character";
            this.Load += new System.EventHandler(this.CreatePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StrUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WisUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSQLDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CharNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown StrUpDown;
        private System.Windows.Forms.NumericUpDown DexUpDown;
        private System.Windows.Forms.NumericUpDown ConUpDown;
        private System.Windows.Forms.NumericUpDown IntUpDown;
        private System.Windows.Forms.NumericUpDown WisUpDown;
        private System.Windows.Forms.NumericUpDown ChaUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RaceComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.ComboBox BackgroundComboBox;
        private System.Windows.Forms.Label label11;
        private AppSQLDB appSQLDB;
        private System.Windows.Forms.BindingSource backgroundBindingSource;
        private AppSQLDBTableAdapters.BackgroundTableAdapter backgroundTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource;
        private AppSQLDBTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource raceBindingSource;
        private AppSQLDBTableAdapters.RaceTableAdapter raceTableAdapter;
        private System.Windows.Forms.Button SaveButton;
    }
}