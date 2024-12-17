namespace BankEncapsulation
{
    public class Program
    {
       static void Main(string[] args)
       {
           BankAccount account = new BankAccount(0);

           while (true)
           {
               Console.WriteLine("Enter 'd' to deposit money or 'b' to check balance. Enter 'q' to EXIT.");
               string choice = Console.ReadLine();
               if (choice == "d")
               {
                   Console.WriteLine("Enter amount of money to deposit.");
                   string input = Console.ReadLine();

                   if (double.TryParse(input, out double amount))
                   {
                       account.Deposit(amount);
                       Console.WriteLine($"You have successfully deposited ${amount}");
                   }
                   else
                   {
                       Console.WriteLine("Invalid input. Try again.");
                   }
               }
               else if (choice == "b")
               {
                   double balance = account.GetBalance();
                   Console.WriteLine($"Your balance is: ${balance}");
               }
               else if (choice == "q")
               {
                   break;
               }
               else
               {
                   Console.WriteLine("Invalid input. Try again.");
               }
           }
       }
    }
}
