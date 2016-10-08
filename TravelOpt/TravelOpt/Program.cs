using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;
using pg_data;

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

            pgsql dbCall = new pgsql("SELECT username FROM hack.user;");
            List<Dictionary<String, String>> result = dbCall.db_multirow();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("Username: " + result[i]["username"]);
            }

            dbCall.setQuery("INSERT INTO hack.user (username,email,first_name,last_name,user_password) VALUES ('durp', 'durp@test.com','durp_first','durp_last','passYO');");
            dbCall.db_dml();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            Train train = new Train();
            //train.apiComTest();

            Airplane airplane = new Airplane();
            //airplane.apiComTest();
        }
    }
}
