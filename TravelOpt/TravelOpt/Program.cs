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

            pgsql query = new pgsql("SELECT username FROM hack.user;");
            List<Dictionary<String, String>> result = query.run();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("Username: " + result[i]["username"]);
            }

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
