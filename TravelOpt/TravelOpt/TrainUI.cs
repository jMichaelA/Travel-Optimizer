using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelFactory;

namespace TravelFactory
{
    public partial class TrainUI : Form
    {
        public TrainUI()
        {
            InitializeComponent();
        }

        private void TrainUI_Load(object sender, EventArgs e)
        {
            getMethod();
        }

        private Label departureLabel;
    }
}
