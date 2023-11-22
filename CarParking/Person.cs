using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public abstract class Person
    {
        private int ID;
        private string name;
        private string contactInfor;

        protected Person()
        {
        }

        protected Person(int iD, string name, string contactInfor)
        {
            ID1 = iD;
            this.name = name;
            this.contactInfor = contactInfor;
        }

        public string Name { get => name; set => name = value; }
        public string ContactInfor { get => contactInfor; set => contactInfor = value; }
        public int ID1 { get => ID; set => ID = value; }

        public abstract string PrinfDetail();
       
    }
}