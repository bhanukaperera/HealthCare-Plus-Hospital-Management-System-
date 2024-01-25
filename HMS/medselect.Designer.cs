namespace HMS
{
    partial class medselect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medselect));
            this.pat = new System.Windows.Forms.DataGridView();
            this.med = new System.Windows.Forms.DataGridView();
            this.patname = new System.Windows.Forms.Label();
            this.mednn = new System.Windows.Forms.Label();
            this.medlist = new System.Windows.Forms.TextBox();
            this.patientSearchBox = new System.Windows.Forms.TextBox();
            this.meddata = new System.Windows.Forms.DataGridView();
            this.clr = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.issue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meddata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pat
            // 
            this.pat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pat.Location = new System.Drawing.Point(321, 82);
            this.pat.Name = "pat";
            this.pat.Size = new System.Drawing.Size(299, 150);
            this.pat.TabIndex = 0;
            this.pat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pat_CellContentClick);
            // 
            // med
            // 
            this.med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.med.Location = new System.Drawing.Point(321, 238);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(299, 150);
            this.med.TabIndex = 1;
            this.med.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.med_CellContentClick);
            // 
            // patname
            // 
            this.patname.AutoSize = true;
            this.patname.BackColor = System.Drawing.Color.Transparent;
            this.patname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patname.Location = new System.Drawing.Point(35, 11);
            this.patname.Name = "patname";
            this.patname.Size = new System.Drawing.Size(76, 20);
            this.patname.TabIndex = 15;
            this.patname.Text = "Patient :";
            // 
            // mednn
            // 
            this.mednn.AutoSize = true;
            this.mednn.BackColor = System.Drawing.Color.Transparent;
            this.mednn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mednn.Location = new System.Drawing.Point(12, 46);
            this.mednn.Name = "mednn";
            this.mednn.Size = new System.Drawing.Size(99, 20);
            this.mednn.TabIndex = 17;
            this.mednn.Text = "Medicines :";
            // 
            // medlist
            // 
            this.medlist.Location = new System.Drawing.Point(117, 40);
            this.medlist.Multiline = true;
            this.medlist.Name = "medlist";
            this.medlist.Size = new System.Drawing.Size(198, 33);
            this.medlist.TabIndex = 18;
            // 
            // patientSearchBox
            // 
            this.patientSearchBox.Location = new System.Drawing.Point(117, 13);
            this.patientSearchBox.Name = "patientSearchBox";
            this.patientSearchBox.Size = new System.Drawing.Size(198, 20);
            this.patientSearchBox.TabIndex = 19;
            this.patientSearchBox.TextChanged += new System.EventHandler(this.patientSearchBox_TextChanged);
            // 
            // meddata
            // 
            this.meddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meddata.Location = new System.Drawing.Point(4, 132);
            this.meddata.Name = "meddata";
            this.meddata.Size = new System.Drawing.Size(311, 256);
            this.meddata.TabIndex = 20;
            this.meddata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meddata_CellClick);
            this.meddata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meddata_CellContentClick);
            // 
            // clr
            // 
            this.clr.BackColor = System.Drawing.Color.LightYellow;
            this.clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr.Location = new System.Drawing.Point(521, 13);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(99, 27);
            this.clr.TabIndex = 45;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = false;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.IndianRed;
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(481, 49);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(139, 27);
            this.del.TabIndex = 44;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(336, 49);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(139, 27);
            this.update.TabIndex = 43;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // issue
            // 
            this.issue.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.Location = new System.Drawing.Point(336, 13);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(179, 27);
            this.issue.TabIndex = 42;
            this.issue.Text = "Issue";
            this.issue.UseVisualStyleBackColor = false;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Remarks :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Location = new System.Drawing.Point(117, 81);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(198, 44);
            this.remarksTextBox.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 255);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // medselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 400);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.del);
            this.Controls.Add(this.update);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.meddata);
            this.Controls.Add(this.patientSearchBox);
            this.Controls.Add(this.medlist);
            this.Controls.Add(this.mednn);
            this.Controls.Add(this.patname);
            this.Controls.Add(this.med);
            this.Controls.Add(this.pat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "medselect";
            this.Text = "medselect";
            this.Load += new System.EventHandler(this.medselect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meddata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pat;
        private System.Windows.Forms.DataGridView med;
        private System.Windows.Forms.Label patname;
        private System.Windows.Forms.Label mednn;
        private System.Windows.Forms.TextBox medlist;
        private System.Windows.Forms.TextBox patientSearchBox;
        private System.Windows.Forms.DataGridView meddata;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}