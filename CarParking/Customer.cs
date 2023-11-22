using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public class Customer : Person
    {
        private int CarID;
        private bool Paid;
        private string Paymethod;
        private string CustomerID;
        private bool CarRetrieve;
        public Customer(string name, string contactInfor, int carID, bool paid, string paymethod, string customerID, bool carRetrieve) : base(name, contactInfor)
        {
            CarID1 = carID;
            Paid1 = paid;
            Paymethod1 = paymethod;
            CustomerID1 = customerID;
            CarRetrieve1 = carRetrieve;
        }

        public int CarID1 { get => CarID; set => CarID = value; }
        public bool Paid1 { get => Paid; set => Paid = value; }
        public string Paymethod1 { get => Paymethod; set => Paymethod = value; }
        public string CustomerID1 { get => CustomerID; set => CustomerID = value; }
        public bool CarRetrieve1 { get => CarRetrieve; set => CarRetrieve = value; }

        public override void PrinfDetail()
        {

        }
    }
}