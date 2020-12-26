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

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-V0HR07H\SQLEXPRESS;Initial Catalog=DigitalDiary;Integrated Security=True");
            connection.Open();
            string sql = "INSERT INTO [dbo].[event]([Event],[Text],[Priority],[Date])VALUES('" + EventName.Text + "','" + text.Text + "','" + PriorityBox.Text + "','" + this.EventDate.Text + "')";

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

        private void Remove_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
          
        }

        private void View_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V0HR07H\SQLEXPRESS;Initial Catalog=DigitalDiary;Integrated Security=True");
            con.Open();
            string query = "SELECT * FROM [dbo].[event]";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            text.Text = selectedRow.Cells[4].Value.ToString();
        }
    }
}
