using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pg_data;

namespace TravelOpt
{
    public partial class LoginForm : Form
    {
        public bool loggedIn = false;
        public String user_id;

        public LoginForm()
        {
            InitializeComponent();
            loginFailedLabel.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            String username = this.userNameText.Text;
            String password = this.passwordText.Text;

            pgsql db = new pgsql(@"SELECT * 
                                    FROM hack.user 
                                    WHERE username = '" + username + "' AND user_password = '" + password + "';");

            List<Dictionary<String, String>> result = db.db_multirow();
            if (result.Count > 0)
            {
                Console.WriteLine("Logged in!");
                this.loggedIn = true;
                this.user_id = result[0]["user_id"];
                this.Close();
            }
            else
            {
                Console.WriteLine("Failed!");
                loginFailedLabel.Show();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            String username = this.newUsernameText.Text;
            String email = this.newEmailText.Text;
            String pass1 = this.newPassword1Text.Text;
            String pass2 = this.newPassword2Text.Text;

            if (pass1 != pass2)
            {
                MessageBox.Show("Your passwords don't match!");
            }
            else
            {
                pgsql db = new pgsql(@"SELECT * 
                                    FROM hack.user 
                                    WHERE username = '" + username + "';");
                List<Dictionary<String, String>>  result = db.db_multirow();
                if (result.Count <= 0)
                {
                    db.setQuery(@"SELECT * 
                                    FROM hack.user 
                                    WHERE email = '" + email + "';");

                    result = db.db_multirow();
                    if (result.Count <= 0)
                    {
                        //Create account here.
                        db.setQuery(@"INSERT INTO hack.user (
                                        username,
                                        email,
                                        user_password,
                                        first_name,
                                        last_name
                                    ) VALUES (
                                        '"+ username +"','"+ email +"','"+ pass1 + "', ' ', ' '" + @"
                                    );");
                        db.db_dml();

                        db.setQuery(@"SELECT * FROM hack.user WHERE email = '" + email + "';");
                        result = db.db_multirow();
                        this.loggedIn = true;
                        this.user_id = result[0]["user_id"];
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("That email is already taken!");
                    }
                }
                else
                {
                    MessageBox.Show("That username is already taken!");
                }
            }
        }
    }
}
