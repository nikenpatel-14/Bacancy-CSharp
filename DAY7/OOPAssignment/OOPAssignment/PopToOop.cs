using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOPAssignment
{
    internal class PopToOop
    {


        // pop way to create bankaccount
        public static int acc_id;
        public static string acc_holderName;
        public static int  acc_balance;

        static  void setAccount(int id,string name,int balance)
        {
            acc_id = id;
            acc_holderName = name;
            acc_balance = balance;

        }

        static void deposit(int balance)
        {
           acc_balance += balance;
            Console.WriteLine("current balance after deposit "+acc_balance);
        }
        static void withdraw(int balance)
        {
            acc_balance -= balance;
            Console.WriteLine(" current balance after withdraw "+acc_balance);
        }
        static void Main(string[] args)
        {

            setAccount(1, "niken", 5000);
            //it does not clear for which account we call deposit
            withdraw(2000);
            deposit(5000);

            //BankAccount account1 = new BankAccount(1, "Niken", 5000);
            BankAccount ac1 = new BankAccount(1, "Niken", 10000, "saving_account");//adding type to object
            
            //it show clearly for account 1 we call withdraw
            ac1.withdraw(3000);
            ac1.deposit(2000);

        }

    }

    //oop way to create bankaccount
    class BankAccount
    {
         int acc_id;
         string acc_name;
         int acc_balance;
        string acc_type;//new field added

        public BankAccount(int id, string name,int balance,string type)//pass new field to set it
        {
            acc_balance= balance;
            acc_id = id;
            acc_name = name;
            acc_type = type;//assign the value
        }
        public void withdraw(int balance)
        {
            acc_balance -= balance;
            Console.WriteLine("currently account balance after withdraw "+acc_balance);
        }
        public void deposit(int amount)
        {
            acc_balance += amount;
            Console.WriteLine("currently account balance after the deposit "+acc_balance);
        }

    }
}



