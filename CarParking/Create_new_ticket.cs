using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParking
{
    public partial class Create_new_ticket : Form
    {
        Ticket_detail ticket_Detail = new Ticket_detail();
        Customer_Information customer_Information = new Customer_Information();

        Parking_Car_DetailDataContext parking_db = new Parking_Car_DetailDataContext();
        public Create_new_ticket(ref Ticket_detail ticket, Customer_Information customer)
        {
            InitializeComponent();
            ticket_Detail = ticket;
            customer_Information = customer;
            Update_Status(true);
        }
        private void Update_price_label()
        {
            if (Available_location_combobox.SelectedItem != null && Type_of_ticket_combobox.SelectedItem != null) 
            {
                var temp = (from s in parking_db.ParkingSpaces
                            where s.ID == Available_location_combobox.SelectedItem.ToString()
                            select s).FirstOrDefault();
                if (Type_of_ticket_combobox.SelectedItem.ToString() == "Daily")
                {
                    //MessageBox.Show("0.8");
                    Ticket_price_value_label.Text = (temp.Price*0.8).ToString();
                }
                else
                {
                    //MessageBox.Show("1.2");
                    Ticket_price_value_label.Text = (temp.Price * 1.2).ToString();
                }
            }
        }
        private void Create_new_ticket_Load(object sender, EventArgs e)
        {
            ID_ticket_value_label.Text = new Random().Next(1,1000).ToString();
            ticket_Detail.Ticket_ID1 = ID_ticket_value_label.Text;

            Cus_ID_value_label.Text = customer_Information.Customer_ID1;

            
            Parking_Car_DetailDataContext dataloginDataContext = new Parking_Car_DetailDataContext();
            var avb_space = (from s in dataloginDataContext.ParkingSpaces where (bool)s.Status == true select s).ToList();
            foreach (var item in avb_space)
            {
                Available_location_combobox.Items.Add(item.ID);
            }
            Time_in_value_label.Text = DateTime.Now.ToShortDateString();
            
        }

        private void Type_of_ticket_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Available_location_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void Type_of_ticket_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void Available_location_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void Available_location_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_price_label();
        }

        private void Type_of_ticket_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_price_label();
        }
        private void Update_Status(bool check)
        {
            if (check)
            {
                edit_value_panel.Visible = true;
                value_panel.Visible = false;
                Back_button.Visible = true;
                Edit_button.Visible = false;
                Save_button.Visible = true;
            }
            else
            {
                edit_value_panel.Visible = false;
                value_panel.Visible = true;
                Back_button.Visible = false;
                Edit_button.Visible = true;
                Save_button.Visible = false;
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Update_Status(false);
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Update_Status(true);
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Available_location_combobox.SelectedItem != null && Type_of_ticket_combobox.SelectedItem!=null
                && Car_ID_edit_textbox.Text!=string.Empty)
            {
                CarID_value_label.Text = Car_ID_edit_textbox.Text;
                Type_of_ticket_value_label.Text = Type_of_ticket_combobox.SelectedItem.ToString();
                Available_location_value_label.Text = Available_location_combobox.SelectedItem.ToString();

                ticket_Detail.Time_In = DateTime.Now;
                ticket_Detail.Ticket_price1 = Convert.ToInt32(Ticket_price_value_label.Text);
                ticket_Detail.Location_ID1 = Available_location_label.Text;
                ticket_Detail.Is_Entry_Ticket = true;
                ticket_Detail.Customer_ID = Cus_ID_value_label.Text;
                ticket_Detail.Ticket_type1 = Type_of_ticket_value_label.Text;

                Waiting_Ticket waiting_Ticket = new Waiting_Ticket();

            }
        }
    }
}
