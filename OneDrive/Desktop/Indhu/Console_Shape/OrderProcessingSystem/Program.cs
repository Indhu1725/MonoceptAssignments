using System;
namespace OrderProcessingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func to calculate discount
            Func<double, double> calculateDiscount = (price) =>
            {
                if (price > 1000)
                    return price * 0.15; 
                else
                    return price * 0.05; 
            };

            // Func to calculate final price
            Func<double, double, double> calculateFinalPrice = (price, discount) =>
            {
                return price - discount;
            };

            // Take input from user
            Console.Write("Enter Product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            // Calculate discount
            double discount = calculateDiscount(price);

            // Calculate final price
            double finalPrice = calculateFinalPrice(price, discount);

            // Display results
            Console.WriteLine("\nOrder Summary");
            Console.WriteLine("Original Price: " + price);
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Price: " + finalPrice);

            Console.ReadLine();
        }
    }
}