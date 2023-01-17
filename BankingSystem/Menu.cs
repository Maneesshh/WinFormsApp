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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signform signform = new signform();
          //  signform.MdiParent = Menu.ActiveForm;
            signform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
           // login_Form.MdiParent= this;
            login_Form.Show();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
