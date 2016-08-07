using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyHigh
{
    public partial class SignUp2 : Form
    {
        public SignUp2()
        {
            InitializeComponent();
            txtLastname.ForeColor = SystemColors.GrayText;
            txtLastname.Text = "Last Name";
            this.txtLastname.Leave += new System.EventHandler(this.txtLastname_Leave);
            this.txtLastname.Enter += new System.EventHandler(this.txtLastname_Enter);
            txtFirstname.ForeColor = SystemColors.GrayText;
            txtFirstname.Text = "First Name";
            this.txtFirstname.Leave += new System.EventHandler(this.txtFirstname_Leave);
            this.txtFirstname.Enter += new System.EventHandler(this.txtFirstname_Enter);

            txtBankID.ForeColor = SystemColors.GrayText;
            txtBankID.Text = "Unionbank ID";
            this.txtBankID.Leave += new System.EventHandler(this.txtBankID_Leave);
            this.txtBankID.Enter += new System.EventHandler(this.txtBankID_Enter);

            txtUsername.ForeColor = SystemColors.GrayText;
            txtUsername.Text = "Username";
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);

            txtPassword.ForeColor = SystemColors.GrayText;
            txtPassword.Text = "Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);

            txtConfPassword.ForeColor = SystemColors.GrayText;
            txtConfPassword.Text = "Confirm Password";
            this.txtConfPassword.Leave += new System.EventHandler(this.txtConfPassword_Leave);
            this.txtConfPassword.Enter += new System.EventHandler(this.txtConfPassword_Enter);

            txtContact.ForeColor = SystemColors.GrayText;
            txtContact.Text = "Contact No.";
            this.txtContact.Leave += new System.EventHandler(this.txtContact_Leave);
            this.txtContact.Enter += new System.EventHandler(this.txtContact_Enter);

            txtAddress.ForeColor = SystemColors.GrayText;
            txtAddress.Text = "Address";
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);

        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length == 0)
            {
                txtAddress.Text = "Address";
                txtAddress.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.Teal;
            }
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (txtContact.Text.Length == 0)
            {
                txtContact.Text = "Contact No.";
                txtContact.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtContact_Enter(object sender, EventArgs e)
        {
            if (txtContact.Text == "Contact No.")
            {
                txtContact.Text = "";
                txtContact.ForeColor = Color.Teal;
            }
        }

        private void txtConfPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfPassword.Text.Length == 0)
            {
                txtConfPassword.Text = "Confirm Password";
                txtConfPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtConfPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfPassword.Text == "Confirm Password")
            {
                txtConfPassword.Text = "";
                txtConfPassword.ForeColor = Color.Teal;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Teal;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Teal;
            }
        }


        private void txtBankID_Leave(object sender, EventArgs e)
        {
            if (txtBankID.Text.Length == 0)
            {
                txtBankID.Text = "Unionbank ID";
                txtBankID.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtBankID_Enter(object sender, EventArgs e)
        {
            if (txtBankID.Text == "Unionbank ID")
            {
                txtBankID.Text = "";
                txtBankID.ForeColor = Color.Teal;
            }
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Length == 0)
            {
                txtFirstname.Text = "First Name";
                txtFirstname.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtFirstname_Enter(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "First Name")
            {
                txtFirstname.Text = "";
                txtFirstname.ForeColor = Color.Teal;
            }
        }
        private void txtLastname_Leave(object sender, EventArgs e)
        {
            if (txtLastname.Text.Length == 0)
            {
                txtLastname.Text = "Last Name";
                txtLastname.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtLastname_Enter(object sender, EventArgs e)
        {
            if (txtLastname.Text == "Last Name")
            {
                txtLastname.Text = "";
                txtLastname.ForeColor = Color.Teal;
            }
        }
        string user;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClsProcedures.Accounts().Count; i++)
            {
                if (ClsProcedures.Accounts()[i].Username.Contains(txtUsername.Text))
                {
                    user = ClsProcedures.Accounts()[i].Username;
                }
            }
            if (user == txtUsername.Text)
            {
                MessageBox.Show("Username already used");
            }
            else
            {
                tblUser tbl1 = new tblUser();
                tbl1.BankID = txtBankID.Text;
                tbl1.LastName = txtLastname.Text;
                tbl1.Firstname = txtFirstname.Text;
                tbl1.Username = txtUsername.Text;
                tbl1.PAssword = txtPassword.Text;
                tbl1.Gender = bGender.Text;
                tbl1.Contact = txtContact.Text;
                tbl1.Address = txtAddress.Text;
                tbl1.Usertype = "Donor";
                ClsProcedures.SignUp(tbl1);
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void n_Click(object sender, EventArgs e)
        {
            Intro form = new Intro();
            form.Show();
            this.Hide();
        }
    }
}
