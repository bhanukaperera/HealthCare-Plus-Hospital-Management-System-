namespace HMS
{
    partial class appoinment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appoinment));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pateintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.rates = new System.Windows.Forms.DataGridView();
            this.patient = new System.Windows.Forms.DataGridView();
            this.doctor = new System.Windows.Forms.DataGridView();
            this.appt = new System.Windows.Forms.DataGridView();
            this.apid = new System.Windows.Forms.TextBox();
            this.patname = new System.Windows.Forms.TextBox();
            this.doc = new System.Windows.Forms.TextBox();
            this.roombox = new System.Windows.Forms.TextBox();
            this.book = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.ratebox = new System.Windows.Forms.ComboBox();
            this.room = new System.Windows.Forms.DataGridView();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.clr = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pateintsToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.medicineToolStripMenuItem,
            this.ratesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pateintsToolStripMenuItem
            // 
            this.pateintsToolStripMenuItem.Name = "pateintsToolStripMenuItem";
            this.pateintsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pateintsToolStripMenuItem.Text = "Pateints";
            this.pateintsToolStripMenuItem.Click += new System.EventHandler(this.pateintsToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // ratesToolStripMenuItem
            // 
            this.ratesToolStripMenuItem.Name = "ratesToolStripMenuItem";
            this.ratesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ratesToolStripMenuItem.Text = "Rates";
            this.ratesToolStripMenuItem.Click += new System.EventHandler(this.ratesToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rate :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Room :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Doctor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Patient :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(72, 56);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 22;
            this.date.Value = new System.DateTime(2023, 10, 8, 13, 17, 51, 0);
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(339, 56);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(101, 20);
            this.time.TabIndex = 23;
            this.time.Value = new System.DateTime(2023, 10, 8, 13, 17, 51, 0);
            // 
            // rates
            // 
            this.rates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rates.Location = new System.Drawing.Point(553, 201);
            this.rates.Name = "rates";
            this.rates.Size = new System.Drawing.Size(264, 115);
            this.rates.TabIndex = 24;
            this.rates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rates_CellContentClick);
            // 
            // patient
            // 
            this.patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient.Location = new System.Drawing.Point(283, 201);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(264, 242);
            this.patient.TabIndex = 25;
            this.patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patient_CellContentClick);
            // 
            // doctor
            // 
            this.doctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor.Location = new System.Drawing.Point(6, 201);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(269, 242);
            this.doctor.TabIndex = 26;
            this.doctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctor_CellClick);
            this.doctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctor_CellContentClick);
            // 
            // appt
            // 
            this.appt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appt.Location = new System.Drawing.Point(446, 27);
            this.appt.Name = "appt";
            this.appt.Size = new System.Drawing.Size(373, 164);
            this.appt.TabIndex = 27;
            this.appt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appt_CellClick);
            this.appt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appt_CellContentClick);
            // 
            // apid
            // 
            this.apid.Location = new System.Drawing.Point(72, 26);
            this.apid.Name = "apid";
            this.apid.Size = new System.Drawing.Size(79, 20);
            this.apid.TabIndex = 28;
            this.apid.TextChanged += new System.EventHandler(this.apid_TextChanged);
            // 
            // patname
            // 
            this.patname.Location = new System.Drawing.Point(254, 27);
            this.patname.Name = "patname";
            this.patname.Size = new System.Drawing.Size(186, 20);
            this.patname.TabIndex = 29;
            this.patname.TextChanged += new System.EventHandler(this.patname_TextChanged);
            // 
            // doc
            // 
            this.doc.Location = new System.Drawing.Point(254, 89);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(186, 20);
            this.doc.TabIndex = 30;
            // 
            // roombox
            // 
            this.roombox.Location = new System.Drawing.Point(72, 91);
            this.roombox.Name = "roombox";
            this.roombox.Size = new System.Drawing.Size(97, 20);
            this.roombox.TabIndex = 31;
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.Location = new System.Drawing.Point(179, 118);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(179, 27);
            this.book.TabIndex = 33;
            this.book.Text = "Book";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(154, 160);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(139, 27);
            this.update.TabIndex = 34;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.IndianRed;
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(299, 160);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(139, 27);
            this.del.TabIndex = 35;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Black;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.print.Location = new System.Drawing.Point(6, 150);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(139, 44);
            this.print.TabIndex = 36;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // ratebox
            // 
            this.ratebox.FormattingEnabled = true;
            this.ratebox.Items.AddRange(new object[] {
            "Normal Channeling",
            "Special Channeling",
            "Package A",
            "Package B",
            "Emergency",
            "25.00"});
            this.ratebox.Location = new System.Drawing.Point(72, 120);
            this.ratebox.Name = "ratebox";
            this.ratebox.Size = new System.Drawing.Size(97, 21);
            this.ratebox.TabIndex = 38;
            // 
            // room
            // 
            this.room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room.Location = new System.Drawing.Point(553, 328);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(264, 115);
            this.room.TabIndex = 39;
            this.room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.room_CellContentClick);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(813, 449);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(10, 10);
            this.axAcroPDF1.TabIndex = 40;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // clr
            // 
            this.clr.BackColor = System.Drawing.Color.LightYellow;
            this.clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr.Location = new System.Drawing.Point(364, 118);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(73, 27);
            this.clr.TabIndex = 41;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = false;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // appoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.room);
            this.Controls.Add(this.ratebox);
            this.Controls.Add(this.print);
            this.Controls.Add(this.del);
            this.Controls.Add(this.update);
            this.Controls.Add(this.book);
            this.Controls.Add(this.roombox);
            this.Controls.Add(this.doc);
            this.Controls.Add(this.patname);
            this.Controls.Add(this.apid);
            this.Controls.Add(this.appt);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.rates);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "appoinment";
            this.Text = "appoinment";
            this.Load += new System.EventHandler(this.appoinment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pateintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratesToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.DataGridView rates;
        private System.Windows.Forms.DataGridView patient;
        private System.Windows.Forms.DataGridView doctor;
        private System.Windows.Forms.DataGridView appt;
        private System.Windows.Forms.TextBox apid;
        private System.Windows.Forms.TextBox patname;
        private System.Windows.Forms.TextBox doc;
        private System.Windows.Forms.TextBox roombox;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.ComboBox ratebox;
        private System.Windows.Forms.DataGridView room;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button clr;
    }
}