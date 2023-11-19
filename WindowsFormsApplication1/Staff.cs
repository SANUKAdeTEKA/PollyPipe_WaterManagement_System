using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Staff : Form
    {
        private SqlConnection con;

        public Staff()
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sqldelete;
                sqldelete = ("delete from Staff where Staff_ID ='" + button4.Text + "'");
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {

                MessageBox.Show("Staff ID isn’t recognized!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            clear();
            con.Close();
        }

        private void clear()
        {
            throw new NotImplementedException();
        }
    }
}
