using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSWorkshop3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount("001-001-001", "Tan Ah Kow", 2000);
            BankAccount b = new BankAccount("001-001-002", "Kim Keng Lee", 5000);

            a.TransferTo(100000, b);
            Console.WriteLine(b.Show());
        }
    }

    class BankAccount
    {
        //
        //attributes
        //

        private string acctNum;
        private string acctName;
        private double balance;

        //
        //Constructor
        //

        public BankAccount(string num, string name, double balance)
        {
            acctNum = num;
            acctName = name;
            this.balance = balance;
        }

        public BankAccount() : this("000-000-000", "NONAME", 0)
        {
        }

        public string AccountNumber
        {
            get { return AccountNumber; }
        }

        public string AccountName
        {
            get { return acctName; }
            set { acctName = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        //
        // Method
        //

        public bool Withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.Error.WriteLine("Withdraw for {0} is unsuccessful", AccountName);
                return false;
            }

            else
            {
                balance -= amount;
                return true;
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public bool TransferTo(double amount, BankAccount another)
        {
            if (Withdraw(amount))
            {
                another.Deposit(amount);
                return true;
            }
            else
            {
                Console.Error.WriteLine("TransferTo for {0} is unsuccessful", AccountName);
                return false;
            }
        }

        public string Show()
        {
            string m = String.Format("[Account number is {0}, account name is {1}, account's balance is {2}]", acctNum, acctName, balance);
            return m;
        }

    }
}
