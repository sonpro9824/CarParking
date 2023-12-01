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
    
    public partial class Attendant_form : Form
    {
        Attendant_Information attendant = new Attendant_Information();
        Attendant_DataDataContext dataContext = new Attendant_DataDataContext();
        public Attendant_form(int Attendant_id)
        {
            InitializeComponent();
            attendant.ID1 = Attendant_id;
            Attendant temp = (from a in dataContext.Attendants where a.Id == Attendant_id select a).FirstOrDefault();
            Attendant_Information.Transfer_Attendant_Information(ref attendant, temp);
        }

        private void Attendant_form_Load(object sender, EventArgs e)
        {

        }

        private void Prinf_detail_label_Click(object sender, EventArgs e)
        {
            attendant.PrinfDetail();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendant_Parking attendant_Parking = new Attendant_Parking();
            attendant_Parking.Show();
        }
    }
}
