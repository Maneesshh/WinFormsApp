namespace BankingSystem
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.user1 = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(55, 132);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 20);
            this.name.TabIndex = 0;
            this.name.Text = "User Name";
            this.name.Click += new System.EventHandler(this.username_Click);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(55, 194);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(70, 20);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            this.pass.Click += new System.EventHandler(this.label2_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Admin.Location = new System.Drawing.Point(150, 32);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(186, 38);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin Login";
            this.Admin.Click += new System.EventHandler(this.label3_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(177, 259);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(94, 29);
            this.login.TabIndex = 5;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // user1
            // 
            this.user1.Location = new System.Drawing.Point(176, 134);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(221, 27);
            this.user1.TabIndex = 6;
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(176, 194);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(212, 27);
            this.pass1.TabIndex = 7;
            this.pass1.UseSystemPasswordChar = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(473, 388);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name;
        private Label pass;
        private Label Admin;
        private Button login;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private TextBox user1;
        private TextBox pass1;
    }
}