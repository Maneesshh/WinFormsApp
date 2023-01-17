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
    public partial class Login_Form : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        public Login_Form()
        {
            InitializeComponent();
            string str = "Server = localhost; Port = 5432; Database = Dotnetlab; UserId = postgres; Password = root";
            conn = new NpgsqlConnection(str);
            conn.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(user1.Text != string.Empty && pass1.Text != string.Empty) 
            {
                string sql = "SELECT count(*) FROM admin WHERE username=@user AND password=@pass";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", user1.Text);
                cmd.Parameters.AddWithValue("@pass", pass1.Text);
                int a=(int)(long)cmd.ExecuteScalar();
                if(a>0)
                {
                    dashboard dashboard = new dashboard();
                    dashboard.ShowDialog(); 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Faild");
                }
               // cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Fill all field");
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
