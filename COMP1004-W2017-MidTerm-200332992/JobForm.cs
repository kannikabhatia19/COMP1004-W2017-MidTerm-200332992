using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * App Name: Character Generator
 * Author's Name: Kannika Minnie Bhatia
 * App Creation Date: 24 Febuary 2017
 * Student ID: 200332992
 */

namespace COMP1004_W2017_MidTerm_200332992
{
    public partial class JobForm : Form
    {
        //PRIVATE INSTANCE VARIABLES=============================================
        private RaceForm _previousForm;
        private int _healthPoints;
        private string _job;

        //CONSTRUCTOR===========================================================
        public JobForm()
        {
            InitializeComponent();
        }

        //PROPERTIES============================================================
        public RaceForm PreviousForm
        {
            get
            {
                return _previousForm;
            }
            set
            {
                _previousForm = (RaceForm)value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return _healthPoints;
            }

            set
            {
                _healthPoints = value;
            }
        }

        public string Job
        {
            get
            {
                return _job;
            }

            set
            {
                _job = value;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.PreviousForm = this;
            this.Hide();
            finalForm.Show();
        }

        private void _healthPointCalculation(object sender, EventArgs e) {
            this.Job = (sender as RadioButton).Text;
            
            switch (this.Job) {

                case "Soldier":
                    HealthPoints = 30 + PreviousForm.PreviousForm.End;
                    break;
                case "Rogue":
                    HealthPoints = 28 + PreviousForm.PreviousForm.Dex;
                    break;
                case "Magicker":
                    HealthPoints = 15 + PreviousForm.PreviousForm.Intt;
                    break;
                case "Cultist":
                    HealthPoints = 24 + PreviousForm.PreviousForm.Cha;
                    break;

            }
            this.HealthPointDisplayLabel.Text = HealthPoints.ToString();
        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            this.HealthPointDisplayLabel.Text = "";
        }

        private void JobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.PreviousForm.PreviousForm.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
