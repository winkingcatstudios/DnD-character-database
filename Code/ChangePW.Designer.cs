namespace FinalProject
{
    partial class ChangePW
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.currentPWTextBox = new System.Windows.Forms.TextBox();
            this.newPWTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confNewPWTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentPWTextBox
            // 
            this.currentPWTextBox.Location = new System.Drawing.Point(136, 22);
            this.currentPWTextBox.Name = "currentPWTextBox";
            this.currentPWTextBox.Size = new System.Drawing.Size(209, 20);
            this.currentPWTextBox.TabIndex = 2;
            this.currentPWTextBox.UseSystemPasswordChar = true;
            // 
            // newPWTextbox
            // 
            this.newPWTextbox.Location = new System.Drawing.Point(136, 58);
            this.newPWTextbox.Name = "newPWTextbox";
            this.newPWTextbox.Size = new System.Drawing.Size(209, 20);
            this.newPWTextbox.TabIndex = 4;
            this.newPWTextbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // confNewPWTextBox
            // 
            this.confNewPWTextBox.Location = new System.Drawing.Point(136, 95);
            this.confNewPWTextBox.Name = "confNewPWTextBox";
            this.confNewPWTextBox.Size = new System.Drawing.Size(209, 20);
            this.confNewPWTextBox.TabIndex = 6;
            this.confNewPWTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm New Password";
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 194);
            this.Controls.Add(this.confNewPWTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPWTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPWTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ChangePW";
            this.Text = "ChangePW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox currentPWTextBox;
        private System.Windows.Forms.TextBox newPWTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confNewPWTextBox;
        private System.Windows.Forms.Label label3;
    }
}