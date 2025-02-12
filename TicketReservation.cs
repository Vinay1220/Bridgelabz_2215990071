using System;

class TicketNode
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public DateTime BookingTime;
    public TicketNode Next;

    public TicketNode(int ticketID, string customerName, string movieName, int seatNumber, DateTime bookingTime)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
        Next = null;
    }
}

class TicketReservationSystem
{
    private TicketNode head = null;

    public void AddTicket(int ticketID, string customerName, string movieName, int seatNumber, DateTime bookingTime)
    {
        TicketNode newTicket = new TicketNode(ticketID, customerName, movieName, seatNumber, bookingTime);

        if (head == null)
        {
            head = newTicket;
            head.Next = head;
            return;
        }

        TicketNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newTicket;
        newTicket.Next = head;
    }

    public void RemoveTicket(int ticketID)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available to remove.");
            return;
        }

        TicketNode temp = head, prev = null;

        if (head.TicketID == ticketID)
        {
            if (head.Next == head)
            {
                head = null;
                return;
            }

            TicketNode last = head;
            while (last.Next != head)
                last = last.Next;

            head = head.Next;
            last.Next = head;
            return;
        }

        do
        {
            prev = temp;
            temp = temp.Next;
        } while (temp != head && temp.TicketID != ticketID);

        if (temp == head)
        {
            Console.WriteLine("Ticket ID not found!");
            return;
        }

        prev.Next = temp.Next;
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets to display.");
            return;
        }

        TicketNode temp = head;
        do
        {
            Console.WriteLine("Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName + 
                              ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber + 
                              ", Booking Time: " + temp.BookingTime);
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByCustomerOrMovie(string searchKey)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets found.");
            return;
        }

        TicketNode temp = head;
        bool found = false;
        do
        {
            if (temp.CustomerName.Equals(searchKey, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Equals(searchKey, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ticket Found -> Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName + 
                                  ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber + 
                                  ", Booking Time: " + temp.BookingTime);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No tickets found with the given search criteria.");
    }

    public void CountTotalTickets()
    {
        if (head == null)
        {
            Console.WriteLine("Total Tickets: 0");
            return;
        }

        TicketNode temp = head;
        int count = 0;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Total Tickets: " + count);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TicketReservationSystem system = new TicketReservationSystem();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nOnline Ticket Reservation Menu:");
            Console.WriteLine("1 - Book a New Ticket");
            Console.WriteLine("2 - Remove a Ticket");
            Console.WriteLine("3 - Display All Tickets");
            Console.WriteLine("4 - Search Ticket by Customer or Movie");
            Console.WriteLine("5 - Count Total Tickets");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 0:
                    running = false;
                    break;

                case 1:
                    Console.Write("Enter Ticket ID: ");
                    int ticketID = int.Parse(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Enter Movie Name: ");
                    string movieName = Console.ReadLine();
                    Console.Write("Enter Seat Number: ");
                    int seatNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter Booking Time (yyyy-MM-dd HH:mm): ");
                    DateTime bookingTime = DateTime.Parse(Console.ReadLine());

                    system.AddTicket(ticketID, customerName, movieName, seatNumber, bookingTime);
                    break;

                case 2:
                    Console.Write("Enter Ticket ID to Remove: ");
                    int removeID = int.Parse(Console.ReadLine());
                    system.RemoveTicket(removeID);
                    break;

                case 3:
                    system.DisplayTickets();
                    break;

                case 4:
                    Console.Write("Enter Customer Name or Movie Name: ");
                    string searchKey = Console.ReadLine();
                    system.SearchByCustomerOrMovie(searchKey);
                    break;

                case 5:
                    system.CountTotalTickets();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
