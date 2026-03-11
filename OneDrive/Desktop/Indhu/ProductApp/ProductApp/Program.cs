namespace ProductApp
{
    internal class Product
    {
        // Model Class
            int Id;
            string Name;
            double Price;
            double DiscountPercentage;
            // Constructor
            public Product(int id, string name, double price, double discountPercentage)
            {
                Id = id;
                Name = name;
                Price = price;
                DiscountPercentage = discountPercentage;
            }

            // Method to calculate price after discount
            public double GetPriceAfterDiscount()
            {
                double discountAmount = Price * DiscountPercentage / 100;
                return Price - discountAmount;
            }

            // Method to display product details
            public void Display()
            {
                Console.WriteLine("Product Id: " + Id);
                Console.WriteLine("Product Name: " + Name);
                Console.WriteLine("Actual Price: " + Price);
                Console.WriteLine("Discount Percentage: " + DiscountPercentage + "%");
                Console.WriteLine("Price After Discount: " + GetPriceAfterDiscount());
                Console.WriteLine();
            }
        }
        // Test Class
        class Program
        {
            static void Main(string[] args)
            {
                Product p1 = new Product(1, "Washing Machine", 45000, 10);
                Product p2 = new Product(2, "AC", 40000, 5);

                p1.Display();
                p2.Display();

                Console.ReadLine();
            }
        }
    }