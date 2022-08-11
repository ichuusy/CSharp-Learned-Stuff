using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ATM_Software
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Bank bank = new Bank();
            bank.Login(person);
            bank.Withdraw(person, 300);
            Console.WriteLine($"Person's money : {person.money}");
            bank.Deposit(person, 100);
            Console.WriteLine($"Person's money : {person.money}");
            Console.Read();
        }

        public struct Person 
        {
            public string name = "ichuusy";
            public string cardId = "123456789";
            public int money = 500;
        }
        public abstract class LoginChecker : ILogin
        {
            public void Login(Person person)
            {
                if (person.name == "ichuusy" && person.cardId == "123456789")
                {
                    Console.WriteLine("Login successfully");
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        interface ILogin
        {
            void Login(Person person);
        }

        public class Bank : LoginChecker
        {
            public void Withdraw(Person person, int withdrawedMoney)
            {
                if (person.money >= withdrawedMoney)
                {
                    person.money -= withdrawedMoney;
                    Console.WriteLine("Money is withdrawed.");
                }
                else
                {
                    Console.WriteLine("Sorry, your money not enough.");
                }
            }
            public void Deposit(Person person, int depositedMoney)
            {
                person.money -= depositedMoney;
                Console.WriteLine("Money is deposited");
            }
        }

    }
}
