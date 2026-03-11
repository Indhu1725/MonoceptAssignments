namespace BankGame
{
    internal class BankAccount
    {
        string AccountHolder { get; set; }
        double Balance { get; set; }
        // Constructor
        public BankAccount(string name, double balance)
        {
            AccountHolder = name;
            Balance = balance;
        }
        // Deposit Method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine(AccountHolder + " deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }
        // Withdraw Method
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine(AccountHolder + " withdrew: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();

                // Create two accounts with random balances
                BankAccount a1 = new BankAccount("Varun", rnd.Next(2000, 5000));
                BankAccount a2 = new BankAccount("Nikhil", rnd.Next(2000, 5000));

                Console.WriteLine("Initial Balances");
                Console.WriteLine(a1.AccountHolder + ": " + a1.Balance);
                Console.WriteLine(a2.AccountHolder + ": " + a2.Balance);
                Console.WriteLine();
                // 3 rounds
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Round " + i);
                    // Account 1 turn
                    double amount1 = rnd.Next(100, 500);
                    if (rnd.Next(2) == 0)
                        a1.Deposit(amount1);
                    else
                        a1.Withdraw(amount1);

                    // Account 2 turn
                    double amt2 = rnd.Next(100, 500);
                    if (rnd.Next(2) == 0)
                        a2.Deposit(amt2);
                    else
                        a2.Withdraw(amt2);

                    Console.WriteLine();
                }

                // Final balances
                Console.WriteLine("Final Balances");
                Console.WriteLine(a1.AccountHolder + ": " + a1.Balance);
                Console.WriteLine(a2.AccountHolder + ": " + a2.Balance);

                // Winner
                if (a1.Balance > a2.Balance)
                    Console.WriteLine("Winner: " + a1.AccountHolder);
                else if (a2.Balance > a1.Balance)
                    Console.WriteLine("Winner: " + a2.AccountHolder);
                else
                    Console.WriteLine("It's a Tie!");

                Console.ReadLine();
            }
        }
    }
}