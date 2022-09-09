
namespace Edu_Pick_System__2_
{
    partial class frmPersonalDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.tbSpecify = new System.Windows.Forms.TextBox();
            this.lblSpecify = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDU-PICK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right Course Bright Future";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dateTimePicker1);
            this.gbDetails.Controls.Add(this.lblDOB);
            this.gbDetails.Controls.Add(this.tbSpecify);
            this.gbDetails.Controls.Add(this.lblSpecify);
            this.gbDetails.Controls.Add(this.cbRace);
            this.gbDetails.Controls.Add(this.lblRace);
            this.gbDetails.Controls.Add(this.cbGender);
            this.gbDetails.Controls.Add(this.lblGender);
            this.gbDetails.Controls.Add(this.cbNationality);
            this.gbDetails.Controls.Add(this.lblNationality);
            this.gbDetails.Controls.Add(this.tbPassport);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.tbID);
            this.gbDetails.Controls.Add(this.lblID);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(12, 67);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(345, 472);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Student details";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "SA ID no,";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(6, 53);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(261, 22);
            this.tbID.TabIndex = 2;
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(6, 113);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(261, 22);
            this.tbPassport.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passport no.";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(6, 154);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(74, 16);
            this.lblNationality.TabIndex = 5;
            this.lblNationality.Text = "Nationality:";
            // 
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Items.AddRange(new object[] {
            "",
            "Afghans",
            "Albanians",
            "Algerians",
            "Americans",
            "Andorrans",
            "Angolans",
            "Antiguans and Barbudans",
            "Argentines",
            "Armenians",
            "Arubans",
            "Australians",
            "Austrians",
            "Azerbaijanis",
            "Bahamians",
            "Bahrainis",
            "Bangladeshis",
            "Barbadians",
            "Basques",
            "Belarusians",
            "Belgians",
            "Belizeans",
            "Beninese",
            "Bermudians",
            "Bhutanese",
            "Bolivians",
            "Bosniaks",
            "Bosnians and Herzegovinians",
            "Botswana",
            "Brazilians",
            "Bretons",
            "British",
            "British Virgin Islanders",
            "Bruneians",
            "Bulgarians",
            "Macedonian Bulgarians",
            "Burkinabés",
            "Burmese",
            "Burundians",
            "Cambodians",
            "Cameroonians",
            "Canadians",
            "Catalans",
            "Cape Verdeans",
            "List of Caymanians",
            "Chaldeans",
            "Chadians",
            "Chileans",
            "Chinese",
            "Colombians",
            "Comorians",
            "Congolese (DRC)",
            "Congolese (RotC)",
            "Costa Ricans",
            "Croats",
            "Cubans",
            "Cypriots",
            "Czechs",
            "Danes",
            "Greenlanders",
            "Djiboutians",
            "Dominicans (Commonwealth)",
            "Dominicans (Republic)",
            "Dutch",
            "East Timorese",
            "Ecuadorians",
            "Egyptians",
            "Emiratis",
            "English",
            "Equatoguineans",
            "Eritreans",
            "Estonians",
            "Ethiopians",
            "Falkland Islanders",
            "Faroese",
            "Fijians",
            "Finns",
            "Finnish Swedish",
            "Filipinos",
            "French citizens",
            "Gabonese",
            "Gambians",
            "Georgians",
            "Germans",
            "Baltic Germans",
            "Ghanaians",
            "Gibraltarians",
            "Greeks",
            "Greek Macedonians",
            "Grenadians",
            "Guatemalans",
            "Guianese (French)",
            "Guineans",
            "Guinea-Bissau nationals",
            "Guyanese",
            "Haitians",
            "Hondurans",
            "Hong Kongers",
            "Hungarians",
            "Icelanders",
            "I-Kiribati",
            "Indians",
            "Indonesians",
            "Iranians",
            "Iraqis",
            "Irish",
            "Israelis",
            "Italians",
            "Ivoirians",
            "Jamaicans",
            "Japanese",
            "Jordanians",
            "Kazakhs",
            "Kenyans",
            "Koreans",
            "Kosovars",
            "Kuwaitis",
            "Kyrgyzs",
            "Lao",
            "Latvians",
            "Lebanese",
            "Liberians",
            "Libyans",
            "Liechtensteiners",
            "Lithuanians",
            "Luxembourgers",
            "Macao",
            "Macedonians",
            "Malagasy",
            "Malawians",
            "Malaysians",
            "Maldivians",
            "Malians",
            "Maltese",
            "Manx",
            "Marshallese",
            "Mauritanians",
            "Mauritians",
            "Mexicans",
            "Micronesians",
            "Moldovans",
            "Monégasque",
            "Mongolians",
            "Montenegrins",
            "Moroccans",
            "Mozambicans",
            "Namibians",
            "Nauruans",
            "Nepalese",
            "New Zealanders",
            "Nicaraguans",
            "Nigeriens",
            "Nigerians",
            "Norwegians",
            "Omani",
            "Pakistanis",
            "Palauans",
            "Palestinians",
            "Panamanians",
            "Papua New Guineans",
            "Paraguayans",
            "Peruvians",
            "Poles",
            "Portuguese",
            "Puerto Ricans",
            "Qatari",
            "Quebecers",
            "Réunionnais",
            "Romanians",
            "Russians",
            "Baltic Russians",
            "Rwandans",
            "Saint Kitts and Nevis",
            "Saint Lucians",
            "Salvadorans",
            "Sammarinese",
            "Samoans",
            "São Tomé and Príncipe",
            "Saudis",
            "Scots",
            "Senegalese",
            "Serbs",
            "Seychellois",
            "Sierra Leoneans",
            "Singaporeans",
            "Slovaks",
            "Slovenes",
            "Solomon Islanders",
            "Somalis",
            "Somalilanders",
            "Sotho",
            "South Africans",
            "Spaniards",
            "Sri Lankans",
            "Sudanese",
            "Surinamese",
            "Swazi",
            "Swedes",
            "Swiss",
            "Syriacs",
            "Syrians",
            "Taiwanese",
            "Tamils",
            "Tajik",
            "Tanzanians",
            "Thais",
            "Tibetans",
            "Tobagonians",
            "Togolese",
            "Tongans",
            "Trinidadians",
            "Tunisians",
            "Turks",
            "Tuvaluans",
            "Ugandans",
            "Ukrainians",
            "Uruguayans",
            "Uzbeks",
            "Vanuatuans",
            "Venezuelans",
            "Vietnamese",
            "Vincentians",
            "Welsh",
            "Yemenis",
            "Zambians",
            "Zimbabweans"});
            this.cbNationality.Location = new System.Drawing.Point(7, 174);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(260, 24);
            this.cbNationality.TabIndex = 6;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(7, 237);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(260, 24);
            this.cbGender.TabIndex = 8;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(6, 217);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // cbRace
            // 
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Items.AddRange(new object[] {
            "",
            "Black",
            "White",
            "Indian",
            "Colored",
            "Others"});
            this.cbRace.Location = new System.Drawing.Point(7, 300);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(260, 24);
            this.cbRace.TabIndex = 10;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(6, 280);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(44, 16);
            this.lblRace.TabIndex = 9;
            this.lblRace.Text = "Race:";
            // 
            // tbSpecify
            // 
            this.tbSpecify.Location = new System.Drawing.Point(6, 362);
            this.tbSpecify.Name = "tbSpecify";
            this.tbSpecify.Size = new System.Drawing.Size(261, 22);
            this.tbSpecify.TabIndex = 12;
            // 
            // lblSpecify
            // 
            this.lblSpecify.AutoSize = true;
            this.lblSpecify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecify.Location = new System.Drawing.Point(6, 343);
            this.lblSpecify.Name = "lblSpecify";
            this.lblSpecify.Size = new System.Drawing.Size(103, 16);
            this.lblSpecify.TabIndex = 11;
            this.lblSpecify.Text = "If others specify:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(6, 403);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(82, 16);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Date of birth:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 423);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 542);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 542);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 545);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(156, 542);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPersonalDetails";
            this.Text = "Student Personal details";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox tbSpecify;
        private System.Windows.Forms.Label lblSpecify;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNext;
    }
}