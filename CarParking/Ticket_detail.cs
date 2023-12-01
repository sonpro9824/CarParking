using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    internal class Ticket_detail
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

        public Ticket_detail(string customer_ID, string car_ID, string ticket_type, int ticket_price, string location_ID, bool is_Entry_Ticket = false, string ticket_ID = null)
        {
            this.Customer_ID = customer_ID;
            Car_ID1 = car_ID;
            Ticket_type1 = ticket_type;
            Ticket_price = ticket_price;
            Location_ID1 = location_ID;
            this.is_Entry_Ticket = is_Entry_Ticket;
            Ticket_ID = ticket_ID;
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
    }
}