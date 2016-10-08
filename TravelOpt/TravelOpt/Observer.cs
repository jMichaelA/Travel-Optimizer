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
        private int _user_id;
        private Dictionary<string, string> _airportBindData;
        
        public Dictionary<string, string> AirportBindData { get { return _airportBindData; } set { _airportBindData = value; } }
        
        public Observer(int user_id)
        {
            this._user_id = user_id;
            populateAirportBindData();
            InitializeComponent();
        }

        private void populateAirportBindData()
        {

            pgsql db = new pgsql("SELECT name, acronym FROM hack.city;");
            List<Dictionary<String, String>> result = db.db_multirow();

            for (int i = 0; i < result.Count; i++)
            {
                _airportBindData.Add((string)result[i]["name"], (string)result[i]["acronym"]);
            }
        }

        private void Observer_Load(object sender, EventArgs e)
        {

        }
    }
}
