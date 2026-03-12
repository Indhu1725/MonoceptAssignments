namespace ParamsPOC
{
    internal class Program
    {
        static void AddNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine("Sum = " + sum);
        }
        static void Main(string[] args)
        {
            AddNumbers(15, 30);
            AddNumbers(10, 15, 15);
            AddNumbers(15, 12, 23, 44, 25);
        }
    }
}