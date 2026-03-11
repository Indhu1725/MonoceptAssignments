namespace BookApp
{
    internal class Book
    {
            string Title;
            string Author;
            double Price;
            bool IsBestseller;
            // Constructor
            public Book(string title, string author, double price, bool isBestseller)
            {
                Title = title;
                Author = author;
                Price = price;
                IsBestseller = isBestseller;
            }
            // Method to calculate discounted price
            public double CalculateDiscountedPrice()
            {
                double finalPrice = Price;
                if (IsBestseller)
                {
                    finalPrice = finalPrice - (finalPrice * 0.10);
                }

                if (Price > 500)
                {
                    finalPrice = finalPrice - (finalPrice * 0.05);
                }

                return finalPrice;
            }
            // Display Method
            public void Display()
            {
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("Original Price: " + Price);
                Console.WriteLine("Is Bestseller: " + IsBestseller);
                Console.WriteLine("Price After Discount: " + CalculateDiscountedPrice());
                Console.WriteLine();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Book b1 = new Book("C#", "Varun", 1000, true);
                Book b2 = new Book("Python", "Nikhil", 350, false);

                b1.Display();
                b2.Display();

                Console.ReadLine();
            }
        }
    }