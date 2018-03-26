using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalHotelBillApp
{
    class Main
    {
        static void Main(string[] args)
        {
            TotalHotelBill aTotalHotalBill = new TotalHotelBill();

            Console.Write("Enter name:\t\t");
            aTotalHotalBill.GuestName = Console.ReadLine();
            Console.Write("Number of nights:\t");
            aTotalHotalBill.NumberOfNights = int.Parse(Console.ReadLine());
            Console.Write("Enter Room rate:\t");
            aTotalHotalBill.RoomRate = double.Parse(Console.ReadLine());
            Console.Write("Enter other charges:\t");
            aTotalHotalBill.OtherCharges = double.Parse(Console.ReadLine());

            Console.WriteLine("\n**************************************************\n" +
                              aTotalHotalBill.ToString() +
                              "\n**************************************************");
            Console.Read();
        }
    }
}
