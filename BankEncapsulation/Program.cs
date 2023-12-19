namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var jennysAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            jennysAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your available balance is now {jennysAccount.GetBalance()}");

            Console.WriteLine("How much would you like to withdraw?");

            var amountToWithdraw = double.Parse(Console.ReadLine());

            jennysAccount.Deposit(amountToWithdraw);

            Console.WriteLine($"Thanks for withdrawing the amount of {jennysAccount.GetBalance()}");
        }
    }
}
