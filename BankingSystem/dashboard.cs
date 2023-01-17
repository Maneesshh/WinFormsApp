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
    public partial class dashboard : Form
    {
        
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        public dashboard()
        {
            InitializeComponent();
            string str = "Server = localhost; Port = 5432; Database = Dotnetlab; UserId = postgres; Password = root";
            conn = new NpgsqlConnection(str);
            conn.Open();
        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newAccoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newaccount newaccount = new newaccount();
            newaccount.MdiParent= this;
            newaccount.Show();
        }

        private void searchupdateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchupdate su= new searchupdate();
            su.MdiParent= this;
            su.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balancesheet balancesheet= new Balancesheet();
            balancesheet.MdiParent= this;
            balancesheet.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
