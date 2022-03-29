using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ChangePW : Form
    {
        string username;
        public ChangePW(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(confNewPWTextBox.Text != newPWTextbox.Text)
            {
                MessageBox.Show("New Passwords Entered Do Not Match");
                return;
            }
            using(var adapter = new AppSQLDBTableAdapters.QueriesTableAdapter())
            {
                bool? loginResult = false;
                string loginErrorMsg = "";
                adapter.Sp_CheckPlayerLogin(username, PasswordUtil.ConvertToPWHash(currentPWTextBox.Text), ref loginResult, ref loginErrorMsg);
                if (loginResult.GetValueOrDefault(false))
                {
                    adapter.UpdatePlayerPassword(PasswordUtil.ConvertToPWHash(newPWTextbox.Text), username);
                    MessageBox.Show("Password Succesfully Changed!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(loginErrorMsg);
                }
;            }
        }
    }
}
