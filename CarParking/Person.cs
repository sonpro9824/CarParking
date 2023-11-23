using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public abstract class Person
    {
        private int ID;
        private string first_name = null;
        private string last_name = null;
        private string sex = null;
        private string email = null;
        private string phone_number = null;
        private string address = null;
        DateTime DoB = default;
        protected Person()
        {
        }

        protected Person(int iD, string first_name, string last_name, string sex, string email, string phone_number, string address, DateTime doB)
        {
            ID = iD;
            this.first_name = first_name;
            this.last_name = last_name;
            this.sex = sex;
            this.email = email;
            this.phone_number = phone_number;
            this.address = address;
            DoB = doB;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }

        public string Sex { get => sex; set => sex = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DoB1 { get => DoB; set => DoB = value; }

        public abstract void PrinfDetail();
       
    }
}