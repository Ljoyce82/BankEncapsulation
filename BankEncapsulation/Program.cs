using System.ComponentModel.Design;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
                var account = new BankAccount(); //this has to be out loop or resets there account ever loop 

            while (true)
            {

                Console.WriteLine("Welcome to goblin bank how much would like to deposit? Or type Exit to quit");

                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exting Goblin bank. Goodbye!");
                    return;
                }
                if (double.TryParse(input, out double depositAmount))
                {
                    account.Deposit(depositAmount);

                    Console.WriteLine($"Deposit of {depositAmount} was successfull in in Flipsticks bag..I mean your Account. Your new balance: {account.GetBalance()}");
                }
                else
                {
                    Console.WriteLine("Please goblins know numbers try agian!");
                }
            }

        }
    }
}

