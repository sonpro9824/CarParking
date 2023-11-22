using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParking
{
    public partial class ParkingSpaceInformation
    {
        string ID = string.Empty;
        bool status = false;   
        float price = default;
        string ID_car_using = string.Empty;
        DateTime date_come = new DateTime();
        DateTime date_leave = new DateTime();
        float revenue = default;
       
        
        public ParkingSpaceInformation() { }

        public ParkingSpaceInformation(string iD, bool status, float price, string iD_car_using, DateTime date_come, DateTime date_leave, float revenue)
        {
            ID1 = iD;
            this.Status = status;
            this.Price = price;
            ID_car_using1 = iD_car_using;
            this.Date_come = date_come;
            this.Date_leave = date_leave;
            this.Revenue = revenue;
        }

        public string ID1 { get => ID; set => ID = value; }
        public bool Status { get => status; set => status = value; }
        public float Price { get => price; set => price = value; }
        public string ID_car_using1 { get => ID_car_using; set => ID_car_using = value; }
        public DateTime Date_come { get => date_come; set => date_come = value; }
        public DateTime Date_leave { get => date_leave; set => date_leave = value; }
        public float Revenue { get => revenue; set => revenue = value; }
    }
}