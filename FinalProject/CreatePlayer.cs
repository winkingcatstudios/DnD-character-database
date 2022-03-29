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
    public partial class CreatePlayer : Form
    {
        Form1 form1;
        public CreatePlayer(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CreatePlayer_Load(object sender, EventArgs e)
        {            
            this.raceTableAdapter.Fill(this.appSQLDB.Race);
            this.classTableAdapter.Fill(this.appSQLDB.Class);           
            this.backgroundTableAdapter.Fill(this.appSQLDB.Background);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var adapter = new AppSQLDBTableAdapters.QueriesTableAdapter())
                {
                    adapter.Sp_AddCharacter(
                        CharNameTextbox.Text
                        , ((RaceComboBox.SelectedItem as DataRowView).Row as AppSQLDB.RaceRow).Race
                        , ((ClassComboBox.SelectedItem as DataRowView).Row as AppSQLDB.ClassRow).Class
                        , ((BackgroundComboBox.SelectedItem as DataRowView).Row as AppSQLDB.BackgroundRow).Background
                        , Decimal.ToInt32(StrUpDown.Value)
                        , this.form1.username
                        , Decimal.ToInt32(DexUpDown.Value)
                        , Decimal.ToInt32(ConUpDown.Value)
                        , Decimal.ToInt32(IntUpDown.Value)
                        , Decimal.ToInt32(WisUpDown.Value)
                        , Decimal.ToInt32(ChaUpDown.Value)
                        );

                    form1.RefreshChars();
                    this.Close();
                    form1.Activate();
                    this.Dispose();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
