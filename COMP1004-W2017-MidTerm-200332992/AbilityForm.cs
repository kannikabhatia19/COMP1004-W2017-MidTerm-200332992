using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTerm_200332992
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();

        //PRIVATE INSTANCE VARIABLES=============================================
        private int _str;
        private int _dex;
        private int _end;
        private int _intt;
        private int _per;
        private int _cha;

        //PROPERTIES============================================================
        public AbilityForm()
        {
            InitializeComponent();
        }

        public int Str
        {
            get
            {
                return _str;
            }

            set
            {
                if (value <= 50 && value >= 3)
                {
                    _str = value;
                }
                else if (value > 50)
                {
                    _str = 50;
                }
                else if (value < 3) {
                    _str = 3;
                }
            }
        }

        public int Dex
        {
            get
            {
                return _dex;
            }

            set
            {
                if (value <= 50 && value >= 3)
                {
                    _dex = value;
                }
                else if (value > 50)
                {
                    _dex = 50;
                }
                else if (value < 3)
                {
                    _dex = 3;
                }
            }
        }

        public int End
        {
            get
            {
                return _end;
            }

            set
            {
                if (value <= 50 && value >= 3)
                {
                    _end = value;
                }
                else if (value > 50)
                {
                    _end = 50;
                }
                else if (value < 3)
                {
                    _end = 3;
                }
            }
        }

        public int Intt
        {
            get
            {
                return _intt;
            }

            set
            {
                if (value <= 50 && value >= 3)
                {
                    _intt = value;
                }
                else if (value > 50)
                {
                    _intt = 50;
                }
                else if (value < 3)
                {
                    _intt = 3;
                }
            }
        }

        public int Per
        {
            get
            {
                return _per;
            }

            set
            {
                if (value <= 50 && value >= 3)
                {
                    _per = value;
                }
                else if (value > 50)
                {
                    _per = 50;
                }
                else if (value < 3)
                {
                    _per = 3;
                }
            }
        }

        public int Cha
        {
            get
            {
                return _cha;
            }

            set
            {
                if (value <= 50 && value >= 3)
                {
                    _cha = value;
                }
                else if (value > 50)
                {
                    _cha = 50;
                }
                else if (value < 3)
                {
                    _cha = 3;
                }
            }
        }


        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            this.Str = Roll3D10();
            STRTextBox.Text = this.Str.ToString();
            this.Dex = Roll3D10();
            DEXTextBox.Text = this.Dex.ToString();
            this.End = Roll3D10();
            ENDTextBox.Text = this.End.ToString();
            this.Intt = Roll3D10();
            INTTextBox.Text = this.Intt.ToString();
            this.Per = Roll3D10();
            PERTextBox.Text = this.Per.ToString();
            this.Cha = Roll3D10();
            CHATextBox.Text = this.Cha.ToString();
            //Debug.WriteLine(Roll3D10().ToString());
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            RaceForm raceForm = new RaceForm();
            raceForm.PreviousForm = this;
            raceForm.Show();
            this.Hide();
        }
        
    }
}
