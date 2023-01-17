namespace BankingSystem
{
    partial class signform
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
            this.label1 = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(214, 240);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(94, 29);
            this.signup.TabIndex = 1;
            this.signup.Text = "Sign up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(177, 53);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(217, 27);
            this.firstname.TabIndex = 6;
            this.firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(501, 53);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(230, 27);
            this.lastname.TabIndex = 7;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(177, 140);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(223, 27);
            this.username.TabIndex = 9;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(177, 186);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(223, 27);
            this.password.TabIndex = 10;
            // 
            // signform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.label1);
            this.Name = "signform";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.signform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button signup;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox firstname;
        private TextBox lastname;
        private TextBox username;
        private TextBox password;
    }
}