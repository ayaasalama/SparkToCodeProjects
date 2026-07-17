namespace HotelManagementSystem_OOP_2_
{
    // Classes
    public class Room
    {
        // Attributes
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor
        public Room(string roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }

        // Method
        public void DisplayRoom()
        {
            string status;

            if (IsAvailable)
            {
                status = "Available";
            }
            else
            {
                status = "Booked";
            }

            Console.WriteLine("Room Number : " + RoomNumber);
            Console.WriteLine("Room Type   : " + RoomType);
            Console.WriteLine("Price/Night : " + PricePerNight.ToString("F2") + " OMR");
            Console.WriteLine("Availability: " + status);
        }

    }

    public class Guest
    {
        
        public string GuestId { get; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        // Constructor
        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = "Not Assigned";
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        // Method
        public void DisplayGuest()
        {
            Console.WriteLine("Guest ID     : " + GuestId);
            Console.WriteLine("Guest Name   : " + GuestName);
            Console.WriteLine("Room Number  : " + RoomNumber);
            Console.WriteLine("Check-In Date: " + CheckInDate);
            Console.WriteLine("Total Nights : " + TotalNights);
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return pricePerNight * TotalNights;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
