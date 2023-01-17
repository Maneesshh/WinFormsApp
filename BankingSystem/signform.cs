using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class signform : Form
    {
    
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        public signform()
        {
            InitializeComponent();
            string str = "Server = localhost; Port = 5432; Database = Dotnetlab; UserId = postgres; Password = root";
            conn = new NpgsqlConnection(str);
            conn.Open();
            string sql = "CREATE TABLE IF NOT EXISTS admin(eid INT,firstname varchar(50),lastname varchar(50),username varchar(50),password varchar(50))";
            cmd=new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void signform_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(firstname.Text != string.Empty && 
                lastname.Text != string.Empty && 
                username.Text != string.Empty && 
                password.Text != string.Empty)
            {
               
                string sql = "INSERT INTO admin(firstname,lastname,username,password) VALUES(@first,@last,@username,@password)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first", firstname.Text);
                cmd.Parameters.AddWithValue("@last", lastname.Text);
               
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            } else
            {
                MessageBox.Show("Fill all field");
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
