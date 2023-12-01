using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    public class Ticket_detail
    {
        string Ticket_ID = string.Empty;
        string customer_ID = string.Empty;  
        string Car_ID = string.Empty;
        string Ticket_type = string.Empty;
        int Ticket_price = default;
        string Location_ID = string.Empty;
        bool is_Entry_Ticket = true;
        DateTime time_In = new DateTime();
        DateTime time_Out = new DateTime();
        public Ticket_detail()
        {
        }

        public Ticket_detail(string customer_ID, string car_ID, string ticket_type, int ticket_price, string location_ID, bool is_Entry_Ticket = false, string ticket_ID = null, DateTime time_In = default, DateTime time_Out = default)
        {
            this.Customer_ID = customer_ID;
            Car_ID1 = car_ID;
            Ticket_type1 = ticket_type;
            Ticket_price = ticket_price;
            Location_ID1 = location_ID;
            this.is_Entry_Ticket = is_Entry_Ticket;
            Ticket_ID = ticket_ID;
            this.time_In = time_In;
            this.time_Out = time_Out;
        }

        public string Customer_ID { get => customer_ID; set => customer_ID = value; }
        public string Car_ID1 { get => Car_ID; set => Car_ID = value; }
        /// <summary>
        /// 2 loai: Theo tieng va theo ngay
        /// </summary>
        public string Ticket_type1 { get => Ticket_type; set => Ticket_type = value; }
        public int Ticket_price1 { get => Ticket_price; set => Ticket_price = value; }
        public string Location_ID1 { get => Location_ID; set => Location_ID = value; }
        /// <summary>
        /// Xac dinh la ve ra hay ve vao
        /// </summary>
        public bool Is_Entry_Ticket { get => is_Entry_Ticket; set => is_Entry_Ticket = value; }
        public string Ticket_ID1 { get => Ticket_ID; set => Ticket_ID = value; }
        public DateTime Time_In { get => time_In; set => time_In = value; }
        public DateTime Time_Out { get => time_Out; set => time_Out = value; }

        public void Create_new_ticket(ref Ticket_detail ticket, Customer_Information customer)
        {
           /* ticket.Ticket_ID1 = new Random().Next(1,1000).ToString();
            ticket.customer_ID = customer.Customer_ID1;
            ticket.Car_ID = customer.Car_ID;
*/
        }
        /// <summary>
        /// Chuyen tu db_ticket sang class_ticket
        /// </summary>
        /// <param name="ticket_Detail"></param>
        /// <param name="waiting_Ticket"></param>
        public static void Transfer_ticket_detail(ref Ticket_detail ticket_Detail, Waiting_Ticket waiting_Ticket)
        {
            if (waiting_Ticket.Ticket_ID!=null)
            {
                ticket_Detail.Ticket_ID1 = waiting_Ticket.Ticket_ID;
            }

            if (waiting_Ticket.Car_ID != null)
            {
                ticket_Detail.Car_ID1 = waiting_Ticket.Car_ID;
            }

            if (waiting_Ticket.Owner_ID != null)
            {
                ticket_Detail.Customer_ID = waiting_Ticket.Owner_ID;
            }

            if (waiting_Ticket.Location_ID != null)
            {
                ticket_Detail.Location_ID1 = waiting_Ticket.Location_ID;
            }

            if (waiting_Ticket.Ticket_type != null)
            {
                ticket_Detail.Ticket_type = waiting_Ticket.Ticket_type;
            }

            if (waiting_Ticket.Ticket_ID != null)
            {
                ticket_Detail.Ticket_ID1 = waiting_Ticket.Ticket_ID;
            }

            if (waiting_Ticket.Is_Entry_Ticket != null)
            {
                ticket_Detail.Is_Entry_Ticket = (bool)waiting_Ticket.Is_Entry_Ticket;
            }

            if (waiting_Ticket.time_in!=null)
            {
                ticket_Detail.time_In = (DateTime)waiting_Ticket.time_in;
            }
        }
    }
    
}
