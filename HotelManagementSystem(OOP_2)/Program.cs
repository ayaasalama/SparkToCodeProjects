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

            // Adding 6 Rooms

            rooms.Add(new Room("101", "Single", 25.0, true));
            rooms.Add(new Room("102", "Single", 25.0, true));
            rooms.Add(new Room("201", "Double", 40.0, true));
            rooms.Add(new Room("202", "Double", 40.0, true));
            rooms.Add(new Room("301", "Suite", 75.0, true));
            rooms.Add(new Room("302", "Suite", 80.0, true));

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
                    case 1: AddNewRoom(rooms); break;
                    case 2: RegisterNewGuest(guests); break;
                    case 3: BookRoomForGuest(guests, rooms); break;
                    case 4: ViewAllRooms(rooms); break;
                    case 5: ViewAllGuests(guests); break;
                    case 6: SearchFilterRooms(rooms); break;
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

        // Case 1 - Add New Room
        public static void AddNewRoom(List<Room> rooms)
        {
            Console.Write("Enter Room Number: ");
            string roomNumber = Console.ReadLine();

            if (rooms.Any(r => r.RoomNumber == roomNumber))
            {
                Console.WriteLine("Room already Exists.");
                return;
            }

            Console.Write("Enter Room Type (Single/ Double/ Suite)");
            string roomType = Console.ReadLine();

            Console.Write("Enter Price per Night:");
            double pricePerNight;

            try
            {
                pricePerNight = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Price must be a valid number!");
                return;
            }

            if (pricePerNight < 0)
            {
                Console.WriteLine("Price must be Positive.");
                return;
            }

            Room newRoom = new Room(roomNumber, roomType, pricePerNight, true);
            rooms.Add(newRoom);

            Console.WriteLine("\nRoom Added Successfully:");
            newRoom.DisplayRoom();
            Console.WriteLine("Total Rooms: " + rooms.Count);

        }

        // Case 2 - Register New Guest
        public static void RegisterNewGuest(List<Guest> guests)
        {
            Console.Write("Enter Guest Name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter Check-In Date: ");
            string checkInDate = Console.ReadLine();

            Console.Write("Enter Number of Nights: ");
            int numberOfNights;
            try
            {
                numberOfNights = int.Parse(Console.ReadLine());
            }
            catch (Exception) 
            {
                Console.WriteLine("Number of Nights must be Valid Number.");
                return;
            }
            if (numberOfNights <= 0 )
            {
                Console.WriteLine("Number of Nights must be Positive.");
            }

            string guestId = "G" + (guests.Count + 1).ToString("D3");

            Guest newGuest = new Guest(guestId, guestName, checkInDate, numberOfNights);
            guests.Add(newGuest);

            Console.WriteLine("\nGuest Registered Successfully:");
            newGuest.DisplayGuest();


        }

        // Case 3 - Book a Room For a Guest
        public static void BookRoomForGuest (List<Guest> guests, List<Room> rooms)
        {
            Console.Write("Enter the Guest Id: ");
            string guestId = Console.ReadLine();

            Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);
            
            if (guest == null)
            {
                Console.WriteLine("Guest Id not Available.");
                return;
            }

            Console.Write("Enter Room Number: ");
            string roomNumber = Console.ReadLine();

            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (room == null)
            {
                Console.WriteLine("Room Number not Available.");
                return;
            }

            if (!room.IsAvailable)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }

            guest.RoomNumber = room.RoomNumber;
            room.IsAvailable = false;

            Console.WriteLine("\nBooking Confirmed:");
            Console.WriteLine("Guest Name : " + guest.GuestName);
            Console.WriteLine("Room Number: " + room.RoomNumber);
            Console.WriteLine("Room Type  : " + room.RoomType);
            Console.WriteLine("Price/Night: " + room.PricePerNight.ToString("F2") + " OMR");
            Console.WriteLine("Total Nights: " + guest.TotalNights);
            Console.WriteLine("Total Cost : " + guest.CalculateTotalCost(room.PricePerNight).ToString("F2") + " OMR");

        }

        // Case 4 - View All Rooms
        public static void ViewAllRooms(List<Room> rooms)
        {
            if (rooms.Count == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            List<Room> AllRooms = rooms.OrderBy(r => r.RoomNumber).ToList();

            Console.WriteLine("Total Room Count: " + AllRooms.Count);

            foreach (Room room in AllRooms)
            {
                room.DisplayRoom();
                Console.WriteLine();
            }
        }

        // Case 5 - View All Guests
        public static void ViewAllGuests(List<Guest> guests)
        {
            if (guests.Count == 0)
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            List<Guest> AllGuests = guests.OrderBy(g => g.GuestName).ToList();

            Console.WriteLine("Total Guest Count: " + AllGuests.Count);

            foreach (Guest guest in AllGuests)
            {
                guest.DisplayGuest();
                Console.WriteLine();
            }
        }

        // Case 6 - Search & Filter Rooms
        public static void SearchFilterRooms (List<Room> rooms)
        {
            bool exitSubMenu = false;

            while (exitSubMenu == false)
            {
                Console.WriteLine("(1) Show all available rooms.");
                Console.WriteLine("(2) Filter by room type.");
                Console.WriteLine("(3) Filter by max price.");
                Console.WriteLine("(4) Room price statistic.");
                Console.WriteLine("(0) Back.");

                Console.Write("Enter your choice: ");
                
                int option;

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter Valid Number.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        {
                            List<Room> roomList = rooms.Where(r => r.IsAvailable)
                                                       .OrderBy(r => r.PricePerNight)
                                                       .ToList();

                            int count = roomList.Count;
                            if (count <= 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                                continue;
                            }

                            Console.WriteLine("The count of Available Rooms is: " + count);

                            foreach (Room room in roomList)
                            {
                                room.DisplayRoom();
                            }

                            break;
                        }

                    case 2:
                        {
                            Console.Write("Enter Room Type (Single/ Double/ Suite)");
                            string roomType = Console.ReadLine();

                            List<Room> roomList = rooms.Where(r => r.RoomType == roomType)
                                                       .ToList();

                            int count = roomList.Count;

                            if (count <= 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                                continue;
                            }

                            foreach (Room room in roomList)
                            {
                                room.DisplayRoom();
                            }

                            Console.WriteLine("The count of Available Rooms is: " + count);

                            break;
                        }

                    case 3:
                        {
                            Console.Write("Enter Max Price:");
                            double maxPrice;

                            try
                            {
                                maxPrice = double.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Price must be a valid number!");
                                continue;
                            }

                            if (maxPrice < 0)
                            {
                                Console.WriteLine("Price must be Positive.");
                                continue;
                            }

                            List<Room> roomList = rooms.Where(r => r.PricePerNight <= maxPrice)
                                                       .OrderBy(r => r.PricePerNight)
                                                       .ToList();

                            int count = roomList.Count;

                            if (count <= 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                                continue;
                            }

                            foreach (Room room in roomList)
                            {
                                room.DisplayRoom();
                            }

                            Console.WriteLine("The count of Available Rooms is: " + count);
                            break;
                        }

                    case 4:
                        {
                            int count = rooms.Count();
                            Console.WriteLine("The Total Number of Rooms: " + count);

                            int countAvailable = rooms.Count(r => r.IsAvailable == true);
                            Console.WriteLine("The Number of Available Rooms: " + countAvailable);

                            int countBooked = count - countAvailable;
                            Console.WriteLine("The Number of Booked Rooms: " + countBooked);

                            double avgPrice = rooms.Average(r => r.PricePerNight);
                            Console.WriteLine("The Average Price is: " +  avgPrice.ToString("F2"));

                            double cheapPrice = rooms.Min(r => r.PricePerNight);
                            Console.WriteLine("The Cheapest Price is: " +  cheapPrice.ToString("F2"));

                            double expPrice = rooms.Max(r => r.PricePerNight);
                            Console.WriteLine("The Most Expensive Price is: " +  expPrice.ToString("F2"));

                            break;
                        }

                    case 0:
                        {
                            exitSubMenu = true;
                            Console.WriteLine("Exiting..");
                            break;
                        }

                    default:
                        Console.WriteLine("Invalid option, please choose between 0 and 4.");
                        break;

                }

            }
        }


    }
}
