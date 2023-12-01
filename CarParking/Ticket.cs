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
    public partial class Ticket : Form
    {
        Waiting_Ticket ticket = new Waiting_Ticket();
        Ticket_dbDataContext db_ticket = new Ticket_dbDataContext();
        Customer customer = new Customer();
        Customer_DataDataContext db_customer = new Customer_DataDataContext();
        public Ticket()
        {
            InitializeComponent();
        }
        public Ticket(string ticket1,string owner)
        {
            InitializeComponent();
            try
            {
                label_ticket.Text = ticket1;
                label_owner.Text = owner;
                customer = (from s in db_customer.Customers where s.Id == Convert.ToInt32(owner) select s).FirstOrDefault();
                ticket = (from s in db_ticket.Waiting_Tickets where s.Ticket_ID == ticket1 select s).FirstOrDefault();
                label_location.Text = ticket.Location_ID;
                label_in.Text = ticket.Time_In.ToString();
                label_name.Text = customer.Last_Name + " " + customer.First_Name.ToString();
                label_price.Text = ticket.Price.ToString();
                label_type.Text = ticket.Ticket_type;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr");
            }
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
