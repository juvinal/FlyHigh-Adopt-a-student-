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
    public partial class MyStudents : Form
    {
        public MyStudents()
        {
            InitializeComponent();
            dataGridView1.DataSource = ClsProcedures.MyStudent(txtBankID.Text);
        }

        SqlConnection con = new SqlConnection(@"Data Source = .\sqlexpress;Initial Catalog=DbSystem;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            for (int i = 0; i < ClsProcedures.References().Count; i++)
            {
                if (ClsProcedures.References()[i].BankID.Contains(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    lblRefName.Text = ClsProcedures.References()[i].ReferenceLastname + " " + ClsProcedures.References()[i].ReferenceFirstname;
                    lblRefContact.Text = ClsProcedures.References()[i].ReferenceContact;
                }
            }
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Intro form = new Intro();
            form.Show();
            this.Hide();
        }
    }
}
