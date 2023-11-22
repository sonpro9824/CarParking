using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public class Attendant_Information : Person
    {
        public Attendant_Information(int ID, string name, string contactInfor) : base(ID, name, contactInfor)
        {

        }

        public override string PrinfDetail()
        {
            string output = "Attendant information\nName: " + Name + "\nContact infomation: " + ContactInfor;
            return output;
        }
    }
}