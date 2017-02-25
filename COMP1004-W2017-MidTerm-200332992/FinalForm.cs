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
    public partial class FinalForm : Form
    {
        private JobForm _previousForm;
        private FontFamily _fontName;
        private float _fontSize;
        private FontStyle _fontStyle;

        public FinalForm()
        {
            InitializeComponent();
        }

        public JobForm PreviousForm
        {
            get
            {
                return _previousForm;
            }

            set
            {
                _previousForm = (JobForm)value;
            }
        }

        public FontFamily FontName
        {
            get
            {
                return _fontName;
            }

            set
            {
                _fontName = value;
            }
        }

        public float FontSize
        {
            get
            {
                return _fontSize;
            }

            set
            {
                _fontSize = value;
            }
        }

        public FontStyle FontStyle
        {
            get
            {
                return _fontStyle;
            }

            set
            {
                _fontStyle = value;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void fontStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = FinalFormFontDialog.ShowDialog();
            if (result == DialogResult.OK) {
                this.FontName = FinalFormFontDialog.Font.FontFamily;
                this.FontSize = FinalFormFontDialog.Font.Size;
                this.FontStyle = FinalFormFontDialog.Font.Style;
                this.AgeLabel.Font = new Font(this.FontName, this.FontSize, this.FontStyle);
            }
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            string race = PreviousForm.PreviousForm.Race;

            switch (race) {
                case "Human":
                    CharacterPictureBox.Image = Properties.Resources.M_Human1;
                    break;
                case "Dwarf":
                    CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
                    break;
                case "Elf":
                    CharacterPictureBox.Image = Properties.Resources.M_Elf1;
                    break;
                case "Halfling":
                    CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
                    break;
            }

            this.STRTextBox.Text = this.PreviousForm.PreviousForm.PreviousForm.Str.ToString();
            this.DEXTextBox.Text = this.PreviousForm.PreviousForm.PreviousForm.Dex.ToString();
            this.ENDTextBox.Text = this.PreviousForm.PreviousForm.PreviousForm.End.ToString();
            this.INTTextBox.Text = this.PreviousForm.PreviousForm.PreviousForm.Intt.ToString();
            this.PERTextBox.Text = this.PreviousForm.PreviousForm.PreviousForm.Per.ToString();
            this.CHATextBox.Text = this.PreviousForm.PreviousForm.PreviousForm.Cha.ToString();

            this.JobTextBox.Text = this.PreviousForm.Job;
            this.HealthPointsTextBox.Text = this.PreviousForm.HealthPoints.ToString();
            this.RaceTextBox.Text = this.PreviousForm.PreviousForm.Race;

        }

        private void FinalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.PreviousForm.Close();
                this.PreviousForm.PreviousForm.Close();
                this.PreviousForm.PreviousForm.PreviousForm.Close();
            }
            else {
                e.Cancel = true;
            }
        }
    }
}
