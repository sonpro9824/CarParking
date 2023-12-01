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
        List<Ticket_detail> list_ticket = new List<Ticket_detail>();  
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
            Edit_Personal_In4_Customer edit_Personal = new Edit_Personal_In4_Customer(this);
            edit_Personal.Show();
        }
        public static void Transfer_Customer_Detail(Customer db_customer, ref Customer_Information customer_Information)
        {

            customer_Information.ID1 = db_customer.Id;
            if (db_customer.First_Name != null)
                customer_Information.First_name = db_customer.First_Name;
            if (db_customer.Last_Name != null)
                customer_Information.Last_name = db_customer.Last_Name;
            if (db_customer.Sex != null)
                customer_Information.Sex = db_customer.Sex;
            if (db_customer.Date_of_birth != null)
                customer_Information.DoB1 = (DateTime)db_customer.Date_of_birth;
            if (db_customer.Phone_number != null)
                customer_Information.Phone_number = db_customer.Phone_number;
            if (db_customer.Email != null)
                customer_Information.Email = db_customer.Email;
            if (db_customer.Address != null)
                customer_Information.Address = db_customer.Address;
        }

        public static void Transfer_Customer_Detail(Customer_Information customer_Information, ref Customer db_customer)
        {

            db_customer.Id = customer_Information.ID1;
            if (customer_Information.First_name != null)
                db_customer.First_Name = customer_Information.First_name;
            if (customer_Information.Last_name != null)
                db_customer.Last_Name = customer_Information.Last_name;
            if (customer_Information.Sex != null)
                db_customer.Sex = customer_Information.Sex;
            if (customer_Information.DoB1 != null)
                db_customer.Date_of_birth = customer_Information.DoB1;
            if (customer_Information.Email != null)
                db_customer.Email = customer_Information.Email;
            if (customer_Information.Phone_number != null)
                db_customer.Phone_number = customer_Information.Phone_number;
            if (customer_Information.Address != null)
                db_customer.Address = customer_Information.Address;
        }
    }
}