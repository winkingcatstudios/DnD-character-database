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
    public partial class AddSpell : Form
    {
        private Form1 form1;

        private AddSpell()
        {
            InitializeComponent();
        }

        public AddSpell(Form1 form1):this()
        {
            this.form1 = form1;
        }

        private void AddSpell_Load(object sender, EventArgs e)
        {            
            this.spellsTableAdapter.Fill(this.appSQLDB.Spells);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var spellRow = (row.DataBoundItem as DataRowView).Row as AppSQLDB.SpellsRow;
            try
            {
                using (var adapter = new AppSQLDBTableAdapters.SpellsByCharacterTableAdapter())
                {
                    adapter.AddToSpellbook(form1.CurrentCharacterName, spellRow.Spell);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
            form1.RefreshSpells();
            this.Close();            
            form1.Activate();
            this.Dispose();
        }
    }
}
