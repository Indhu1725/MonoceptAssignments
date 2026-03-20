using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace BanquetExample
{
    // Base Class
    class Banquet
    {
        public int BanquetId;
        public string BanquetName;
        public int Capacity;
        
        // Parameterized Constructor
        public Banquet(int id, string name, int capacity)
        {
            BanquetId = id;
            BanquetName = name;
            Capacity = capacity;
        }
        // Method to return basic earning
        public virtual int CalculateEarning()
        {
            return 2000;
        }
        public virtual void Display()
        {
            Console.WriteLine("Banquet ID: " + BanquetId);
            Console.WriteLine("Banquet Name: " + BanquetName);
            Console.WriteLine("Capacity: " + Capacity);
        }
    }
    class Exhibition : Banquet
    {
        int TotalStalls;
        int StallRent;
        public Exhibition(int id, string name, int capacity,int totalStalls,int stallRent) :base(id,name, capacity)
        { 
            TotalStalls = totalStalls;
            StallRent = stallRent;
        }
        public override int CalculateEarning()
        {
            return base.CalculateEarning() + (TotalStalls * StallRent);
        }
        public void DisplayExhibition()
        {
            base.Display();
            Console.WriteLine("Total Stalls: " + TotalStalls);
            Console.WriteLine("Stall Rent:" + StallRent);
            Console.WriteLine("Total Earnings:" + CalculateEarning());
        }
    }
    // Child Class
    class Event : Banquet
    {
        int TotalPax;

        // Parameterized Constructor
        public Event(int id, string name, int capacity, int totalPax)
            : base(id, name, capacity)
        {
            if (totalPax <= capacity)
            {
                TotalPax = totalPax;
            }
            else
            {
                Console.WriteLine("TotalPax cannot exceed Capacity. Setting TotalPax = Capacity.");
                TotalPax = capacity;
            }
        }

        public void DisplayEvent()
        {
            base.Display();
            Console.WriteLine("Total Pax:" + TotalPax);
        }
        // Overriding CalculateEarning method
        public override int CalculateEarning()
        {
            int basicEarning = base.CalculateEarning();
            return TotalPax * basicEarning;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Event e = new Event(1, "Wedding", 200, 150);
            Exhibition exhibition = new Exhibition(2, "Tech Expo", 500, 200, 100);

            int totalEarning = e.CalculateEarning();
            int totalEarningExhibition = exhibition.CalculateEarning();

            Console.WriteLine("Total Earnings: " + totalEarning);

            Console.WriteLine("Event Details");
            e.DisplayEvent();

            Console.WriteLine("\nExhibition Details");
            exhibition.DisplayExhibition();

            Console.WriteLine("\nGenerating Array of Banquets");
            Banquet[] banquets = new Banquet[3];
            GenerateBanquets(banquets);

            Console.WriteLine("\nPrinting Event and Exhibition Array");
            Banquet[] eventexhibition = new Banquet[2];
            GenerateEventExhibition(eventexhibition);

            Banquet[] banquets1 = new Banquet[4];
            GenerateDynamic(banquets1);
        }
        static void GenerateBanquets(Banquet[] banquets)
        {
            for (int i = 0; i < banquets.Length; i++)
            {
                Console.WriteLine("Enter Details for Banquet " + (i + 1));
                Console.Write("Enter Banquet Id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Banquet Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Capacity: ");
                int capacity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Total Pax: ");
                int pax = Convert.ToInt32(Console.ReadLine());

                banquets[i] = new Event(id, name, capacity, pax);
            }

            Console.WriteLine("\nBanquet Details and Earnings");

            foreach (Banquet b in banquets)
            {
                b.Display();
                Console.WriteLine("Total Earnings: " + b.CalculateEarning());
                Console.WriteLine();
            }
        }
        static void GenerateEventExhibition(Banquet[] eventexhibition)
        {
            eventexhibition[0] = new Event(3, "Conference", 300, 250);
            eventexhibition[1] = new Exhibition(4, "Art Expo", 400, 150, 80);
            Console.WriteLine("\nEvent and Exhibition Details ");
            foreach (Banquet b in eventexhibition)
            {
                b.Display();
                Console.WriteLine("Total Earnings: " + b.CalculateEarning());
                Console.WriteLine();
            }
        }
        static void GenerateDynamic(Banquet[] banquets1)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("1.Event");
                Console.WriteLine("2.Exhibition");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Banquet Id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Banquet Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Capacity: ");
                int capacity = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Total Pax: ");
                    int pax = Convert.ToInt32(Console.ReadLine());
                    banquets1[i] = new Event(id, name, capacity, pax);
                }
                else
                {
                    Console.Write("Enter Total Stalls: ");
                    int stalls = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Stall Rent: ");
                    int rent = Convert.ToInt32(Console.ReadLine());

                    banquets1[i] = new Exhibition(id, name, capacity, stalls, rent);
                }
            }

            foreach (Banquet b in banquets1)
            {
                b.Display();
                Console.WriteLine("Total Earnings: " + b.CalculateEarning());
                Console.WriteLine();
            }

        }
    }
}