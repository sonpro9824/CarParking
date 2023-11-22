using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public class Customer_Information : Person
    {
        string car_ID = string.Empty;
        DateTime date_come = new DateTime();
        DateTime date_leave = new DateTime();
        string payment_method = string.Empty;

        public Customer_Information()
        {
        }

        public Customer_Information(int ID, string name, string contactInfor,string car_ID, DateTime date_come, DateTime date_leave, string payment_method) : base(ID ,name, contactInfor)
        {
            this.Car_ID = car_ID;
            this.Date_come = date_come;
            this.Date_leave = date_leave;
            this.Payment_method = payment_method;
        }
        public string Car_ID { get => car_ID; set => car_ID = value; }
        public DateTime Date_come { get => date_come; set => date_come = value; }
        public DateTime Date_leave { get => date_leave; set => date_leave = value; }
        public string Payment_method { get => payment_method; set => payment_method = value; }

        public override string PrinfDetail()
        {
            string output = "Customer information\nName: " + Name + "\nContact infomation: " + ContactInfor;
            return output;
        }
    }
}