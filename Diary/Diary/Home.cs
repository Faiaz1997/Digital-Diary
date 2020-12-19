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

namespace Diary
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-V0HR07H\SQLEXPRESS;Initial Catalog=Diary;Integrated Security=True");
            connection.Open();
            string sql = "INSERT INTO [dbo].[event]([Text])VALUES('" + text.Text + "')";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
          if (result > 0)
            {
                MessageBox.Show("Text added successfully");
                text.Text = string.Empty;
            }
            else
                MessageBox.Show("Error in adding text.");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Welcome wc = new Welcome();
            wc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Modify_Click(object sender, EventArgs e)
        {
          
        }
    }
}
