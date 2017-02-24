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
    public partial class JobForm : Form
    {
        private RaceForm _previousForm;
        private int _healthPoints;
        
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

        public JobForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.PreviousForm = this;
            this.Hide();
            finalForm.Show();
        }

        private void _healthPointCalculation(object sender, EventArgs e) {
            String job = (sender as RadioButton).Text;
            
            switch (job) {

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
    }
}
