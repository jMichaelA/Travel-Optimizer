using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace pg_data
{
    class pgsql
    {
        private String queryString;

        public pgsql(String query)
        {
            this.queryString = query;
        }

        public List<Dictionary<String, String>> run()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=pellefant-02.db.elephantsql.com;Port=5432;User Id=lzukdgiw;Password=P3RvimsAf1G_GxCUVwNYGwaKPWSR5Dop;Database=lzukdgiw;");
            try
            {
                conn.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error :S" + exp);
            }

            NpgsqlCommand command = new NpgsqlCommand(this.queryString, conn);
            Console.WriteLine("query: " + this.queryString);
            NpgsqlDataReader dr = command.ExecuteReader();

            List<Dictionary<String, String>> listOfRecords = new List<Dictionary<String, String>>();
            while(dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Dictionary<String, String> tempDictionary = new Dictionary<String, String>();
                    tempDictionary.Add((String)dr.GetName(i), (String)dr.GetString(i));
                    listOfRecords.Add(tempDictionary);
                }
            }

            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error :S");
            }

            return listOfRecords;
        }
    }
}
