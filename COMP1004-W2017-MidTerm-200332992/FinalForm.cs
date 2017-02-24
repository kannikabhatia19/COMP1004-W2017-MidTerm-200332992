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

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void fontStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalFormFontDialog.ShowDialog();
        }
    }
}
