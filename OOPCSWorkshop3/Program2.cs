using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSWorkshop3
{
    class Program2
    {
        static void Main(string[] args)
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            BankAccount2 a = new BankAccount2("001-001-001", y, 2000);
            BankAccount2 b = new BankAccount2("001-001-002", z, 5000);

            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
        }
    }
}
class BankAccount2
{
    //
    //attributes
    //

    private string acctNum;
    private Customer acctName;
    private double balance;

    //
    //Constructor
    //

    public BankAccount2(string num, Customer name, double balance)
    {
        acctNum = num;
        acctName = name;
        this.balance = balance;
    }

    public BankAccount2() : this("000-000-000", new Customer(), 0)
    {
    }

    //
    //Properties
    //

    public string AccountNumber
    {
        get { return AccountNumber; }
    }

    public Customer AccountName
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

    public bool TransferTo(double amount, BankAccount2 another)
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
        string m = String.Format("[Account number = {0}, account holder = {1}, account's balance = {2}]", acctNum, acctName.Show(), balance);
        return m;
    }

}

public class Customer
    {
        //
        // Attributes
        //
        private string name;
        private string address;
        private string passport;
        private DateTime dateOfBirth;

        //
        // Constructor
        //

        public Customer(string name, string address, string passport, DateTime dob) : this(name, address, passport)
        {
            this.dateOfBirth = dob;
        }

        public Customer(string name, string address, string passport, int age) : this(name, address, passport)
        {
            this.dateOfBirth = new DateTime(DateTime.Now.Year - age, 1, 1);
        }

        public Customer(string name, string address, string passport)
        {
            this.name = name;
            this.address = address;
            this.passport = passport;
        
        }

        public Customer(): this("NoName", "NoAddress","NoPassport", new DateTime(1980, 1, 1))
        {
        }

        //
        // Properties
        //

        public string Name
        {
            get { return name; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - dateOfBirth.Year;
            }
        }

        //
        // Methods
        //
        public string Show()
        {
            string m = String.Format
                ("[Customer:name = {0}, address = {1}, passport = {2} and age = {3}]", Name, Address, Passport, Age);
            return m;
        }
    }
