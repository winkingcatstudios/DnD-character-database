using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateLogin();
                LoginSuccessFully = true;
                Username = UsernameTextBox.Text;
                this.Close();
            }
            catch (LoginException LEx)
            {
                MessageBox.Show(LEx.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

        }

        public bool LoginSuccessFully { get; private set; } = false;
        public string Username { get; private set; }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {

            
            using(var adapter = new AppSQLDBTableAdapters.QueriesTableAdapter())
            {
                adapter.RegisterPlayerQuery(UsernameTextBox.Text, PasswordUtil.ConvertToPWHash(PasswordTextBox.Text));
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
            LoginSuccessFully = true;
            Username = UsernameTextBox.Text;
            this.Close();
        }

        /// <summary>
        /// Throws Exception On Failed Login
        /// </summary>
        private void validateLogin()
        {
            bool? validationResult = new bool?();
            string ErrorMessage = "Error Attempting Login";
            using (var adapter = new AppSQLDBTableAdapters.QueriesTableAdapter())
            {
                adapter.Sp_CheckPlayerLogin(UsernameTextBox.Text, PasswordUtil.ConvertToPWHash(PasswordTextBox.Text), ref validationResult, ref ErrorMessage);
            }
            if (!validationResult.GetValueOrDefault(false))
            {
                throw new LoginException(ErrorMessage);
            }
        }

       
    }
}
