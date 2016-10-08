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
        private Dictionary<String, String> _trainBindData;
        private String _departureDate;
        private String _returnDate;

        public Dictionary<String, String> AirportBindData { get { return _airportBindData; } set { _airportBindData = value; } }
        public Dictionary<String, String> TrainBindData { get { return _trainBindData; } set { _trainBindData = value; } }
        public String DepartureDate { get { return _departureDate; } set { _departureDate = value; } }
        public String ReturnDate { get { return _returnDate; } set { _returnDate = value; } }

        public Observer(String user_id)
        {
            Console.WriteLine("In the observer!");
            this._user_id = user_id;
            InitializeComponent();
            populateAirportBindData();
            populateTrainBindData();
        }

        private void populateAirportBindData()
        {

            pgsql db = new pgsql("SELECT name, acronym FROM hack.city;");
            List<Dictionary<String, String>> result = db.db_multirow();
            _airportBindData = new Dictionary<string, string>();

            for (int i = 0; i < result.Count; i++)
            {
                try
                {
                    //Console.WriteLine("name: " + result[i]["name"]);
                    //Console.WriteLine("acronym: " + result[i]["acronym"]);
                    if(!_airportBindData.ContainsKey((String)result[i]["name"]))
                    {
                        _airportBindData.Add((String)result[i]["name"], (String)result[i]["acronym"]);
                    }
                }
                catch (Exception exp)
                {
                    //MessageBox.Show("The error is: " + exp);
                }
            }
            this.airportCombo.DataSource = new BindingSource(_airportBindData, null);
            this.airportCombo.DisplayMember = "name";
        }

        private void populateTrainBindData()
        {

            pgsql db = new pgsql("SELECT name, station_id FROM hack.train_info;");
            List<Dictionary<String, String>> result = db.db_multirow();
            _trainBindData = new Dictionary<string, string>();

            for (int i = 0; i < result.Count; i++)
            {
                try
                {
                    //Console.WriteLine("name: " + result[i]["name"]);
                    //Console.WriteLine("acronym: " + result[i]["acronym"]);
                    if(!_trainBindData.ContainsKey((String)result[i]["name"]))
                    {
                        _trainBindData.Add((String)result[i]["name"], (String)result[i]["station_id"]);
                    }
                    
                }
                catch (Exception exp)
                {
                    //MessageBox.Show("The error is: " + exp);
                }
            }
            this.trainCombo.DataSource = new BindingSource(_trainBindData, null);
            this.trainCombo.DisplayMember = "name";
        }

        private void Observer_Load(object sender, EventArgs e)
        {

        }

        private void departureDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            
            if (this.departureDate.Value.ToLocalTime() >= today)
            {
                _departureDate = this.departureDate.Value.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Please specify after a day after today");
            }
            
        }

        private void returnDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            
            if (this.returnDate.Value.ToLocalTime() >= today)
            {
                _returnDate = this.returnDate.Value.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Please specify after today");
            }
        }
    }
}
