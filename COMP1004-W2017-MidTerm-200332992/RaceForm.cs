using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTerm_200332992
{
    public partial class RaceForm : Form
    {
        private Dictionary<string, int> _characterScoreBefore = new Dictionary<string, int>();

        private Dictionary<string, int> _characterScoreAfter = new Dictionary<string, int>();
        private int _racialBonus;
        private AbilityForm _previousForm;

        public RaceForm()
        {
            InitializeComponent();
        }

        public int RacialBonus
        {
            get
            {
                return _racialBonus;
            }

            set
            {
                _racialBonus = value;
            }
        }

        public AbilityForm PreviousForm
        {
            get
            {
                return _previousForm;
            }

            set
            {
                _previousForm = (AbilityForm)value;
            }
        }

        private void HumanRadioButton_Click(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;
            _storePointBeforeChange();
            PreviousForm.Str += 5;
            PreviousForm.Dex += 5;
            PreviousForm.End += 5;
            PreviousForm.Intt += 5;
            PreviousForm.Per += 5;
            PreviousForm.Cha += 5;
            _storePointAfterChange();
        }

        private void _storePointBeforeChange() {
            _characterScoreBefore.Add("Str", PreviousForm.Str);
            _characterScoreBefore.Add("Dex", PreviousForm.Dex);
            _characterScoreBefore.Add("End", PreviousForm.End);
            _characterScoreBefore.Add("Intt", PreviousForm.Intt);
            _characterScoreBefore.Add("Per", PreviousForm.Per);
            _characterScoreBefore.Add("Cha", PreviousForm.Cha);
        }

        private void _storePointAfterChange()
        {
            _characterScoreAfter.Add("Str", PreviousForm.Str);
            _characterScoreAfter.Add("Dex", PreviousForm.Dex);
            _characterScoreAfter.Add("End", PreviousForm.End);
            _characterScoreAfter.Add("Intt", PreviousForm.Intt);
            _characterScoreAfter.Add("Per", PreviousForm.Per);
            _characterScoreAfter.Add("Cha", PreviousForm.Cha);
        }

        private void _calculateRacialBonus() {
            int before, after, bonus = 0;
            
            for (int i = 0; i < _characterScoreAfter.Count; i++) {
                var item = _characterScoreBefore.ElementAt(i);
                before = item.Value;
                var item2 = _characterScoreAfter.ElementAt(i);
                after = item2.Value;
                bonus += after - before;
            }
            this.RacialBonus = bonus;
            this.RacialBonusTextBox.Text = this.RacialBonus.ToString();
        }

        private void DwarfRadioButton_Click(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            _storePointBeforeChange();
            PreviousForm.Str += 20;
            PreviousForm.Per += 20;
            PreviousForm.Cha -= 10;
            _storePointAfterChange();
        }

        private void ElfRadioButton_Click(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            _storePointBeforeChange();
            PreviousForm.Dex += 15;
            PreviousForm.Cha += 15;
            _storePointAfterChange();
        }

        private void HalflingRadioButton_Click(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            _storePointBeforeChange();
            PreviousForm.Str += 10;
            PreviousForm.Dex += 20;
            PreviousForm.Intt += 20;
            _storePointAfterChange();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm();
            jobForm.PreviousForm = this;
            this.Hide();
            jobForm.Show();
            
        }
    }
}
