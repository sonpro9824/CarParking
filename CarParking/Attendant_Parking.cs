using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarParking
{
    public partial class Attendant_Parking : Form
    {
        Waiting_Ticket ticket = new Waiting_Ticket();
        Ticket_dbDataContext db = new Ticket_dbDataContext();
        public Attendant_Parking()
        {
            InitializeComponent();
        }

        private void Attendant_Parking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data121DataSet4.Waiting_Ticket' table. You can move, or remove it, as needed.
            this.waiting_TicketTableAdapter4.Fill(this.data121DataSet4.Waiting_Ticket);
            // TODO: This line of code loads data into the 'data121DataSet3.Waiting_Ticket' table. You can move, or remove it, as needed.
            this.waiting_TicketTableAdapter3.Fill(this.data121DataSet3.Waiting_Ticket);
            // TODO: This line of code loads data into the 'data121DataSet2.Waiting_Ticket' table. You can move, or remove it, as needed.
            this.waiting_TicketTableAdapter2.Fill(this.data121DataSet2.Waiting_Ticket);
            // TODO: This line of code loads data into the 'data121DataSet1.Waiting_Ticket' table. You can move, or remove it, as needed.
            this.waiting_TicketTableAdapter1.Fill(this.data121DataSet1.Waiting_Ticket);
            // TODO: This line of code loads data into the 'data121DataSet.Waiting_Ticket' table. You can move, or remove it, as needed.
            this.waiting_TicketTableAdapter.Fill(this.data121DataSet.Waiting_Ticket);
            var list = (from s in db.Waiting_Tickets where (bool)s.Is_Entry_Ticket == true select s).ToList();
            dataGridView1.DataSource = list;

        }

        private void button_check_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox_ticket_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.Waiting_Tickets where s.Ticket_ID.Contains(textBox_ticket.Text) select s).ToList();
            dataGridView1.DataSource = list;
            textBox_owner.DataBindings.Clear();
            textBox_car.DataBindings.Clear();
            textBox5_In.DataBindings.Clear();
            textBox_type.DataBindings.Clear();
            textBox_location.DataBindings.Clear();

            textBox_location.DataBindings.Add("text", list, "Location_ID");
            textBox_type.DataBindings.Add("text", list, "Ticket_type");
            textBox_owner.DataBindings.Add("text", list, "Owner_ID");
            textBox_car.DataBindings.Add("text", list, "Car_ID");
            textBox5_In.DataBindings.Add("text", list, "Time_In");

            
        }

        private void button_xuatVe_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(textBox_ticket.Text,textBox_owner.Text);
            ticket.Show();
        }
    }
}
