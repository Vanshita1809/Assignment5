
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
           // account.GetDetails();
            Console.WriteLine("Enter account id");
        account.Id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter account type");
            account.AccountType = Console.ReadLine();
            Console.WriteLine("Enter balance");
            account.Balance= Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to be withdrawn");
            double amountWith = Double.Parse(Console.ReadLine());
            Console.WriteLine(account.GetDetails());
            if (account.Withdraw(amountWith))
            {
                Console.WriteLine($"The new balance after deduction is {account.Balance - amountWith}");
            }



        }

    }
