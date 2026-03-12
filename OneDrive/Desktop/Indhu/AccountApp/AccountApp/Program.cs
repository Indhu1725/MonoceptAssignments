namespace AccountApp
{
    internal class Account
    {
            string accountNumber;
            string name;
            double balance;
            string accountType;

            // Constructor
            public Account(string name, double balance, string accountType)
            {
                this.accountNumber = GenerateAccountNumber();
                this.name = name;
                this.balance = balance;
                this.accountType = accountType;
            }
            // Random Account Number Generator
            private string GenerateAccountNumber()
            {
                Random r = new Random();
                long num = (long)(r.NextDouble() * 100000000000);
                return "IDBI" + num.ToString();
            }
            // Getters
            public string GetAccountNumber()
            {
                return accountNumber;
            }
            public double GetBalance()
            {
                return balance;
            }
            public string GetName()
            {
                return name;
            }
            public string GetAccountType()
            {
                return accountType;
            }
            // Setters
            public void SetName(string name)
            {
                this.name = name;
            }
            public void SetAccountType(string type)
            {
                this.accountType = type;
            }
            // Deposit Method
            public void Deposit(double amount)
            {
                balance += amount;
                Console.WriteLine("Amount Deposited Successfully.");
            }
            // Withdraw Method
            public void Withdraw(double amount)
            {
                if (balance - amount >= 500)
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal Successful.");
                }
                else
                {
                    Console.WriteLine("Minimum balance of 500 must be maintained.");
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Account acc = null;
                int choice;

                do
                {
                    Console.WriteLine("\n1. Create an Account");
                    Console.WriteLine("2. View Balance");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4. Withdraw");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice: ");
                    int.TryParse(Console.ReadLine(), out choice);

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Initial Balance: ");
                            double.TryParse(Console.ReadLine(), out double balance);

                            Console.Write("Enter Account Type (Savings/Current): ");
                            string type = Console.ReadLine();

                            acc = new Account(name, balance, type);

                            Console.WriteLine("Account Created Successfully.");
                            Console.WriteLine("Account Number: " + acc.GetAccountNumber());
                            break;

                        case 2:
                            if (acc != null)
                                Console.WriteLine("Balance: " + acc.GetBalance());
                            else
                                Console.WriteLine("Create an account first.");
                            break;

                        case 3:
                            if (acc != null)
                            {
                                Console.Write("Enter amount to deposit: ");
                                double.TryParse(Console.ReadLine(), out double dep);
                                acc.Deposit(dep);
                            }
                            else
                                Console.WriteLine("Create an account first.");
                            break;

                        case 4:
                            if (acc != null)
                            {
                                Console.Write("Enter amount to withdraw: ");
                                double.TryParse(Console.ReadLine(), out double wd);
                                acc.Withdraw(wd);
                            }
                            else
                                Console.WriteLine("Create an account first.");
                            break;

                        case 5:
                            Console.WriteLine("Thank you!");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                } while (choice != 5);
            }
        }
    }