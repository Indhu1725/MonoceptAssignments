namespace InOutPOC
{
    internal class Program
    {
            // Method using OUT
            static void Calculate(int a, int b, out int sum, out int product)
            {
                sum = a + b;
                product = a * b;
            }
            // Method using IN
            static void ShowNumber(in int num)
            {
                Console.WriteLine("Number is: " + num);
            }
            static void Main(string[] args)
            {
                int x = 10, y = 15;
                int sum, product;
                Calculate(x, y, out sum, out product);
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Product: " + product);
                ShowNumber(in x);
            }
        }
    }