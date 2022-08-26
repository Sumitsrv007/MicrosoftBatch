using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops
{
   /* class BankDetail
    {
        long accountNo;
        String accountType;
        String CustomerName;
        long balance;
        public void detail()
        {
            Console.WriteLine("Enter Account Number:");
            long accountNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Type Saving or Demat:");
            String accountType = Console.ReadLine();
            Console.WriteLine("Enter Customer Name:");
            String CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Account Number:");
            long balance = long.Parse(Console.ReadLine());
        }

        public void show()
        {
            Console.WriteLine("Account Number="+ accountNo);
            Console.WriteLine("Account Type=" + accountType);
            Console.WriteLine("Account Name=" + CustomerName);
            Console.WriteLine("Account Balance=" + balance);
        }
        public void withdraw()
        {
            Console.WriteLine("Enter Amount to withdraw: ");
            long w = long.Parse(Console.ReadLine());
            balance = balance - w;
            
        }
        public void deposit()
        {
            Console.WriteLine("Enter deposit Amount: ");
            long d = long.Parse(Console.ReadLine());
            long deposit = balance + d;
            Console.WriteLine("Updated Deposit="+deposit);
            display();
        }
        public void display()
        {
            Console.WriteLine("Updated Balance is "+balance);
        }
    }
    class Bank
    {
        static void Main(string[] args)
        {
            BankDetail bd = new BankDetail();
            bd.deposit();
            Console.WriteLine("You want to W or D");
            char c = char.Parse(Console.ReadLine());
            if(c=='W')
            {
                bd.withdraw();
            }
            else
            {
                bd.deposit();
            }
            
        }
    }*/
}
