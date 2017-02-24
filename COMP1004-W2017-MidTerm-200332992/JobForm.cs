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
    }
}
