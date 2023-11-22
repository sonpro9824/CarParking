using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public abstract class Person
    {
        private string name;
        private string contactInfor;
        public Person()
        {

        }
        protected Person(string name, string contactInfor)
        {
            this.Name = name;
            this.ContactInfor = contactInfor;
        }

        public string Name { get => name; set => name = value; }
        public string ContactInfor { get => contactInfor; set => contactInfor = value; }

        public abstract string PrinfDetail();
       
    }
}