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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            txtUsername.ForeColor = SystemColors.GrayText;
            txtUsername.Text = "Username";
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            txtPassword.ForeColor = SystemColors.GrayText;
            txtPassword.Text = "Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
        }

        string id, user, pass, usertype, name, gender, address, contact;
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length==0)
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (    txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Teal;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Intro form = new Intro();
            form.Show();
            this.Hide();
        }

        //for the password
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
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClsProcedures.Accounts().Count; i++)
            {
                if (ClsProcedures.Accounts()[i].Username == txtUsername.Text && ClsProcedures.Accounts()[i].PAssword == txtPassword.Text)
                {
                    id = ClsProcedures.Accounts()[i].BankID.ToString();
                    user = ClsProcedures.Accounts()[i].Username.ToString();
                    pass = ClsProcedures.Accounts()[i].PAssword.ToString();
                    usertype = ClsProcedures.Accounts()[i].Usertype.ToString();
                    name = ClsProcedures.Accounts()[i].LastName + ", " + ClsProcedures.Accounts()[i].Firstname;
                    gender = ClsProcedures.Accounts()[i].Gender;
                    address = ClsProcedures.Accounts()[i].Address;
                    contact = ClsProcedures.Accounts()[i].Contact;
                }
               
            }

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (txtUsername.Text == user)
                {
                    if (txtPassword.Text == pass)
                    {
                        if (usertype == "Donor") 
                        {   
                            Form2 form = new Form2();
                            form.Show();
                            this.Hide();
                            form.txtBankID.Text = id;
                            form.lblName.Text = name;
                            form.lblGender.Text = gender;
                            form.lblContact.Text = contact;
                            form.lblAddress.Text = address;
                        }
                        else {
                            Main form = new Main();
                            form.Show();
                            this.Hide();
                            form.txtBankID.Text = id;
                            form.lblName.Text = name;
                            form.lblGender.Text = gender;
                            form.lblContact.Text = contact;
                            form.lblAddress.Text = address;
                        }
                    }
                    else
                    {
                        txtPassword.BackColor = Color.MistyRose;
                        txtPassword.ForeColor = SystemColors.GrayText;
                        txtPassword.Text = "Password";
                        this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
                        this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
                        txtPassword.Focus();
                    }
                }
                else
                {
                    txtUsername.BackColor = Color.MistyRose;
                    txtPassword.BackColor = Color.MistyRose;
                    txtUsername.ForeColor = SystemColors.GrayText;
                    txtUsername.Text = "Username";
                    this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
                    this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
                    txtPassword.ForeColor = SystemColors.GrayText;
                    txtPassword.Text = "Password";
                    this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
                    this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
                    txtUsername.Focus();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
