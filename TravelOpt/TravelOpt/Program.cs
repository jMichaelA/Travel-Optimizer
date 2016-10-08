using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TravelOpt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=pellefant-02.db.elephantsql.com;Port=5432;UserId=lzukdgiw;Password=P3RvimsAf1G_GxCUVwNYGwaKPWSR5Dop;Database=lzukdgiw;");

            try
            {
                conn.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error :S");
            }

            // Do DB stuff here

            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error :S");
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            Train train = new Train();
            train.apiComTest();

            Airplane airplane = new Airplane();
            airplane.apiComTest();
        }
    }
}
