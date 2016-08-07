namespace FlyHigh
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.bGender = new System.Windows.Forms.ComboBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.txtRefLastname = new System.Windows.Forms.TextBox();
            this.txtRefFirstname = new System.Windows.Forms.TextBox();
            this.txtRefContact = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.txtBankID = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSignUp.Location = new System.Drawing.Point(418, 539);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 33);
            this.btnSignUp.TabIndex = 16;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // n
            // 
            this.n.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.n.Location = new System.Drawing.Point(524, 539);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(75, 33);
            this.n.TabIndex = 17;
            this.n.Text = "Cancel";
            this.n.UseVisualStyleBackColor = true;
            this.n.Click += new System.EventHandler(this.n_Click);
            // 
            // bGender
            // 
            this.bGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bGender.ForeColor = System.Drawing.Color.Teal;
            this.bGender.FormattingEnabled = true;
            this.bGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.bGender.Location = new System.Drawing.Point(266, 235);
            this.bGender.Name = "bGender";
            this.bGender.Size = new System.Drawing.Size(121, 29);
            this.bGender.TabIndex = 7;
            this.bGender.SelectedIndexChanged += new System.EventHandler(this.bGender_SelectedIndexChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Teal;
            this.txtLastname.Location = new System.Drawing.Point(266, 92);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(185, 29);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFirstname.ForeColor = System.Drawing.Color.Teal;
            this.txtFirstname.Location = new System.Drawing.Point(524, 92);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(185, 29);
            this.txtFirstname.TabIndex = 2;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.Teal;
            this.txtUsername.Location = new System.Drawing.Point(266, 162);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 29);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Teal;
            this.txtPassword.Location = new System.Drawing.Point(266, 197);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 29);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfPassword
            // 
            this.txtConfPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfPassword.ForeColor = System.Drawing.Color.Teal;
            this.txtConfPassword.Location = new System.Drawing.Point(524, 200);
            this.txtConfPassword.Name = "txtConfPassword";
            this.txtConfPassword.Size = new System.Drawing.Size(185, 29);
            this.txtConfPassword.TabIndex = 6;
            this.txtConfPassword.TextChanged += new System.EventHandler(this.txtConfPassword_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.Teal;
            this.txtAddress.Location = new System.Drawing.Point(266, 306);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(443, 29);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(806, 101);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(165, 134);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // txtRefLastname
            // 
            this.txtRefLastname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRefLastname.ForeColor = System.Drawing.Color.Teal;
            this.txtRefLastname.Location = new System.Drawing.Point(267, 386);
            this.txtRefLastname.Name = "txtRefLastname";
            this.txtRefLastname.Size = new System.Drawing.Size(185, 29);
            this.txtRefLastname.TabIndex = 10;
            this.txtRefLastname.TextChanged += new System.EventHandler(this.txtRefLastname_TextChanged);
            // 
            // txtRefFirstname
            // 
            this.txtRefFirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRefFirstname.ForeColor = System.Drawing.Color.Teal;
            this.txtRefFirstname.Location = new System.Drawing.Point(525, 386);
            this.txtRefFirstname.Name = "txtRefFirstname";
            this.txtRefFirstname.Size = new System.Drawing.Size(185, 29);
            this.txtRefFirstname.TabIndex = 11;
            this.txtRefFirstname.TextChanged += new System.EventHandler(this.txtRefFirstname_TextChanged);
            // 
            // txtRefContact
            // 
            this.txtRefContact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRefContact.ForeColor = System.Drawing.Color.Teal;
            this.txtRefContact.Location = new System.Drawing.Point(267, 423);
            this.txtRefContact.Name = "txtRefContact";
            this.txtRefContact.Size = new System.Drawing.Size(185, 29);
            this.txtRefContact.TabIndex = 12;
            this.txtRefContact.TextChanged += new System.EventHandler(this.txtRefContact_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContact.ForeColor = System.Drawing.Color.Teal;
            this.txtContact.Location = new System.Drawing.Point(266, 271);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(185, 29);
            this.txtContact.TabIndex = 8;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label16.Location = new System.Drawing.Point(855, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "Form137";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label17.Location = new System.Drawing.Point(836, 444);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 21);
            this.label17.TabIndex = 3;
            this.label17.Text = "Endorsement";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2.Location = new System.Drawing.Point(803, 307);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(165, 134);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label18.Location = new System.Drawing.Point(41, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 21);
            this.label18.TabIndex = 3;
            this.label18.Text = "Profile Picture";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // pb3
            // 
            this.pb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb3.Location = new System.Drawing.Point(17, 98);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(165, 134);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 4;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBrowse1.Location = new System.Drawing.Point(850, 63);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(75, 33);
            this.btnBrowse1.TabIndex = 13;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBrowse2.Location = new System.Drawing.Point(854, 269);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 32);
            this.btnBrowse2.TabIndex = 14;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBrowse3.Location = new System.Drawing.Point(62, 63);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(75, 32);
            this.btnBrowse3.TabIndex = 15;
            this.btnBrowse3.Text = "Browse";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
            // 
            // txtBankID
            // 
            this.txtBankID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBankID.ForeColor = System.Drawing.Color.Teal;
            this.txtBankID.Location = new System.Drawing.Point(267, 127);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.Size = new System.Drawing.Size(185, 29);
            this.txtBankID.TabIndex = 3;
            this.txtBankID.TextChanged += new System.EventHandler(this.txtBankID_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(204, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(204, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Reference";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(666, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBrowse2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBrowse1);
            this.panel1.Controls.Add(this.btnBrowse3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.pb3);
            this.panel1.Controls.Add(this.pb2);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtConfPassword);
            this.panel1.Controls.Add(this.txtRefContact);
            this.panel1.Controls.Add(this.txtRefFirstname);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtRefLastname);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtBankID);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.bGender);
            this.panel1.Controls.Add(this.n);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Location = new System.Drawing.Point(8, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 591);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Student Registration Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1026, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.ComboBox bGender;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox txtRefLastname;
        private System.Windows.Forms.TextBox txtRefFirstname;
        private System.Windows.Forms.TextBox txtRefContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.TextBox txtBankID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}