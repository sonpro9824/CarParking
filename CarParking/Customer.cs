using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public class Customer_Information : Person, ParkCar, RetrieveCar, HandlePayment
    {
        string car_ID = string.Empty;
        DateTime date_come = new DateTime();
        DateTime date_leave = new DateTime();
        string payment_method = string.Empty;
        public static bool[] check_ID_Customer = Enumerable.Repeat(true, 1000).ToArray();
        public Customer_Information()
        {
        }

        public Customer_Information(int iD, string first_name, string last_name, string sex, string email,
            string phone_number, string address, DateTime doB) : base(iD, first_name, last_name, sex, email, phone_number, address, doB)
        {
        }

        public string Car_ID { get => car_ID; set => car_ID = value; }
        public DateTime Date_come { get => date_come; set => date_come = value; }
        public DateTime Date_leave { get => date_leave; set => date_leave = value; }
        public string Payment_method { get => payment_method; set => payment_method = value; }

        public override void PrinfDetail()
        {
            throw new NotImplementedException();
        }
    }
}