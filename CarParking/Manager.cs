using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarParking
{
    public class Manager_Information : Person
    {
        public Manager_Information()
        {
        }

        public Manager_Information(string name, string contactInfor) : base(name, contactInfor)
        {
        }

        public override string PrinfDetail()
        {
            string output = "Manager information\nName: " + Name + "\nContact infomation: " + ContactInfor;
            return output;
        }
    }
}