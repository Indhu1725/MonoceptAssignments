namespace TryParsePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int number;

            if (int.TryParse(input, out number))
            {
                Console.WriteLine("Converted Number: " + number);
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter a valid integer.");
            }
        }
    }
}