using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FlyHigh
{
    public partial class SignUp : Form
    {
        public SignUp()
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

            txtRefLastname.ForeColor = SystemColors.GrayText;
            txtRefLastname.Text = "Reference Last Name";
            this.txtRefLastname.Leave += new System.EventHandler(this.txtRefLastname_Leave);
            this.txtRefLastname.Enter += new System.EventHandler(this.txtRefLastname_Enter);

            txtRefFirstname.ForeColor = SystemColors.GrayText;
            txtRefFirstname.Text = "Reference First Name";
            this.txtRefFirstname.Leave += new System.EventHandler(this.txtRefFirstname_Leave);
            this.txtRefFirstname.Enter += new System.EventHandler(this.txtRefFirstname_Enter);

            txtRefContact.ForeColor = SystemColors.GrayText;
            txtRefContact.Text = "Reference Contact No.";
            this.txtRefContact.Leave += new System.EventHandler(this.txtRefContact_Leave);
            this.txtRefContact.Enter += new System.EventHandler(this.txtRefContact_Enter);

            bGender.ForeColor = SystemColors.GrayText;
            bGender.Text = "Gender";
            this.bGender.Leave += new System.EventHandler(this.bGender_Leave);
            this.bGender.Enter += new System.EventHandler(this.bGender_Enter);

        }
        private void bGender_Leave(object sender, EventArgs e)
        {
            if (bGender.SelectedValue == null)
            {
                bGender.Text = "Gender";
                bGender.ForeColor = SystemColors.GrayText;
            }
        }

        private void bGender_Enter(object sender, EventArgs e)
        {
            if (bGender.Text == "Gender")
            {
                bGender.Text = "";
                bGender.ForeColor = Color.Teal;
            }
        }
        private void txtRefContact_Leave(object sender, EventArgs e)
        {
            if (txtRefContact.Text.Length == 0)
            {
                txtRefContact.Text = "Reference Contact No.";
                txtRefContact.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtRefContact_Enter(object sender, EventArgs e)
        {
            if (txtRefContact.Text == "Reference Contact No.")
            {
                txtRefContact.Text = "";
                txtRefContact.ForeColor = Color.Teal;
            }
        }

        private void txtRefFirstname_Leave(object sender, EventArgs e)
        {
            if (txtRefFirstname.Text.Length == 0)
            {
                txtRefFirstname.Text = "Reference First Name";
                txtRefFirstname.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtRefFirstname_Enter(object sender, EventArgs e)
        {
            if (txtRefFirstname.Text == "Reference First Name")
            {
                txtRefFirstname.Text = "";
                txtRefFirstname.ForeColor = Color.Teal;
            }
        }


        private void txtRefLastname_Leave(object sender, EventArgs e)
        {
            if (txtRefLastname.Text.Length == 0)
            {
                txtRefLastname.Text = "Reference Last Name";
                txtRefLastname.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtRefLastname_Enter(object sender, EventArgs e)
        {
            if (txtRefLastname.Text == "Reference Last Name")
            {
                txtRefLastname.Text = "";
                txtRefLastname.ForeColor = Color.Teal;
            }
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
        SqlConnection con = new SqlConnection(@"Data Source = .\sqlexpress;Initial Catalog=DbSystem;Integrated Security=True");
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClsProcedures.Accounts().Count; i++)
            {
                if (ClsProcedures.Accounts()[i].Username.Contains(txtUsername.Text))
                {
                    user = ClsProcedures.Accounts()[i].Username;
                }
            }
            if (txtAddress.Text != "" && txtBankID.Text != "" && txtConfPassword.Text != "" && txtContact.Text != "" && txtFirstname.Text != "" && txtLastname.Text != "" && txtPassword.Text != "" && txtRefContact.Text != "" && txtRefFirstname.Text != "" && txtRefLastname.Text != "" && txtUsername.Text != "")
            {
                if (txtPassword.Text == txtConfPassword.Text)
                {
                    if (user == txtUsername.Text)
                    {
                        MessageBox.Show("Username already used!");
                    }
                    else
                    {
                        int i = 0;
                        tblUser tbl1 = new tblUser();
                        tbl1.BankID = txtBankID.Text;
                        tbl1.LastName = txtLastname.Text;
                        tbl1.Firstname = txtFirstname.Text;
                        tbl1.Username = txtUsername.Text;
                        tbl1.PAssword = txtPassword.Text;
                        tbl1.Gender = bGender.Text;
                        tbl1.Contact = txtContact.Text;
                        tbl1.Address = txtAddress.Text;
                        tbl1.Usertype = "Student";
                        StudentReference tbl2 = new StudentReference();
                        tbl2.ReferenceLastname = txtRefLastname.Text;
                        tbl2.ReferenceFirstname = txtFirstname.Text;
                        tbl2.ReferenceContact = txtContact.Text;
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Insert into StudentReference values('"+txtBankID.Text+"','"+ txtRefLastname.Text+"','"+txtRefFirstname.Text+"','"+txtRefContact.Text+"', @Form137, @Endorsement, @Others)", con);
                        MemoryStream stream1 = new MemoryStream();
                        MemoryStream stream2 = new MemoryStream();
                        MemoryStream stream3 = new MemoryStream();
                        pb1.Image.Save(stream1, System.Drawing.Imaging.ImageFormat.Png);
                        pb2.Image.Save(stream2, System.Drawing.Imaging.ImageFormat.Png);
                        pb3.Image.Save(stream3, System.Drawing.Imaging.ImageFormat.Png);

                        byte[] pic1 = stream1.ToArray();
                        byte[] pic2 = stream2.ToArray();
                        byte[] pic3 = stream3.ToArray();
                        ClsProcedures.SignUp(tbl1);
                        cmd.Parameters.AddWithValue("@Form137", pic1);
                        cmd.Parameters.AddWithValue("@Endorsement", pic2);
                        cmd.Parameters.AddWithValue("@Others", pic3);
                        i = cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the inputable fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG|*.png";
            DialogResult res = openFileDialog1.ShowDialog();
            if(res == DialogResult.OK)
            {
                pb1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG|*.png";
            DialogResult res = openFileDialog1.ShowDialog();
            if(res == DialogResult.OK)
            {
                pb2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnBrowse3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG|*.png";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pb3.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }



        private void n_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void bGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void txtRefLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRefFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRefContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pb2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pb3_Click(object sender, EventArgs e)
        {

        }

        private void txtBankID_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Intro form = new Intro();
            form.Show();
            this.Hide();
        }

    }
}
