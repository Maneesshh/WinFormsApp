using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class Balancesheet : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        int customerId;
        public Balancesheet()
        {
            InitializeComponent();
            string str = "Server = localhost; Port = 5432; Database = Dotnetlab; UserId = postgres; Password = root";
            conn = new NpgsqlConnection(str);
            conn.Open();
            display();
            clear();
        }

        private void Balancesheet_Load(object sender, EventArgs e)
        {

        }
        public void display()
        {
            string sql = "SELECT * FROM customer";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
        }
        public void clear()
        {
            name.Text= string.Empty;
            address.Text= string.Empty;
            Dob.Text = string.Empty;
            phone.Text= string.Empty;
            salary.Text= string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            address.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Dob.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            phone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            salary.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE customer Set Name = @name, Address= @address, Dob = @dob, Phone = @phone, salary = @salary WHERE  Id = @id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@address", address.Text);
            cmd.Parameters.AddWithValue("@dob", Dob.Value.ToString());
            cmd.Parameters.AddWithValue("@phone", phone.Text);
            cmd.Parameters.AddWithValue("@salary", salary.Text);
            cmd.Parameters.AddWithValue("@id", customerId);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            display();
            clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM customer WHERE Id='" + customerId + "' ";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            display();
            clear();
        }
    }
}
