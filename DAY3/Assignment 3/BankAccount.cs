using System;

class BankAccount
{

    public decimal Balance { get; set; }
    public bool keepRunning = true;
    public decimal ammount;

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }


    public void withdraw()
    {
        do
        {

            Console.WriteLine("enter the ammount you want to withdraw");

            ammount = Convert.ToDecimal(Console.ReadLine());
            
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
                  keepRunning = false;

             }
            finally
            {
                  Console.WriteLine($"current balance : {Balance}");

            }
        }while (keepRunning);
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

        decimal ammount;
        static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount(50000);
            bankAccount.withdraw();
      
        }
    }
