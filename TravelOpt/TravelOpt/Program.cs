using System;
using System.Collections.Generic;
using pg_data;
using System.Windows.Forms;

namespace TravelOpt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            List<Dictionary<String, String>> result = new List<Dictionary<String, String>>();
            DbQuery dbCall = new DbQuery("SELECT username FROM hack.user;");
            dbCall.execute();
            result = dbCall.getResults();
            Console.WriteLine("the number of results is: " + result.Count);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("Username: " + result[i]["username"]);
            }

            //dbCall.setQuery("INSERT INTO hack.user (username,email,first_name,last_name,user_password) VALUES ('durp', 'durp@test.com','durp_first','durp_last','passYO');");
            //dbCall.db_dml();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            if (loginForm.loggedIn)
            {
                Console.WriteLine("Your in the app!" + loginForm.user_id);
                Application.Run(new Home(loginForm.user_id));
            }
            else
            {
                MessageBox.Show("You failed to login!");
            }
            //Train train = new Train();
            //train.apiComTest();

            //Airplane airplane = new Airplane();
            //airplane.apiComTest();

        }
    }
}
