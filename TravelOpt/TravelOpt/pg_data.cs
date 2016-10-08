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

        private String formatString(String sql)
        {
            //sql = sql.Replace(System.Environment.NewLine, "replacement text");
            sql.Trim(new Char[] { '\n', '\r'});
            return sql;
        }

        public void setQuery(String sql)
        {
            this.queryString = sql;
        }

        public List<Dictionary<String, String>> db_multirow()
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

            List<Dictionary<String, String>> listOfRecords = new List<Dictionary<String, String>>();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(formatString(this.queryString), conn);
                //Console.WriteLine("query: " + this.queryString);
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        Dictionary<String, String> tempDictionary = new Dictionary<String, String>();
                        tempDictionary.Add((String)dr.GetName(i), (String)dr.GetString(i));
                        listOfRecords.Add(tempDictionary);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error :S" + exp);
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

        public bool db_dml()
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

            // TODO: implement parsing methods to add parameters to query to prevent SQL injection.
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(this.queryString, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error :S" + exp);
            }

            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error :S");
            }

            return true;
        }

        
    }
}
