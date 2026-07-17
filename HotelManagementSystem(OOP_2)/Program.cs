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
            // Lists of Objects
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("================================================");
                Console.Write("Enter your Choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 0 to 15.");
                    continue;
                }

                switch (choice)
                {
                    case 1: AddNewRoom(); break;
                    case 2: RegisterNewGuest(); break;
                    case 3: BookRoomForGuest(); break;
                    case 4: ViewAllRooms(); break;
                    case 5: ViewAllGuests(); break;
                    case 6: SearchFilterRooms(); break;
                    case 7: GuestBookingStatistics(); break;
                    case 8: UpdateRoomPrice(); break;
                    case 9: GuestLookupByName(); break;
                    case 10: RoomTypeBreakdownReport(); break;
                    case 11: CheckOutGuest(); break;
                    case 12: RemoveUnavailableRooms(); break;
                    case 13: ExtemdGuestStay(); break;
                    case 14: HighestRevenueBooking(); break;
                    case 15: GuestPaginationViewer(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 0 and 15.");
                        break;
                }

                Console.WriteLine("Press any Key.");
                Console.ReadKey();
                Console.Clear();
            }

        }

        public static void AddNewRoom ()
        {

        }

    }


}
