using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarParking
{
    public class Manager : Person
    {
        private bool[] ParkingSpace = new bool[100];
        private decimal pricing = default;
        private Person[] Staff = new Person[100];
        public Manager()
        {
        }
        public Manager(string name, string contactInfor, bool[] ParkingSpace, decimal Pricing, Person[] people) : base(name, contactInfor)
        {
            this.ParkingSpace1 = ParkingSpace;
            this.Pricing = Pricing;
            this.Staff1 = people;
        }

        public bool[] ParkingSpace1 { get => ParkingSpace; set => ParkingSpace = value; }
        public decimal Pricing { get => pricing; set => pricing = value; }
        public Person[] Staff1 { get => Staff; set => Staff = value; }

        public override void PrinfDetail()
        {
            
        }
    }
}