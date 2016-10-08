using Npgsql;
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
    public partial class Observer : Form
    {
        private String _user_id;
        private Dictionary<String, String> _airportBindData;
        
        public Dictionary<String, String> AirportBindData { get { return _airportBindData; } set { _airportBindData = value; } }
        
        public Observer(String user_id)
        {
            Console.WriteLine("In the observer!");
            this._user_id = user_id;
            populateAirportBindData();
            InitializeComponent();
        }

        private void populateAirportBindData()
        {

            pgsql db = new pgsql("SELECT name, acronym FROM hack.city LIMIT 100;");
            List<Dictionary<String, String>> result = db.db_multirow();
            _airportBindData = new Dictionary<string, string>();

            for (int i = 0; i < result.Count; i++)
            {
                try
                {
                    //Console.WriteLine("name: " + result[i]["name"]);
                    //Console.WriteLine("acronym: " + result[i]["acronym"]);
                    _airportBindData.Add((String)result[i]["name"], (String)result[i]["acronym"]);
                }
                catch (Exception exp)
                {
                    //MessageBox.Show("The error is: " + exp);
                }
            }
        }

        private void Observer_Load(object sender, EventArgs e)
        {

        }
    }
}
