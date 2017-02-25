namespace COMP1004_W2017_MidTerm_200332992
{
    partial class FinalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FinalFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FinalFormFontDialog = new System.Windows.Forms.FontDialog();
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.CharacterInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HealthPointsLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.HealthPointsTextBox = new System.Windows.Forms.TextBox();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.JobTextBox = new System.Windows.Forms.TextBox();
            this.AbilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.CHATextBox = new System.Windows.Forms.TextBox();
            this.PERTextBox = new System.Windows.Forms.TextBox();
            this.INTTextBox = new System.Windows.Forms.TextBox();
            this.ENDTextBox = new System.Windows.Forms.TextBox();
            this.DEXTextBox = new System.Windows.Forms.TextBox();
            this.STRTextBox = new System.Windows.Forms.TextBox();
            this.CHALabel = new System.Windows.Forms.Label();
            this.PERLabel = new System.Windows.Forms.Label();
            this.INTLabel = new System.Windows.Forms.Label();
            this.ENDLabel = new System.Windows.Forms.Label();
            this.DEXLabel = new System.Windows.Forms.Label();
            this.STRLabel = new System.Windows.Forms.Label();
            this.FinalFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.CharacterInformationGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AbilitiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinalFormMenuStrip
            // 
            this.FinalFormMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.FinalFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FinalFormMenuStrip.Name = "FinalFormMenuStrip";
            this.FinalFormMenuStrip.Size = new System.Drawing.Size(641, 25);
            this.FinalFormMenuStrip.TabIndex = 0;
            this.FinalFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(99, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontStripMenuItem,
            this.toolStripSeparator4});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // fontStripMenuItem
            // 
            this.fontStripMenuItem.Name = "fontStripMenuItem";
            this.fontStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.fontStripMenuItem.Text = "&Font";
            this.fontStripMenuItem.Click += new System.EventHandler(this.fontStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(98, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator5});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(108, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(31, 437);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FinalFormFontDialog
            // 
            this.FinalFormFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FinalFormFontDialog.MaxSize = 18;
            this.FinalFormFontDialog.MinSize = 10;
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Location = new System.Drawing.Point(318, 170);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(302, 278);
            this.CharacterPictureBox.TabIndex = 2;
            this.CharacterPictureBox.TabStop = false;
            // 
            // CharacterInformationGroupBox
            // 
            this.CharacterInformationGroupBox.Controls.Add(this.WeightLabel);
            this.CharacterInformationGroupBox.Controls.Add(this.HeightLabel);
            this.CharacterInformationGroupBox.Controls.Add(this.WeightTextBox);
            this.CharacterInformationGroupBox.Controls.Add(this.HeightTextBox);
            this.CharacterInformationGroupBox.Controls.Add(this.AgeTextBox);
            this.CharacterInformationGroupBox.Controls.Add(this.NameTextBox);
            this.CharacterInformationGroupBox.Controls.Add(this.AgeLabel);
            this.CharacterInformationGroupBox.Controls.Add(this.NameLabel);
            this.CharacterInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterInformationGroupBox.Location = new System.Drawing.Point(12, 40);
            this.CharacterInformationGroupBox.Name = "CharacterInformationGroupBox";
            this.CharacterInformationGroupBox.Size = new System.Drawing.Size(348, 101);
            this.CharacterInformationGroupBox.TabIndex = 3;
            this.CharacterInformationGroupBox.TabStop = false;
            this.CharacterInformationGroupBox.Text = "Character Information";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(185, 58);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(53, 16);
            this.WeightLabel.TabIndex = 7;
            this.WeightLabel.Text = "Weight:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(185, 31);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(50, 16);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "Height:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(238, 55);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.WeightTextBox.TabIndex = 5;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(238, 28);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.HeightTextBox.TabIndex = 4;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(61, 55);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(102, 22);
            this.AgeTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(61, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(102, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(7, 58);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(36, 16);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Age:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HealthPointsLabel);
            this.groupBox2.Controls.Add(this.RaceLabel);
            this.groupBox2.Controls.Add(this.JobLabel);
            this.groupBox2.Controls.Add(this.HealthPointsTextBox);
            this.groupBox2.Controls.Add(this.RaceTextBox);
            this.groupBox2.Controls.Add(this.JobTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(356, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // HealthPointsLabel
            // 
            this.HealthPointsLabel.AutoSize = true;
            this.HealthPointsLabel.Location = new System.Drawing.Point(18, 85);
            this.HealthPointsLabel.Name = "HealthPointsLabel";
            this.HealthPointsLabel.Size = new System.Drawing.Size(90, 16);
            this.HealthPointsLabel.TabIndex = 5;
            this.HealthPointsLabel.Text = "Health Points:";
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(48, 55);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(44, 16);
            this.RaceLabel.TabIndex = 4;
            this.RaceLabel.Text = "Race:";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(48, 24);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(34, 16);
            this.JobLabel.TabIndex = 3;
            this.JobLabel.Text = "Job:";
            // 
            // HealthPointsTextBox
            // 
            this.HealthPointsTextBox.Location = new System.Drawing.Point(114, 82);
            this.HealthPointsTextBox.Name = "HealthPointsTextBox";
            this.HealthPointsTextBox.Size = new System.Drawing.Size(124, 22);
            this.HealthPointsTextBox.TabIndex = 2;
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Location = new System.Drawing.Point(114, 52);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.Size = new System.Drawing.Size(124, 22);
            this.RaceTextBox.TabIndex = 1;
            // 
            // JobTextBox
            // 
            this.JobTextBox.Location = new System.Drawing.Point(114, 21);
            this.JobTextBox.Name = "JobTextBox";
            this.JobTextBox.Size = new System.Drawing.Size(124, 22);
            this.JobTextBox.TabIndex = 0;
            // 
            // AbilitiesGroupBox
            // 
            this.AbilitiesGroupBox.Controls.Add(this.CHATextBox);
            this.AbilitiesGroupBox.Controls.Add(this.PERTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.INTTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.ENDTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.DEXTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.STRTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.CHALabel);
            this.AbilitiesGroupBox.Controls.Add(this.PERLabel);
            this.AbilitiesGroupBox.Controls.Add(this.INTLabel);
            this.AbilitiesGroupBox.Controls.Add(this.ENDLabel);
            this.AbilitiesGroupBox.Controls.Add(this.DEXLabel);
            this.AbilitiesGroupBox.Controls.Add(this.STRLabel);
            this.AbilitiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilitiesGroupBox.Location = new System.Drawing.Point(12, 170);
            this.AbilitiesGroupBox.Name = "AbilitiesGroupBox";
            this.AbilitiesGroupBox.Size = new System.Drawing.Size(238, 249);
            this.AbilitiesGroupBox.TabIndex = 5;
            this.AbilitiesGroupBox.TabStop = false;
            this.AbilitiesGroupBox.Text = "Abilities";
            // 
            // CHATextBox
            // 
            this.CHATextBox.Location = new System.Drawing.Point(94, 216);
            this.CHATextBox.Name = "CHATextBox";
            this.CHATextBox.Size = new System.Drawing.Size(100, 22);
            this.CHATextBox.TabIndex = 11;
            // 
            // PERTextBox
            // 
            this.PERTextBox.Location = new System.Drawing.Point(94, 181);
            this.PERTextBox.Name = "PERTextBox";
            this.PERTextBox.Size = new System.Drawing.Size(100, 22);
            this.PERTextBox.TabIndex = 10;
            // 
            // INTTextBox
            // 
            this.INTTextBox.Location = new System.Drawing.Point(94, 144);
            this.INTTextBox.Name = "INTTextBox";
            this.INTTextBox.Size = new System.Drawing.Size(100, 22);
            this.INTTextBox.TabIndex = 9;
            // 
            // ENDTextBox
            // 
            this.ENDTextBox.Location = new System.Drawing.Point(94, 107);
            this.ENDTextBox.Name = "ENDTextBox";
            this.ENDTextBox.Size = new System.Drawing.Size(100, 22);
            this.ENDTextBox.TabIndex = 8;
            // 
            // DEXTextBox
            // 
            this.DEXTextBox.Location = new System.Drawing.Point(94, 73);
            this.DEXTextBox.Name = "DEXTextBox";
            this.DEXTextBox.Size = new System.Drawing.Size(100, 22);
            this.DEXTextBox.TabIndex = 7;
            // 
            // STRTextBox
            // 
            this.STRTextBox.Location = new System.Drawing.Point(94, 38);
            this.STRTextBox.Name = "STRTextBox";
            this.STRTextBox.Size = new System.Drawing.Size(100, 22);
            this.STRTextBox.TabIndex = 6;
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHALabel.Location = new System.Drawing.Point(16, 219);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(39, 16);
            this.CHALabel.TabIndex = 5;
            this.CHALabel.Text = "CHA";
            // 
            // PERLabel
            // 
            this.PERLabel.AutoSize = true;
            this.PERLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERLabel.Location = new System.Drawing.Point(16, 184);
            this.PERLabel.Name = "PERLabel";
            this.PERLabel.Size = new System.Drawing.Size(39, 16);
            this.PERLabel.TabIndex = 4;
            this.PERLabel.Text = "PER";
            // 
            // INTLabel
            // 
            this.INTLabel.AutoSize = true;
            this.INTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTLabel.Location = new System.Drawing.Point(17, 147);
            this.INTLabel.Name = "INTLabel";
            this.INTLabel.Size = new System.Drawing.Size(33, 16);
            this.INTLabel.TabIndex = 3;
            this.INTLabel.Text = "INT";
            // 
            // ENDLabel
            // 
            this.ENDLabel.AutoSize = true;
            this.ENDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDLabel.Location = new System.Drawing.Point(17, 110);
            this.ENDLabel.Name = "ENDLabel";
            this.ENDLabel.Size = new System.Drawing.Size(40, 16);
            this.ENDLabel.TabIndex = 2;
            this.ENDLabel.Text = "END";
            // 
            // DEXLabel
            // 
            this.DEXLabel.AutoSize = true;
            this.DEXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXLabel.Location = new System.Drawing.Point(17, 76);
            this.DEXLabel.Name = "DEXLabel";
            this.DEXLabel.Size = new System.Drawing.Size(38, 16);
            this.DEXLabel.TabIndex = 1;
            this.DEXLabel.Text = "DEX";
            // 
            // STRLabel
            // 
            this.STRLabel.AutoSize = true;
            this.STRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRLabel.Location = new System.Drawing.Point(16, 41);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(39, 16);
            this.STRLabel.TabIndex = 0;
            this.STRLabel.Text = "STR";
            // 
            // FinalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 472);
            this.Controls.Add(this.AbilitiesGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CharacterInformationGroupBox);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FinalFormMenuStrip);
            this.MainMenuStrip = this.FinalFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Character Selections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinalForm_FormClosing);
            this.Load += new System.EventHandler(this.FinalForm_Load);
            this.FinalFormMenuStrip.ResumeLayout(false);
            this.FinalFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.CharacterInformationGroupBox.ResumeLayout(false);
            this.CharacterInformationGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AbilitiesGroupBox.ResumeLayout(false);
            this.AbilitiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FinalFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FontDialog FinalFormFontDialog;
        private System.Windows.Forms.PictureBox CharacterPictureBox;
        private System.Windows.Forms.GroupBox CharacterInformationGroupBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label HealthPointsLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.TextBox HealthPointsTextBox;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.TextBox JobTextBox;
        private System.Windows.Forms.GroupBox AbilitiesGroupBox;
        private System.Windows.Forms.TextBox CHATextBox;
        private System.Windows.Forms.TextBox PERTextBox;
        private System.Windows.Forms.TextBox INTTextBox;
        private System.Windows.Forms.TextBox ENDTextBox;
        private System.Windows.Forms.TextBox DEXTextBox;
        private System.Windows.Forms.TextBox STRTextBox;
        private System.Windows.Forms.Label CHALabel;
        private System.Windows.Forms.Label PERLabel;
        private System.Windows.Forms.Label INTLabel;
        private System.Windows.Forms.Label ENDLabel;
        private System.Windows.Forms.Label DEXLabel;
        private System.Windows.Forms.Label STRLabel;
    }
}