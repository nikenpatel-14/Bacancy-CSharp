using System;

class BankAccount
{

    public decimal Balance { get; set; }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }


    public void withdraw(decimal ammount)
    {

        try
        {

            if (Balance < ammount)
            {
                throw new NotSufficientBalanceException("you do not have sufficient balance");

            }
            Balance -= ammount;
            Console.WriteLine("your withdrawl has been done succesfully");

        }

        catch (NotSufficientBalanceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("succesfully loging has been completed");

        }
    }
}
class NotSufficientBalanceException : Exception
{
    public NotSufficientBalanceException(string message) : base(message)
    { 
    }

}
class Simulation
    {


        static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount(50000);


            //this will throw exception
            bankAccount.withdraw(60000);

            //bankAccount.withdraw(20000);

    

        }
    }
