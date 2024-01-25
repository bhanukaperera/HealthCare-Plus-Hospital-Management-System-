namespace HMS
{
    partial class medselectrpt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hMSDataSet8 = new HMS.HMSDataSet8();
            this.patientMedicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientMedicinesTableAdapter = new HMS.HMSDataSet8TableAdapters.PatientMedicinesTableAdapter();
            this.patientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMedicinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientnameDataGridViewTextBoxColumn,
            this.medicinesDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientMedicinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 498);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hMSDataSet8
            // 
            this.hMSDataSet8.DataSetName = "HMSDataSet8";
            this.hMSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientMedicinesBindingSource
            // 
            this.patientMedicinesBindingSource.DataMember = "PatientMedicines";
            this.patientMedicinesBindingSource.DataSource = this.hMSDataSet8;
            // 
            // patientMedicinesTableAdapter
            // 
            this.patientMedicinesTableAdapter.ClearBeforeFill = true;
            // 
            // patientnameDataGridViewTextBoxColumn
            // 
            this.patientnameDataGridViewTextBoxColumn.DataPropertyName = "Patientname";
            this.patientnameDataGridViewTextBoxColumn.HeaderText = "Patientname";
            this.patientnameDataGridViewTextBoxColumn.Name = "patientnameDataGridViewTextBoxColumn";
            // 
            // medicinesDataGridViewTextBoxColumn
            // 
            this.medicinesDataGridViewTextBoxColumn.DataPropertyName = "Medicines";
            this.medicinesDataGridViewTextBoxColumn.HeaderText = "Medicines";
            this.medicinesDataGridViewTextBoxColumn.Name = "medicinesDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // medselectrpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 845);
            this.Controls.Add(this.dataGridView1);
            this.Name = "medselectrpt";
            this.Text = "medselectrpt";
            this.Load += new System.EventHandler(this.medselectrpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMedicinesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HMSDataSet8 hMSDataSet8;
        private System.Windows.Forms.BindingSource patientMedicinesBindingSource;
        private HMSDataSet8TableAdapters.PatientMedicinesTableAdapter patientMedicinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}