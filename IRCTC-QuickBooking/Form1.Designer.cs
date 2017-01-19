namespace IRCTC_QuickBooking
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonTrainList = new System.Windows.Forms.Button();
            this.frmStn = new System.Windows.Forms.TextBox();
            this.doj = new System.Windows.Forms.DateTimePicker();
            this.toStn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxTrains = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxJourneyClass = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBoardingPoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChildDetails = new System.Windows.Forms.DataGridView();
            this.SerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildAge = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ChildGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewPassengerDetails = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BerthPreference = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SeniorCitizen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonTatkal = new System.Windows.Forms.RadioButton();
            this.radioButtonLadies = new System.Windows.Forms.RadioButton();
            this.radioButtonPhyHand = new System.Windows.Forms.RadioButton();
            this.radioButtonPremTat = new System.Windows.Forms.RadioButton();
            this.radioButtonGen = new System.Windows.Forms.RadioButton();
            this.buttonBookNow = new System.Windows.Forms.Button();
            this.pleaseWait1 = new IRCTC_QuickBooking.PleaseWait();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengerDetails)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTrainList
            // 
            this.buttonTrainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrainList.Location = new System.Drawing.Point(96, 184);
            this.buttonTrainList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTrainList.Name = "buttonTrainList";
            this.buttonTrainList.Size = new System.Drawing.Size(86, 19);
            this.buttonTrainList.TabIndex = 50;
            this.buttonTrainList.Text = "GET TRAINS";
            this.buttonTrainList.UseVisualStyleBackColor = true;
            this.buttonTrainList.Click += new System.EventHandler(this.buttonTrainList_Click);
            // 
            // frmStn
            // 
            this.frmStn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmStn.Location = new System.Drawing.Point(116, 34);
            this.frmStn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frmStn.Name = "frmStn";
            this.frmStn.Size = new System.Drawing.Size(168, 30);
            this.frmStn.TabIndex = 10;
            // 
            // doj
            // 
            this.doj.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doj.CustomFormat = "";
            this.doj.Location = new System.Drawing.Point(116, 146);
            this.doj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doj.MinDate = new System.DateTime(2016, 10, 27, 0, 0, 0, 0);
            this.doj.Name = "doj";
            this.doj.Size = new System.Drawing.Size(168, 22);
            this.doj.TabIndex = 30;
            this.doj.Value = new System.DateTime(2016, 11, 5, 0, 0, 0, 0);
            // 
            // toStn
            // 
            this.toStn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toStn.Location = new System.Drawing.Point(116, 73);
            this.toStn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toStn.Name = "toStn";
            this.toStn.Size = new System.Drawing.Size(168, 30);
            this.toStn.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "From Station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "To Station:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Journey Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Train Number:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(116, 23);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(168, 30);
            this.textBoxUserName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 51;
            this.label5.Text = "User Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(116, 65);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(168, 30);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxTrains
            // 
            this.textBoxTrains.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrains.Location = new System.Drawing.Point(116, 240);
            this.textBoxTrains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTrains.Name = "textBoxTrains";
            this.textBoxTrains.Size = new System.Drawing.Size(168, 30);
            this.textBoxTrains.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 61;
            this.label7.Text = "Class:";
            // 
            // comboBoxJourneyClass
            // 
            this.comboBoxJourneyClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJourneyClass.FormattingEnabled = true;
            this.comboBoxJourneyClass.Location = new System.Drawing.Point(116, 280);
            this.comboBoxJourneyClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxJourneyClass.Name = "comboBoxJourneyClass";
            this.comboBoxJourneyClass.Size = new System.Drawing.Size(168, 24);
            this.comboBoxJourneyClass.TabIndex = 70;
            this.comboBoxJourneyClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxJourneyClass_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(301, 111);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxBoardingPoint);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pleaseWait1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.frmStn);
            this.groupBox2.Controls.Add(this.comboBoxJourneyClass);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonTrainList);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.toStn);
            this.groupBox2.Controls.Add(this.textBoxTrains);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.doj);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(301, 410);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Journey Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 22);
            this.label9.TabIndex = 78;
            this.label9.Text = "Boarding Point:";
            this.label9.Visible = false;
            // 
            // textBoxBoardingPoint
            // 
            this.textBoxBoardingPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBoardingPoint.Location = new System.Drawing.Point(116, 109);
            this.textBoxBoardingPoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBoardingPoint.Name = "textBoxBoardingPoint";
            this.textBoxBoardingPoint.Size = new System.Drawing.Size(168, 30);
            this.textBoxBoardingPoint.TabIndex = 77;
            this.textBoxBoardingPoint.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(381, 22);
            this.label8.TabIndex = 76;
            this.label8.Text = "Click Here if you have different boarding point";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.dataGridViewPassengerDetails);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(317, 52);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(701, 545);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passenger Details";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewChildDetails);
            this.groupBox5.Location = new System.Drawing.Point(13, 309);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(676, 213);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Children Below 5 Years  (Ticket Is Not To Be Issued)";
            // 
            // dataGridViewChildDetails
            // 
            this.dataGridViewChildDetails.AllowUserToAddRows = false;
            this.dataGridViewChildDetails.AllowUserToDeleteRows = false;
            this.dataGridViewChildDetails.AllowUserToResizeColumns = false;
            this.dataGridViewChildDetails.AllowUserToResizeRows = false;
            this.dataGridViewChildDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChildDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerNo,
            this.ChildName,
            this.ChildAge,
            this.ChildGender});
            this.dataGridViewChildDetails.Location = new System.Drawing.Point(4, 21);
            this.dataGridViewChildDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewChildDetails.Name = "dataGridViewChildDetails";
            this.dataGridViewChildDetails.RowTemplate.Height = 24;
            this.dataGridViewChildDetails.Size = new System.Drawing.Size(470, 124);
            this.dataGridViewChildDetails.TabIndex = 0;
            // 
            // SerNo
            // 
            this.SerNo.HeaderText = "Serial No.";
            this.SerNo.Name = "SerNo";
            this.SerNo.ReadOnly = true;
            // 
            // ChildName
            // 
            this.ChildName.HeaderText = "Name";
            this.ChildName.Name = "ChildName";
            // 
            // ChildAge
            // 
            this.ChildAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChildAge.HeaderText = "Age";
            this.ChildAge.Items.AddRange(new object[] {
            "Below one year",
            "One year",
            "Two years",
            "Three years",
            "Four years"});
            this.ChildAge.Name = "ChildAge";
            // 
            // ChildGender
            // 
            this.ChildGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChildGender.HeaderText = "Gender";
            this.ChildGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ChildGender.Name = "ChildGender";
            this.ChildGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChildGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewPassengerDetails
            // 
            this.dataGridViewPassengerDetails.AllowUserToAddRows = false;
            this.dataGridViewPassengerDetails.AllowUserToDeleteRows = false;
            this.dataGridViewPassengerDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPassengerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPassengerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassengerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.PName,
            this.Age,
            this.Gender,
            this.BerthPreference,
            this.SeniorCitizen});
            this.dataGridViewPassengerDetails.Location = new System.Drawing.Point(13, 18);
            this.dataGridViewPassengerDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPassengerDetails.Name = "dataGridViewPassengerDetails";
            this.dataGridViewPassengerDetails.RowTemplate.Height = 24;
            this.dataGridViewPassengerDetails.Size = new System.Drawing.Size(676, 263);
            this.dataGridViewPassengerDetails.TabIndex = 0;
            // 
            // sno
            // 
            this.sno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sno.Frozen = true;
            this.sno.HeaderText = "S. No.";
            this.sno.Name = "sno";
            this.sno.ReadOnly = true;
            this.sno.Width = 70;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            this.PName.Width = 180;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.Width = 80;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Gender.DisplayStyleForCurrentCellOnly = true;
            this.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender.HeaderText = "Gender";
            this.Gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.Gender.Name = "Gender";
            // 
            // BerthPreference
            // 
            this.BerthPreference.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.BerthPreference.DisplayStyleForCurrentCellOnly = true;
            this.BerthPreference.HeaderText = "Berth Preference";
            this.BerthPreference.Items.AddRange(new object[] {
            "No Preference",
            "LOWER",
            "MIDDLE",
            "UPPER",
            "SIDE LOWER",
            "SIDE UPPER"});
            this.BerthPreference.Name = "BerthPreference";
            this.BerthPreference.Width = 120;
            // 
            // SeniorCitizen
            // 
            this.SeniorCitizen.HeaderText = "Senior Citizen";
            this.SeniorCitizen.Name = "SeniorCitizen";
            this.SeniorCitizen.ToolTipText = "Please carry a valid ID proof for senior citizen";
            this.SeniorCitizen.Width = 70;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonTatkal);
            this.groupBox4.Controls.Add(this.radioButtonLadies);
            this.groupBox4.Controls.Add(this.radioButtonPhyHand);
            this.groupBox4.Controls.Add(this.radioButtonPremTat);
            this.groupBox4.Controls.Add(this.radioButtonGen);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(322, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(696, 42);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quota";
            // 
            // radioButtonTatkal
            // 
            this.radioButtonTatkal.AutoSize = true;
            this.radioButtonTatkal.Location = new System.Drawing.Point(505, 17);
            this.radioButtonTatkal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonTatkal.Name = "radioButtonTatkal";
            this.radioButtonTatkal.Size = new System.Drawing.Size(88, 21);
            this.radioButtonTatkal.TabIndex = 4;
            this.radioButtonTatkal.TabStop = true;
            this.radioButtonTatkal.Text = "TATKAL";
            this.radioButtonTatkal.UseVisualStyleBackColor = true;
            // 
            // radioButtonLadies
            // 
            this.radioButtonLadies.AutoSize = true;
            this.radioButtonLadies.Location = new System.Drawing.Point(433, 17);
            this.radioButtonLadies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonLadies.Name = "radioButtonLadies";
            this.radioButtonLadies.Size = new System.Drawing.Size(83, 21);
            this.radioButtonLadies.TabIndex = 3;
            this.radioButtonLadies.TabStop = true;
            this.radioButtonLadies.Text = "LADIES";
            this.radioButtonLadies.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhyHand
            // 
            this.radioButtonPhyHand.AutoSize = true;
            this.radioButtonPhyHand.Location = new System.Drawing.Point(266, 17);
            this.radioButtonPhyHand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonPhyHand.Name = "radioButtonPhyHand";
            this.radioButtonPhyHand.Size = new System.Drawing.Size(209, 21);
            this.radioButtonPhyHand.TabIndex = 2;
            this.radioButtonPhyHand.TabStop = true;
            this.radioButtonPhyHand.Text = "PHYSICALLY HANDICAP \t";
            this.radioButtonPhyHand.UseVisualStyleBackColor = true;
            // 
            // radioButtonPremTat
            // 
            this.radioButtonPremTat.AutoSize = true;
            this.radioButtonPremTat.Location = new System.Drawing.Point(132, 17);
            this.radioButtonPremTat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonPremTat.Name = "radioButtonPremTat";
            this.radioButtonPremTat.Size = new System.Drawing.Size(163, 21);
            this.radioButtonPremTat.TabIndex = 1;
            this.radioButtonPremTat.TabStop = true;
            this.radioButtonPremTat.Text = "PREMIUM TATKAL";
            this.radioButtonPremTat.UseVisualStyleBackColor = true;
            // 
            // radioButtonGen
            // 
            this.radioButtonGen.AutoSize = true;
            this.radioButtonGen.Location = new System.Drawing.Point(45, 17);
            this.radioButtonGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonGen.Name = "radioButtonGen";
            this.radioButtonGen.Size = new System.Drawing.Size(102, 21);
            this.radioButtonGen.TabIndex = 0;
            this.radioButtonGen.TabStop = true;
            this.radioButtonGen.Text = "GENERAL";
            this.radioButtonGen.UseVisualStyleBackColor = true;
            // 
            // buttonBookNow
            // 
            this.buttonBookNow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookNow.Location = new System.Drawing.Point(544, 622);
            this.buttonBookNow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBookNow.Name = "buttonBookNow";
            this.buttonBookNow.Size = new System.Drawing.Size(217, 38);
            this.buttonBookNow.TabIndex = 75;
            this.buttonBookNow.Text = "Book Now";
            this.buttonBookNow.UseVisualStyleBackColor = true;
            this.buttonBookNow.Click += new System.EventHandler(this.buttonBookNow_Click);
            // 
            // pleaseWait1
            // 
            this.pleaseWait1.Location = new System.Drawing.Point(15, 182);
            this.pleaseWait1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pleaseWait1.Name = "pleaseWait1";
            this.pleaseWait1.Size = new System.Drawing.Size(271, 24);
            this.pleaseWait1.TabIndex = 75;
            this.pleaseWait1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 670);
            this.Controls.Add(this.buttonBookNow);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "IRCTC-Quick Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengerDetails)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonTrainList;
        private System.Windows.Forms.TextBox frmStn;
        private System.Windows.Forms.DateTimePicker doj;
        private System.Windows.Forms.TextBox toStn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxTrains;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxJourneyClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dataGridViewPassengerDetails;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonTatkal;
        private System.Windows.Forms.RadioButton radioButtonLadies;
        private System.Windows.Forms.RadioButton radioButtonPhyHand;
        private System.Windows.Forms.RadioButton radioButtonPremTat;
        private System.Windows.Forms.RadioButton radioButtonGen;
        private PleaseWait pleaseWait1;
        private System.Windows.Forms.Button buttonBookNow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBoardingPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewComboBoxColumn Gender;
        private System.Windows.Forms.DataGridViewComboBoxColumn BerthPreference;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeniorCitizen;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewChildDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChildAge;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChildGender;
    }
}

