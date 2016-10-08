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

namespace TravelOpt
{
    public partial class Observer : Form
    {
        private NpgsqlConnection _conn;
        private Dictionary<string, string> _airportBindData;
        
        public Dictionary<string, string> AirportBindData { get { return _airportBindData; } set { _airportBindData = value; } }
        public NpgsqlConnection Conn { get { return _conn; } set { _conn = value; } }

        
        public Observer(NpgsqlConnection conn)
        {
            _conn = conn;
            populateAirportBindData();
            InitializeComponent();
        }

        private void populateAirportBindData()
        {
            try
            {
                _conn.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error " + exp);
            }

            NpgsqlCommand command = new NpgsqlCommand("SELECT name, acronym FROM hack.city LIMIT 100;", _conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
                _airportBindData.Add((string)dr[0], (string)dr[1]);

            try
            {
                _conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error :S");
            }
        }
    }
}
