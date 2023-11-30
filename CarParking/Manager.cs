using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarParking
{

    public class Manager_Information : Person, ManageParkingSpace
    {
        public static bool[] check_ID_Manager = Enumerable.Repeat(true, 1000).ToArray();
        public Manager_Information()
        {
        }

        public Manager_Information(int iD, string first_name, string last_name, string sex,
            string email, string phone_number, string address, DateTime dob) : base(iD, first_name, last_name, sex, email, phone_number, address, dob)
        {
        }

        public override void PrinfDetail()
        {
            Edit_Personal_In4_Manager edit_Personal_In4 = new Edit_Personal_In4_Manager(this);
            edit_Personal_In4.Show();
        }
        /// <summary>
        /// Chuyen tu db_manager sang manager_informantion
        /// </summary>
        /// <param name="db_manager"></param>
        /// <param name="manager_Information"></param>
        public static void Transfer_Manager_Detail(Manager db_manager, ref Manager_Information manager_Information)
        {

            manager_Information.ID1 = db_manager.Id;
            if (db_manager.First_Name != null)
                manager_Information.First_name = db_manager.First_Name;
            if (db_manager.Last_Name != null)
                manager_Information.Last_name = db_manager.Last_Name;
            if (db_manager.Sex != null)
                manager_Information.Sex = db_manager.Sex;
            if (db_manager.Date_of_Birth != null)
                manager_Information.DoB1 = (DateTime)db_manager.Date_of_Birth;
            if (db_manager.Phone_Number != null)
                manager_Information.Phone_number = db_manager.Phone_Number;
            if (db_manager.Email != null)
                manager_Information.Email = db_manager.Email;
            if (db_manager.Address != null)
                manager_Information.Address = db_manager.Address;
        }
        /// <summary>
        /// Chuyen tu manager_information sang db_manager
        /// </summary>
        /// <param name="manager_Information"></param>
        /// <param name="db_manager"></param>
        public static void Transfer_Manager_Detail(Manager_Information manager_Information, ref Manager db_manager)
        {

            db_manager.Id = manager_Information.ID1;
            if (manager_Information.First_name != null)
                db_manager.First_Name = manager_Information.First_name;
            if (manager_Information.Last_name != null)
                db_manager.Last_Name = manager_Information.Last_name;
            if (manager_Information.Sex != null)
                db_manager.Sex = manager_Information.Sex;
            if (manager_Information.DoB1 != null)
                db_manager.Date_of_Birth = manager_Information.DoB1;
            if (manager_Information.Email != null)
                db_manager.Email = manager_Information.Email;
            if (manager_Information.Phone_number != null)
                db_manager.Phone_Number = manager_Information.Phone_number;
            if (manager_Information.Address != null)
                db_manager.Address = manager_Information.Address;
        }
  
    }
}