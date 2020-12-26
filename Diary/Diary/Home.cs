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
             
            string sql = "INSERT INTO [dbo].[event]([Event],[Text],[Priority],[Date])VALUES('" + EventName.Text + "','" + text.Text + "','" + PriorityBox.Text + "','" + DateTime.Today + "')";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (EventName.Text == "")
                MessageBox.Show("Please enter event name");
            else if (PriorityBox.Text == "")
                MessageBox.Show("Please select event priority");
            else if (text.Text == "")
                MessageBox.Show("Please enter event text");
           
            else if (result > 0)
            {
                MessageBox.Show("Event added successfully");
                text.Text = string.Empty;
                EventName.Text = string.Empty;
                PriorityBox.Text = string.Empty;
                EventDate.Text = string.Empty;
            }
            else
                MessageBox.Show("Error in adding Event");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Welcome wc = new Welcome();
            wc.Show();
            this.Hide();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-V0HR07H\SQLEXPRESS;Initial Catalog=DigitalDiary;Integrated Security=True");
            connection.Open();
            string sql = "delete from [event] where Event='" + EventName.Text + "'";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {
                MessageBox.Show("Event Deleted successfully");
                text.Text = string.Empty;
                EventName.Text = string.Empty;
                PriorityBox.Text = string.Empty;
                EventDate.Text = string.Empty;
            }
            else
                MessageBox.Show("Error in deleting Event");

        }

        private void Update_Click(object sender, EventArgs e)
        {
             SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-V0HR07H\SQLEXPRESS;Initial Catalog=DigitalDiary;Integrated Security=True");
            connection.Open();
            string sql = "update [dbo].[event] set Text='" + text.Text + "' , Date= '" + DateTime.Today + "', Priority= '" + PriorityBox.Text + "' where Event='" + EventName.Text + "'";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
           
            if (result > 0)
            {
                MessageBox.Show("Event updated successfully");
                text.Text = string.Empty;
                EventName.Text = string.Empty;
                PriorityBox.Text = string.Empty;
                EventDate.Text = string.Empty;
            }
            else
                MessageBox.Show("Error in updating Event");
        
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
            EventName.Text = selectedRow.Cells[0].Value.ToString();
            PriorityBox.Text = selectedRow.Cells[1].Value.ToString();
            EventDate.Text = selectedRow.Cells[2].Value.ToString();
            text.Text = selectedRow.Cells[3].Value.ToString();
        }
    }
}
