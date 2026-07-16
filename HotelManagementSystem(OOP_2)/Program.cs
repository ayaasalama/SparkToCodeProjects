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

    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
