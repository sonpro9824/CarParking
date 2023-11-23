using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public class Attendant_Information : Person
    {
        bool[] check_ID_Attandant = Enumerable.Repeat(true, 1000).ToArray();   
        public Attendant_Information()
        {
        }

        public Attendant_Information(int iD, string first_name, string last_name, string sex, 
            string email, string phone_number, string address, DateTime doB) : base(iD, first_name, last_name, sex, email, phone_number, address, doB)
        {
        }

        public override void PrinfDetail()
        {
            throw new NotImplementedException();
        }
    }
}