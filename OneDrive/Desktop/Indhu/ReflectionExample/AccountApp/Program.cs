using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace AccountApp
{
    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\AccountApp\accounts.json";

            // ✅ Create folder if it doesn't exist
            Directory.CreateDirectory(@"D:\AccountApp");

            List<Account> list = new List<Account>();

            list.Add(new Account { Id = 1, Name = "Janaki", Balance = 5000 });
            list.Add(new Account { Id = 2, Name = "Rama", Balance = 15000 });
            list.Add(new Account { Id = 3, Name = "Zade", Balance = 25000 });
            list.Add(new Account { Id = 4, Name = "Aaron", Balance = 10000 });

            // Serialization
            string data = JsonSerializer.Serialize(list);
            File.WriteAllText(file, data);
            Console.WriteLine("Accounts saved to file");

            Console.WriteLine("");

            // Deserialize
            string read = File.ReadAllText(file);
            List<Account> newList = JsonSerializer.Deserialize<List<Account>>(read);

            Console.WriteLine("Reading data from file");
            Console.WriteLine("");

            foreach (Account acc in newList)
            {
                Console.WriteLine("Id : " + acc.Id);
                Console.WriteLine("Name : " + acc.Name);
                Console.WriteLine("Balance : " + acc.Balance);
            }
        }
    }
}