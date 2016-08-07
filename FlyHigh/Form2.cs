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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = ClsProcedures.Students();
            txtBankID.ForeColor = SystemColors.GrayText;
            txtBankID.Text = "Unionbank ID";
            this.txtBankID.Leave += new System.EventHandler(this.txtBankID_Leave);
            this.txtBankID.Enter += new System.EventHandler(this.txtBankID_Enter);
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

        SqlConnection con = new SqlConnection(@"Data Source = .\sqlexpress;Initial Catalog=DbSystem;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Form137, Endorsement, Others from StudentReference where BankID =" + dataGridView1.SelectedRows[0].Cells[0].Value, con);
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            byte[] mydata1 = new byte[0];
            byte[] mydata2 = new byte[0];
            byte[] mydata3 = new byte[0];
            da.Fill(ds, "StudentReference");
            DataRow myrow = ds.Tables["StudentReference"].Rows[0];
            mydata1 = (byte[])myrow["FOrm137"];
            mydata2 = (byte[])myrow["Endorsement"];
            mydata3 = (byte[])myrow["Others"];
            MemoryStream stream1 = new MemoryStream(mydata1);
            MemoryStream stream2 = new MemoryStream(mydata2);
            MemoryStream stream3 = new MemoryStream(mydata3);
            pb1.Image = Image.FromStream(stream1);
            pb2.Image = Image.FromStream(stream2);
            pb3.Image = Image.FromStream(stream3);
            lblStudentName.Text = dataGridView1.SelectedRows[0].Cells[2].Value + " " + dataGridView1.SelectedRows[0].Cells[1].Value;
            lblStudentGender.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            lblStudContact.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            lblStudAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            lblBankID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            for(int i = 0; i < ClsProcedures.References().Count; i++)
            {
                if(ClsProcedures.References()[i].BankID.Contains(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    lblRefName.Text = ClsProcedures.References()[i].ReferenceLastname + " " + ClsProcedures.References()[i].ReferenceFirstname;
                    lblRefContact.Text = ClsProcedures.References()[i].ReferenceContact;
                }
            }
            con.Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void txtBankID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void myStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyStudents form = new MyStudents();
            form.Show();
            form.txtBankID.Text = txtBankID.Text;
            form.dataGridView1.DataSource = ClsProcedures.MyStudent(txtBankID.Text);
        }

        private void btnAdopt_Click(object sender, EventArgs e)
        {
            tblUser tbl = new tblUser();
            tbl.BankID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbl.Usertype = txtBankID.Text;  
            ClsProcedures.UpdateStudent(tbl);
            dataGridView1.DataSource = ClsProcedures.Students();
            MessageBox.Show(tbl.BankID.ToString()+tbl.Usertype.ToString());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Intro form = new Intro();
            form.Show();
            this.Hide();
        }
    }
}
