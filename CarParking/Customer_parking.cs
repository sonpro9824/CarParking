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
    public partial class Customer_parking : Form
    {
        Customer_Information customer_class = new Customer_Information();
        public Customer_parking(Customer_Information customer_Information)
        {
            InitializeComponent();
            customer_class = customer_Information;
        }

        private void Display_current_ticket_button_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            var ticket_Detail = customer_class.Ticket_Details;

        }

        private void Park_car_button_Click(object sender, EventArgs e)
        {
            Ticket_detail ticket = new Ticket_detail();
            Create_new_ticket create_New_ticket = new Create_new_ticket(ref ticket, customer_class);
            create_New_ticket.ShowDialog();
            
        }

        private void Customer_parking_Load(object sender, EventArgs e)
        {

        }
    }
}
