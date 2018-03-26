using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalHotelBillApp
{
    class TotalHotelBill
    {
        private string guestName;
        private double roomRate;
        private double otherCharges;
        private double totalBill;
        private int numberOfNights;

        //Default constructor
        public TotalHotelBill(){}

        public TotalHotelBill(string aName, double aRoomRate, int aNight, double aOther)
        {
            guestName = aName;
            roomRate = aRoomRate;
            numberOfNights = aNight;
            otherCharges = aOther;
        }

        //Get guestName value from the user and set it to variable
        public String GuestName
        {
            set { guestName = value; }
        }

        //Get the number of nights from the user and set it to variable
        public int NumberOfNights
        {
            set { numberOfNights = value; }
        }

        //Get room rate from the user and set it to variable
        public double RoomRate
        {
            set { roomRate = value; }
        }

        //Get other charges from user and set it to variable
        public double OtherCharges
        {
            set { otherCharges = value; }
        }

        //Set totalBill and return it to user
        public double TotalBill
        {
            get
            {
                //totalBill = CalculateTotalBill();
                totalBill = (numberOfNights * roomRate) + otherCharges;
                return totalBill;
            }
        }

        public override string ToString()
        {
            return "Guest Name:\t\t" + guestName + "\n" +
                   "Number of Nights:\t" + numberOfNights + "\n" +
                   "Room Rate:\t\t" + roomRate.ToString("c") + "\n" +
                   "Other Charges:\t\t" + otherCharges.ToString("c") + "\n\n" +
                   "Total Bill\t\t***" + TotalBill.ToString("c") + "***\n" +
                   "\t\tThank You!";
        }

    }
}
