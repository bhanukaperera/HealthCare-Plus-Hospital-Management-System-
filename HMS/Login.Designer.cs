namespace HMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_btn = new System.Windows.Forms.Button();
            this.tusername = new System.Windows.Forms.TextBox();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_btn.Location = new System.Drawing.Point(30, 136);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(172, 56);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tusername
            // 
            this.tusername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tusername.Location = new System.Drawing.Point(20, 31);
            this.tusername.Multiline = true;
            this.tusername.Name = "tusername";
            this.tusername.Size = new System.Drawing.Size(189, 30);
            this.tusername.TabIndex = 2;
            this.tusername.TextChanged += new System.EventHandler(this.tusername_TextChanged);
            // 
            // tpassword
            // 
            this.tpassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpassword.Location = new System.Drawing.Point(20, 91);
            this.tpassword.Multiline = true;
            this.tpassword.Name = "tpassword";
            this.tpassword.PasswordChar = '*';
            this.tpassword.Size = new System.Drawing.Size(188, 30);
            this.tpassword.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(539, 222);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.tusername);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox tusername;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}