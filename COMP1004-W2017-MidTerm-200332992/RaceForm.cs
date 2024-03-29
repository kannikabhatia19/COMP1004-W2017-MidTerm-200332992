﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class RaceForm : Form
    {
        //PRIVATE INSTANCE VARIABLES=============================================
        private Dictionary<string, int> _scoreBefore = new Dictionary<string, int>();
        private Dictionary<string, int> _scoreAfter = new Dictionary<string, int>();
        private int _racialBonus;
        private AbilityForm _previousForm;
        private string _race;

        //CONSTRUCTOR===========================================================
        public RaceForm()
        {
            InitializeComponent();
        }

        //PROPERTIES============================================================
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

        public string Race
        {
            get
            {
                return _race;
            }

            set
            {
                _race = value;
            }
        }

        private void _clearStorePoint()
        {
            for (int i = 0; i < _scoreAfter.Count; i++)
            {
                var item = _scoreAfter.ElementAt(i);
                _scoreAfter[item.Key] = 0;
            }
        }

        private void _storePointBeforeChange() {
            //Debug.WriteLine((PreviousForm.Str).ToString());
            _scoreBefore["Str"] = PreviousForm.Str;
            _scoreBefore["Dex"] = PreviousForm.Dex;
            _scoreBefore["End"] = PreviousForm.End;
            _scoreBefore["Intt"] = PreviousForm.Intt;
            _scoreBefore["Per"] = PreviousForm.Per;
            _scoreBefore["Cha"] = PreviousForm.Cha;
        }

        private void _storePointAfterChange() {
            PreviousForm.Str = _scoreAfter["Str"];
            PreviousForm.Dex = _scoreAfter["Dex"];
            PreviousForm.End = _scoreAfter["End"];
            PreviousForm.Intt = _scoreAfter["Intt"];
            PreviousForm.Per = _scoreAfter["Per"];
            PreviousForm.Cha = _scoreAfter["Cha"];
        }
        private void _initializeScore() {
            _scoreBefore.Add("Str", 0);
            _scoreBefore.Add("Dex", 0);
            _scoreBefore.Add("End", 0);
            _scoreBefore.Add("Intt", 0);
            _scoreBefore.Add("Per", 0);
            _scoreBefore.Add("Cha", 0);

            _scoreAfter.Add("Str", 0);
            _scoreAfter.Add("Dex", 0);
            _scoreAfter.Add("End", 0);
            _scoreAfter.Add("Intt", 0);
            _scoreAfter.Add("Per", 0);
            _scoreAfter.Add("Cha", 0);
        }
        private void _calculateRacialBonus() {
            int before = 0, after = 0, bonus = 0;
            
            for (int i = 0; i < _scoreAfter.Count; i++) {
                var item = _scoreBefore.ElementAt(i);
                before = item.Value;
                var item2 = _scoreAfter.ElementAt(i);
                after = item2.Value;
                bonus += after - before;
            }
            this.RacialBonus = bonus;
            this.RacialBonusTextBox.Text = this.RacialBonus.ToString();
        }

        private void _radioButton_Click(object sender, EventArgs e)
        {

            this.Race = (sender as RadioButton).Text.ToString();
            _clearStorePoint();

            switch (this.Race)
            {
                case "Human":
                    CharacterPictureBox.Image = Properties.Resources.M_Human1;
                    _scoreAfter["Str"] = _scoreBefore["Str"] + 5;
                    _scoreAfter["Dex"] = _scoreBefore["Dex"] + 5;
                    _scoreAfter["End"] = _scoreBefore["End"] + 5;
                    _scoreAfter["Intt"] = _scoreBefore["Intt"] + 5;
                    _scoreAfter["Per"] = _scoreBefore["Per"] + 5;
                    _scoreAfter["Cha"] = _scoreBefore["Cha"] + 5;
                    break;
                case "Dwarf":
                    CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
                    _scoreAfter["Str"] = _scoreBefore["Str"] + 20;
                    _scoreAfter["Dex"] = _scoreBefore["Dex"];
                    _scoreAfter["End"] = _scoreBefore["End"];
                    _scoreAfter["Intt"] = _scoreBefore["Intt"];
                    _scoreAfter["Per"] = _scoreBefore["Per"] + 20;
                    _scoreAfter["Cha"] = _scoreBefore["Cha"] - 10;
                    break;
                case "Elf":
                    CharacterPictureBox.Image = Properties.Resources.M_Elf1;
                    _scoreAfter["Str"] = _scoreBefore["Str"];
                    _scoreAfter["Dex"] = _scoreBefore["Dex"] + 15;
                    _scoreAfter["End"] = _scoreBefore["End"];
                    _scoreAfter["Intt"] = _scoreBefore["Intt"];
                    _scoreAfter["Per"] = _scoreBefore["Per"];
                    _scoreAfter["Cha"] = _scoreBefore["Cha"] + 15;
                    break;
                case "Halfling":
                    CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
                    _scoreAfter["Str"] = _scoreBefore["Str"] - 10;
                    _scoreAfter["Dex"] = _scoreBefore["Dex"] + 20;
                    _scoreAfter["End"] = _scoreBefore["End"];
                    _scoreAfter["Intt"] = _scoreBefore["Intt"] + 20;
                    _scoreAfter["Per"] = _scoreBefore["Per"];
                    _scoreAfter["Cha"] = _scoreBefore["Cha"];
                    break;
            }
            _calculateRacialBonus();
        }
        
        private void NextButton_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm();
            jobForm.PreviousForm = this;
            _storePointAfterChange();
            this.Hide();
            jobForm.Show(); 
        }

        private void RaceForm_Load(object sender, EventArgs e)
        {
            _initializeScore();
            _storePointBeforeChange();
        }

        private void RaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.PreviousForm.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
