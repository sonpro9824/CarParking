using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public class Attendant_Information : Person, ParkCar, RetrieveCar
    {
        public static bool[] check_ID_Attandant = Enumerable.Repeat(true, 1000).ToArray();
        private DateTime Date_Hired = new DateTime();
        private int Salary_base = default;

        public DateTime Date_Hired1 { get => Date_Hired; set => Date_Hired = value; }
        public int Salary_base1 { get => Salary_base; set => Salary_base = value; }

        public Attendant_Information()
        {
        }

        public Attendant_Information(int iD, string first_name, string last_name, string sex,
            string email, string phone_number, string address, DateTime doB, DateTime date_Hired, int salary_base) : base(iD, first_name, last_name, sex, email, phone_number, address, doB)
        {
            Date_Hired1 = date_Hired;
            Salary_base1 = salary_base;
        }
        /// <summary>
        /// Chuyen du lieu attendant tu database sang class
        /// </summary>
        /// <param name="attendant_Information"></param>
        /// <param name="attendant"></param>
        public static void Transfer_Attendant_Information(ref Attendant_Information attendant_Information, Attendant attendant)
        {
            attendant_Information.ID1 = attendant.Id;
            ////////////////////////////////////////////////////
            if (attendant.First_Name != null)
                attendant_Information.First_name = attendant.First_Name;
            ////////////////////////////////////////////////////
            if (attendant.Last_Name != null)
                attendant_Information.Last_name = attendant.Last_Name;
            ///////////////////////////////////////////////////
            if (attendant.Sex != null)
                attendant_Information.Sex = attendant.Sex;
            ////////////////////////////////////////////////////
            if (attendant.Date_of_Birth != null)
                attendant_Information.DoB1 = (DateTime)attendant.Date_of_Birth;
            ////////////////////////////////////////////////////
            if (attendant.Phone_Number != null)
                attendant_Information.Phone_number = attendant.Phone_Number;
            ////////////////////////////////////////////////////
            if (attendant.Email != null)
                attendant_Information.Email = attendant.Email;
            ////////////////////////////////////////////////////
            if (attendant.Address != null)
                attendant_Information.Address = attendant.Address;
            if (attendant.Date_Hired != null)
                attendant_Information.Date_Hired1 = (DateTime)attendant.Date_Hired;
            ////////////////////////////////////////////////////
            if (attendant.Salary_base != null)
                attendant_Information.Salary_base1 = (int)attendant.Salary_base;
            ////////////////////////////////////////////////////

        }
        /// <summary>
        /// Chuyen Attendant tu class sang database
        /// </summary>
        /// <param name="attendant"></param>
        /// <param name="attendant_Information"></param>
        public static void Transfer_Attendant_Information(ref Attendant attendant,  Attendant_Information attendant_Information)
        {
            attendant.Id = attendant_Information.ID1;
            ////////////////////////////////////////////////////
            if (attendant_Information.First_name != null)
                attendant.First_Name = attendant_Information.First_name;
            ////////////////////////////////////////////////////
            if (attendant_Information.Last_name != null)
                attendant.Last_Name = attendant_Information.Last_name;
            ///////////////////////////////////////////////////
            if (attendant_Information.Sex != null)
                attendant.Sex = attendant_Information.Sex;
            ////////////////////////////////////////////////////
            if (attendant_Information.DoB1 != null)
                attendant.Date_of_Birth = (DateTime)attendant_Information.DoB1;
            ////////////////////////////////////////////////////
            if (attendant_Information.Phone_number != null)
                attendant.Phone_Number = attendant_Information.Phone_number;
            ////////////////////////////////////////////////////
            if (attendant_Information.Email != null)
                attendant.Email = attendant_Information.Email;
            ////////////////////////////////////////////////////
            if (attendant_Information.Address != null)
                attendant.Address = attendant_Information.Address;
            if (attendant_Information.Date_Hired1 != null)
                attendant.Date_Hired = (DateTime)attendant_Information.Date_Hired1;
            ////////////////////////////////////////////////////
            if (attendant_Information.Salary_base1 != null)
                attendant.Salary_base = (int)attendant_Information.Salary_base1;
            ////////////////////////////////////////////////////

        }
        public override void PrinfDetail()
        {
            Edit_Personal_In4_Attendant edit_Personal = new Edit_Personal_In4_Attendant(this);
            edit_Personal.Show();
        }
        public void ParkCar()
        {
            throw new Exception();
        }
        public void RetrieveCar()
        {
            throw new Exception();
        }
    }
}