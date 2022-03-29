using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public string username { private set; get; }

        private Form1()
        {
            InitializeComponent();
            //ResetButtonsAndText();
        }

        public Form1(string username):this()
        {
            this.username = username;
            RefreshChars();
        }
        public void RefreshChars()
        {
            try
            {
                this.characterTableAdapter1.FillBy(this.appSQLDB.Character, username);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        /*
        private void btnStatSubmit_Click(object sender, EventArgs e)
        {
            // Try to parse all the stat input strings to ints
            if (int.TryParse(txtStrInput.Text, out int tmpStr) && int.TryParse(txtDexInput.Text, out int tmpDex)
                && int.TryParse(txtConInput.Text, out int tmpCon) && int.TryParse(txtIntInput.Text, out int tmpIntel)
                && int.TryParse(txtWisInput.Text, out int tmpWis) && int.TryParse(txtChaInput.Text, out int tmpCha))
            {
                // starting stats shouldn't be below 6 or above 18.
                if (tmpStr < 6 || tmpStr > 18 || tmpDex < 6 || tmpDex > 18 || tmpCon < 6 || tmpCon > 18 ||
                    tmpIntel < 6 || tmpIntel > 18 || tmpWis < 6 || tmpWis > 18 || tmpCha < 6 || tmpCha > 18)
                {
                    // Do nothing, instructions are clear enough for this demo
                }
                else //  valid input
                {
                    // Set stats
                    str = tmpStr;
                    dex = tmpDex;
                    con = tmpCon;
                    intel = tmpIntel;
                    wis = tmpWis;
                    cha = tmpCha;

                    // Hide Stat select buttons
                    pnlSelectStats.Visible = false;
                    
                    // Show item select buttons
                    pnlItemSelect.Visible = true;

                    // Defaults
                    rbItemLeatherArmor.Checked = true;
                    cbItemBedroll.Checked = false;
                    cbItemLightCrossbow.Checked = false;
                    cbItemMace.Checked = false;
                    cbItemShield.Checked = false;
                    cbItemShortbow.Checked = false;
                    
                }
            }
        }
        */
        /*
        private void ResetButtonsAndText()
        {
            pnlBackground.Visible = false;
            pnlClass.Visible = false;
            pnlRace.Visible = false;
            pnlCreatePlayer.Visible = false;
            pnlSelectStats.Visible = false;
            pnlCreateChar.Visible = false;
            pnlViewChar.Visible = false;
            pnlCharList.Visible = false;
            pnlItemSelect.Visible = false;
            pnlSpellDivineSelect.Visible = false;
            pnlSpellArcaneSelect.Visible = false;

            btnReset.Visible = false;

            // Clear textboxes to defaults
            txtCharCreateName.Text = string.Empty;
            txtCharCreatePassword.Text = string.Empty;
            txtCharCreateUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtStrInput.Text = "10";
            txtDexInput.Text = "10";
            txtConInput.Text = "10";
            txtIntInput.Text = "10";
            txtWisInput.Text = "10";
            txtChaInput.Text = "10";
            txtLoginUsername.Text = string.Empty;
            txtLoginPassword.Text = string.Empty;
            lblCharStatDisplay.Text = "Character Stats:";
            lblItemDisplay.Text = "Items:";
            lblAbilitiesSpellsDisplay.Text = "Abilities and Spells";

            // Reset player creation vars
            player = null;
            name = null;
            race = null;
            clas = null;
            background = null;
            str = 0;
            dex = 0;
            con = 0;
            intel = 0;
            wis = 0;
            cha = 0;
            movement = 0;
            size = null;
        }

        // Hides buttons beyond first race selection, aka button reset
        private void CharCreateStartButtons()
        {
            ResetButtonsAndText();

            // Show first buttons
            pnlRace.Visible = true;
            btnReset.Visible = true;

            // Default
            rbDragonborn.Checked = true;
        }

        

        #region NOT USING THESE, COLLAPSE 'EM
        // COLLAPSE THESE FOR YOUR SANITY, not deleting as I might use them later #lazyCoding
        private void rbDragonborn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHighElf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHillDwarf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHuman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLightFootHalfling(object sender, EventArgs e)
        {

        }

        private void rbCleric_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFighter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbRogue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSorcerer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbWizard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAcolyte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCriminal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOutlander_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSoldier_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        // Purchase a vehicle for testing, only 1 may be purchased
        private void btnChooseRace_Click_1(object sender, EventArgs e)
        {
            if (rbDragonborn.Checked)
            {
                race = "Dragonborn";
            }
            else if (rbHighElf.Checked)
            {
                race = "High Elf";
            }
            else if (rbHillDwarf.Checked)
            {
                race = "Hill Dwarf";
            }
            else if (rbHuman.Checked)
            {
                race = "Human";
            }
            else if (rbLightfootHalfling.Checked)
            {
                race = "Lightfoot Halfling";
            }
            else
            {
                // Something broke, don't do anything
            }

            // Hide Race buttons
            pnlRace.Visible = false;

            // Show Class buttons
            pnlClass.Visible = true;

            // Default
            rbCleric.Checked = true;
        }

        private void btnChooseClass_Click_1(object sender, EventArgs e)
        {
            if (rbCleric.Checked)
            {
                clas = "Cleric";
            }
            else if (rbFighter.Checked)
            {
                clas = "Fighter";
            }
            else if (rbRogue.Checked)
            {
                clas = "Rogue";
            }
            else if (rbSorcerer.Checked)
            {
                clas = "Sorcerer";
            }
            else if (rbWizard.Checked)
            {
                clas = "Wizard";
            }
            else
            {
                //Something broke, don't do anything
            }

            // Hide Class buttons
            pnlClass.Visible = false;

            // Show Background buttons
            pnlBackground.Visible = true;

            // Default
            rbAcolyte.Checked = true;
        }

        private void btnChooseBackground_Click(object sender, EventArgs e)
        {
            if (rbAcolyte.Checked)
            {
                background = "Acolyte";
            }
            else if (rbCriminal.Checked)
            {
                background = "Criminal";
            }
            else if (rbOutlander.Checked)
            {
                background = "Outlander";
            }
            else if (rbSage.Checked)
            {
                background = "Sage";
            }
            else if (rbSoldier.Checked)
            {
                background = "Soldier";
            }
            else
            {
                // Something broke, don't do anything
            }

            // Hide Background buttons
            pnlBackground.Visible = false;

            // Show Stat select buttons
            pnlSelectStats.Visible = true;

        }

        

        // This starts player creation, top button 1
        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            ResetButtonsAndText();
            pnlCreatePlayer.Visible = true;
        }

        // This starts char creation, top button 2
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            ResetButtonsAndText();
            CharCreateStartButtons();
        }

        // This starts char view, top button 3
        private void btnViewChar_Click(object sender, EventArgs e)
        {
            ResetButtonsAndText();

            // Show login panel
            pnlViewChar.Visible = true;
        }

        private void btnSubmitPlayer_Click(object sender, EventArgs e)
        {


            // foster, code to validate input and hash pass. txtUsername and txtPassword have the input
            // foster, save player to DB here

            ResetButtonsAndText();
        }

        

        private void btnCharCreateSubmit_Click(object sender, EventArgs e)
        {
            // foster, code to check if username is in DB and password is correct. Wrap this pass check around code below
            // txtCharCreateUsername, txtCharCreatePassword, and txtCharCreateName have input
            

            // foster, movement and size come from race, pull those from DB based on race selection
            // Below is sample code that should be removed later
            movement = 30;
            size = "Medium";

            // foster, stats need to be supplimented with bonuses from race table
            // str += *bonus from race*

            // tmp char before saving to DB
            Character tmpChar = new Character(txtCharCreateUsername.Text, txtCharCreateName.Text, race, clas, 
                background, str, dex, con, intel, wis, cha, movement, size);

            // foster, save character to DB, this is where most of the queries come in.
            // Step 1: create character w/ char name, player name, race, class, and background
            // Step 2: player input stats + racial stats = stats to save for char
            // Step 3: display character stats and starting items (from background) in character stats and item lists,
            // can just me a newline list pulled from character, class, and race tables

            // Don't use ResetButtonsAndText here or it will kill your stats, use a subet of that function
            pnlBackground.Visible = false;
            pnlClass.Visible = false;
            pnlRace.Visible = false;
            pnlCreatePlayer.Visible = false;
            pnlSelectStats.Visible = false;
            pnlCreateChar.Visible = false;
            pnlViewChar.Visible = false;
            pnlCharList.Visible = false;
            pnlItemSelect.Visible = false;
            pnlSpellDivineSelect.Visible = false;
            pnlSpellArcaneSelect.Visible = false;
            btnReset.Visible = false;

            // Display characters stats
            lblCharStatDisplay.Text += "\n -Strength: " + tmpChar.Str;
            lblCharStatDisplay.Text += "\n -Dexterity: " + tmpChar.Dex;
            lblCharStatDisplay.Text += "\n -Constitution: " + tmpChar.Con;
            lblCharStatDisplay.Text += "\n -Intelligence: " + tmpChar.Intel;
            lblCharStatDisplay.Text += "\n -Wisdom: " + tmpChar.Wis;
            lblCharStatDisplay.Text += "\n -Charisma: " + tmpChar.Cha;
            lblCharStatDisplay.Text += "\n -Size: " + size;
            lblCharStatDisplay.Text += "\n -Movement: " + movement;

            // Display character items (starting items + selected)
            lblItemDisplay.Text += "\n -Backpack"; // sample output, delete later

            // Display character abilities and spells (race and class tables + selected)
            lblAbilitiesSpellsDisplay.Text += "\n -Darkvision"; // sample output. delete later
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            
            // Show char list panel, this is the one thing I didn't think too much about. How do you want to display
            // characters and allow them to be selected? Once selected, it's easy to show their stats/items/abilities
            // just like we do in btnCharCreateSubmit_Click

            pnlViewChar.Visible = false;
            pnlCharList.Visible = true;
        }

        private void btnItemSubmit_Click(object sender, EventArgs e)
        {
            // foster, code here to add items to inventory

            // Hide item select buttons
            pnlItemSelect.Visible = false;

            // Show character name panel if not magic user, divine spells if cleric, arcane spells if sorcerer/wizard

            //for testing, everyone is magic user
            if(clas == "Cleric")
            {
                pnlSpellDivineSelect.Visible = true;
            }
            else if (clas == "Sorcerer" || clas == "Wizard")
            {
                pnlSpellArcaneSelect.Visible = true;
            }
            else
            {
                pnlCreateChar.Visible = true;
            }


            // Defaults          
            cbSpellBless.Checked = false;
            cbSpellSacredFlame.Checked = false;
            cbSpellLight.Checked = false;
            cbSpellCureWounds.Checked = false;
            cbSpellShieldOfFaith.Checked = false;

            cbSpellFIreBolt.Checked = false;
            cbSpellMageHand.Checked = false;
            cbSpellChillTouch.Checked = false;
            cbSpellFogCloud.Checked = false;
            cbSpellShield.Checked = false;
            cbSpellMagicMissile.Checked = false;
        }

        private void btnSpellDivineSubmit_Click(object sender, EventArgs e)
        {
            // foster, code here to add spells to spellbook

            // Hide spell panel
            pnlSpellDivineSelect.Visible = false;

            // Show character name panel if not magic user
            pnlCreateChar.Visible = true;
        }

        private void btnSpellArcaneSubmit_Click(object sender, EventArgs e)
        {
            // foster, code here to add spells to spellbook

            // Hide spell panel
            pnlSpellArcaneSelect.Visible = false;

            // Show character name panel if not magic user
            pnlCreateChar.Visible = true;
        }
        */
        private void lblCharList_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var charRow = (row.DataBoundItem as DataRowView).Row as AppSQLDB.CharacterRow;
            pnlCharList.Hide();
            PlayCharacter(charRow.CharacterName);
        }
        public string CurrentCharacterName { private set; get; }
        private void PlayCharacter(string CharacterName)
        {
            CurrentCharacterName = CharacterName;
            AppSQLDB.CharacterDetailsRow thisCharDetails;
            using (var charDetailAdapter = new AppSQLDBTableAdapters.CharacterDetailsTableAdapter())
            {
                thisCharDetails = charDetailAdapter.GetData(CharacterName)[0];
            }
            PlayingBackgroundLabel.Text = thisCharDetails.Background;
            PlayingChaLabel.Text = thisCharDetails.Charisma.ToString();
            PlayingCharacterNameLabel.Text = thisCharDetails.CharacterName;
            PlayingClassLabel.Text = thisCharDetails.Class;
            PlayingConLabel.Text = thisCharDetails.Constitution.ToString();
            PlayingDexLabel.Text = thisCharDetails.Dexterity.ToString();
            PlayingIntLabel.Text = thisCharDetails.Intelligence.ToString();
            PlayingRaceLabel.Text = thisCharDetails.Race;
            PlayingSavesLabel.Text = GenerateSaveString(thisCharDetails);
            PlayingSizeLabel.Text = thisCharDetails.Size;
            PlayingSpeedLabel.Text = thisCharDetails.Speed.ToString();
            PlayingStrLabel.Text = thisCharDetails.Strength.ToString();
            PlayingWisLabel.Text = thisCharDetails.Wisdon.ToString();

            RefreshInv();
            RefreshSpells();


            playingCharPanel.Show();
        }
        public void RefreshSpells()
        {
            this.spellsByCharacterTableAdapter.Fill(this.appSQLDB.SpellsByCharacter, CurrentCharacterName);
        }
        public void RefreshInv()
        {
            this.characterInventoryTableAdapter.Fill(this.appSQLDB.CharacterInventory, CurrentCharacterName);
        }
        private static string GenerateSaveString(AppSQLDB.CharacterDetailsRow thisCharDetails)
        {
            string saveStr = "";
            bool populated = false;
            if (thisCharDetails.CharismaSave)
            {
                if (populated)
                    saveStr += ", ";
                saveStr += "Charisma";
                populated = true;
            }
            if (thisCharDetails.ConstitutionSave)
            {
                if (populated)
                    saveStr += ", ";
                saveStr += "Constitution";
                populated = true;
            }
            if (thisCharDetails.DexteritySave)
            {
                if (populated)
                    saveStr += ", ";
                saveStr += "Dexterity";
                populated = true;
            }
            if (thisCharDetails.IntelligenceSave)
            {
                if (populated)
                    saveStr += ", ";
                saveStr += "Intelligence";
                populated = true;
            }
            if (thisCharDetails.StrengthSave)
            {
                if (populated)
                    saveStr += ", ";
                saveStr += "Strength";
                populated = true;
            }
            if (thisCharDetails.WidsomSave)
            {
                if (populated)
                    saveStr += ", ";
                saveStr += "Wisdom";
                populated = true;
            }
            return saveStr;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var CPWScreen = new ChangePW(username);
            CPWScreen.Show();
            CPWScreen.Activate();
        }

        private void ChangePlayerBtn_Click(object sender, EventArgs e)
        {
            playingCharPanel.Hide();
            pnlCharList.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddSpellButton_Click(object sender, EventArgs e)
        {
            var AddSpellWindow = new AddSpell(this);
            AddSpellWindow.Show();
            AddSpellWindow.Activate();
        }

        private void createCharButton_Click(object sender, EventArgs e)
        {
            var cpWin = new CreatePlayer(this);
            cpWin.Show();
            cpWin.Activate();
        }
    }
}
