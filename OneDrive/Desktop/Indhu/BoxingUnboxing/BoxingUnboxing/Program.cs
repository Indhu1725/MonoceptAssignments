namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 50;
            object obj = number;        //Boxing
            int value = (int)obj;    // Unboxing

            Console.WriteLine("Original value: " + number);
            Console.WriteLine("After Boxing: " + obj);
            Console.WriteLine("After Unboxing: " + value);
        }
    }
}
