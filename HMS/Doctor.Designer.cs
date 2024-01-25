namespace HMS
{
    partial class Doctor
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
            this.components = new System.ComponentModel.Container();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.doctorDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet6 = new HMS.HMSDataSet6();
            this.doctorDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.houseNo = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.expyear = new System.Windows.Forms.TextBox();
            this.comments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet5 = new HMS.HMSDataSet5();
            this.doctorDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.doctorDetailsTableAdapter = new HMS.HMSDataSet5TableAdapters.DoctorDetailsTableAdapter();
            this.doctorDetailsTableAdapter1 = new HMS.HMSDataSet6TableAdapters.DoctorDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fname.Location = new System.Drawing.Point(103, 18);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(196, 20);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name";
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fname_MouseClick);
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lname.Location = new System.Drawing.Point(307, 18);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(177, 20);
            this.lname.TabIndex = 1;
            this.lname.Text = "Last Name";
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lname_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.sex.Location = new System.Drawing.Point(534, 18);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(96, 21);
            this.sex.TabIndex = 3;
            this.sex.SelectedIndexChanged += new System.EventHandler(this.sex_SelectedIndexChanged);
            this.sex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sex_MouseClick);
            // 
            // doctorDetailsBindingSource3
            // 
            this.doctorDetailsBindingSource3.DataMember = "DoctorDetails";
            this.doctorDetailsBindingSource3.DataSource = this.hMSDataSet6;
            // 
            // hMSDataSet6
            // 
            this.hMSDataSet6.DataSetName = "HMSDataSet6";
            this.hMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sex :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "DOB :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bday
            // 
            this.bday.Location = new System.Drawing.Point(103, 53);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(196, 20);
            this.bday.TabIndex = 6;
            this.bday.ValueChanged += new System.EventHandler(this.bday_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email :";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.email.Location = new System.Drawing.Point(103, 91);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(196, 20);
            this.email.TabIndex = 8;
            this.email.Text = "email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.email_MouseClick);
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address :";
            // 
            // houseNo
            // 
            this.houseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseNo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.houseNo.Location = new System.Drawing.Point(103, 132);
            this.houseNo.Name = "houseNo";
            this.houseNo.Size = new System.Drawing.Size(145, 20);
            this.houseNo.TabIndex = 10;
            this.houseNo.Text = "House NO";
            this.houseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.houseNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.houseNo_MouseClick);
            this.houseNo.TextChanged += new System.EventHandler(this.houseNo_TextChanged);
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.street.Location = new System.Drawing.Point(265, 132);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(148, 20);
            this.street.TabIndex = 11;
            this.street.Text = "Street Name";
            this.street.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.street.Click += new System.EventHandler(this.street_Click);
            this.street.MouseClick += new System.Windows.Forms.MouseEventHandler(this.street_MouseClick);
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.city.Location = new System.Drawing.Point(432, 132);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(163, 20);
            this.city.TabIndex = 12;
            this.city.Text = "City";
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.city.MouseClick += new System.Windows.Forms.MouseEventHandler(this.city_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact NO :";
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.contact.Location = new System.Drawing.Point(432, 93);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(163, 20);
            this.contact.TabIndex = 14;
            this.contact.Text = "Phone";
            this.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contact.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contact_MouseClick);
            this.contact.TextChanged += new System.EventHandler(this.contact_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Experience :";
            // 
            // expyear
            // 
            this.expyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expyear.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.expyear.Location = new System.Drawing.Point(483, 166);
            this.expyear.Name = "expyear";
            this.expyear.Size = new System.Drawing.Size(112, 20);
            this.expyear.TabIndex = 16;
            this.expyear.Text = "Years";
            this.expyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expyear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expyear_MouseClick);
            this.expyear.TextChanged += new System.EventHandler(this.expyear_TextChanged);
            // 
            // comments
            // 
            this.comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comments.Location = new System.Drawing.Point(103, 165);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(261, 22);
            this.comments.TabIndex = 17;
            this.comments.Text = "Comments :";
            this.comments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comments_MouseClick);
            this.comments.TextChanged += new System.EventHandler(this.comments_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Comment :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(624, 49);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 27);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(624, 86);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(97, 27);
            this.update.TabIndex = 20;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(624, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Moccasin;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(624, 163);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(97, 27);
            this.clear.TabIndex = 22;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.houseNoDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorDetailsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 249);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            // 
            // houseNoDataGridViewTextBoxColumn
            // 
            this.houseNoDataGridViewTextBoxColumn.DataPropertyName = "HouseNo";
            this.houseNoDataGridViewTextBoxColumn.HeaderText = "HouseNo";
            this.houseNoDataGridViewTextBoxColumn.Name = "houseNoDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // doctorDetailsBindingSource1
            // 
            this.doctorDetailsBindingSource1.DataMember = "DoctorDetails";
            this.doctorDetailsBindingSource1.DataSource = this.hMSDataSet5;
            // 
            // hMSDataSet5
            // 
            this.hMSDataSet5.DataSetName = "HMSDataSet5";
            this.hMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(301, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Specialization :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.area.Location = new System.Drawing.Point(432, 55);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(163, 20);
            this.area.TabIndex = 25;
            this.area.Text = "Area";
            this.area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.area.MouseClick += new System.Windows.Forms.MouseEventHandler(this.area_MouseClick);
            this.area.TextChanged += new System.EventHandler(this.area_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(633, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "ID :";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ID.Location = new System.Drawing.Point(672, 18);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(72, 20);
            this.ID.TabIndex = 27;
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ID_MouseClick);
            // 
            // doctorDetailsTableAdapter
            // 
            this.doctorDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorDetailsTableAdapter1
            // 
            this.doctorDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 455);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.expyear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.houseNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker bday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox houseNo;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox expyear;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.BindingSource doctorDetailsBindingSource2;
        private System.Windows.Forms.BindingSource doctorDetailsBindingSource;
        private HMSDataSet5 hMSDataSet5;
        private System.Windows.Forms.BindingSource doctorDetailsBindingSource1;
        private HMSDataSet5TableAdapters.DoctorDetailsTableAdapter doctorDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private HMSDataSet6 hMSDataSet6;
        private System.Windows.Forms.BindingSource doctorDetailsBindingSource3;
        private HMSDataSet6TableAdapters.DoctorDetailsTableAdapter doctorDetailsTableAdapter1;
    }
}