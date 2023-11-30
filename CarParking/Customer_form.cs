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
    public partial class Customer_form : Form
    {
        Customer customer;
        Customer_DataDataContext dataContext;
        Customer_Information customerInformation = new Customer_Information();
        public Customer_form(int id)
        {
            InitializeComponent();
            dataContext = new Customer_DataDataContext();
            customer = (from s in dataContext.Customers where s.Id == id select s).FirstOrDefault();
            Customer_Information.Transfer_Customer_Detail(customer, ref customerInformation);
        }

        private void PI_button_Click(object sender, EventArgs e)
        {
            customerInformation.PrinfDetail();
        }

        private void Customer_form_Load(object sender, EventArgs e)
        {

        }
    }
}
