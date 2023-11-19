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
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Equipment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NOTEBOOK-RAJITH\\SQLEXPRESS;Initial Catalog=pollypipe;Integrated Security=True");

        public Equipment()
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void Clear_Controls()
        {
            throw new NotImplementedException();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlSearch;
            sqlSearch = "select * from Equipment where Equipment_ID  = '" + txtequipmentid.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtequipmentname.Text = dr["Equipment_Name"].ToString();
                txtequipmenttype.Text = dr["Equipment_Type"].ToString();
            }
            else
            {
                MessageBox.Show("Incorrect Equipment ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_Controls();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert;
                sqlinsert = ("insert into Equipment(Equipment_ID,Equipment_type,Equipment_name) values('" + txtequipmentid.Text + "' , '" + txtequipmenttype.Text + "','" + txtequipmentname.Text + "' )");
                SqlCommand cmd = new SqlCommand(sqlinsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data inserted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sqldelete;
                sqldelete = ("delete from Equipment where Equipment_ID ='" + button4.Text + "'");
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {

                MessageBox.Show("Staff ID isn’t recognized!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            con.Close();
        }
    }
}
