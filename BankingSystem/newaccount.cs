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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankingSystem
{
    public partial class newaccount : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        public newaccount()
        {
            InitializeComponent();
            string str = "Server = localhost; Port = 5432; Database = Dotnetlab; UserId = postgres; Password = root";
            conn = new NpgsqlConnection(str);
            conn.Open();
            string sql = "CREATE TABLE IF NOT EXISTS customer(ID SERIAL PRIMARY KEY,Name varchar(50),Address varchar(50),Dob varchar(50),Phone varchar(50),salary varchar(50))";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            name.Text = string.Empty;
            address.Text = string.Empty;
            dob.Text = string.Empty;
            phone.Text = string.Empty;
            balance.Text = string.Empty;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (name.Text != string.Empty && address.Text != string.Empty && dob.Text != string.Empty && phone.Text != null && balance.Text != null)
            {
                string sql = "INSERT INTO customer(Name,Address,Dob,Phone,balance) VALUES(@name,@address,@dob,@phone,@salary)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);

                cmd.Parameters.AddWithValue("@dob", dob.Value.ToString());
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@salary", balance.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                clear();
            }
         else
            {
                MessageBox.Show("fiil all field");
            }
        }

        private void newaccount_Load(object sender, EventArgs e)
        {

        }
    }
}
