using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParking
{
    public partial class Manage_Parking_Space : Form
    {
        public Manage_Parking_Space()
        {
            InitializeComponent();
        }

        private void Manage_Parking_Space_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pakingDataSet.ParkingSpace' table. You can move, or remove it, as needed.
            this.parkingSpaceTableAdapter.Fill(this.pakingDataSet.ParkingSpace);

        }
    }
}
