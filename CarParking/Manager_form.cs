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
    public partial class Manager_form : Form
    {
        Manager_Information manager = new Manager_Information();
        Manager_DataDataContext dataContext = new Manager_DataDataContext();
        public Manager_form(int currentID)
        {
            InitializeComponent();
            manager.ID1 = currentID;
            Manager temp = (from m in dataContext.Managers where m.Id == currentID select m).FirstOrDefault();
            Manager_Information.Transfer_Manager_Detail(temp, ref manager);
        }

        private void PI_button_Click(object sender, EventArgs e)
        {
           /* if (manager.First_name != null)
            {
                MessageBox.Show("Yeah sir");
            }*/
            manager.PrinfDetail();
        }

        private void Manager_form_Load(object sender, EventArgs e)
        {

        }

        private void MPS_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
