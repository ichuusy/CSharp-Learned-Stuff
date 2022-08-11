using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("ichuusy","durden",31);
            BaseCustomerService starbucksCustomerService = new StarbucksCustomerService(new CustomerCheckService());
            starbucksCustomerService.Save(customer);
            starbucksCustomerService.BuyCoffee();
            Console.WriteLine();
            BaseCustomerService neroCustomerService = new NeroCustomerService();
            neroCustomerService.Save(customer);
            neroCustomerService.BuyCoffee();
            Console.ReadKey();
        }

        public class Customer 
        {
            public string firstname;
            public string lastname;
            public int age;
            public Customer(string firstname, string lastname, int age) 
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.age = age;
            }
        }
        interface ICustomerService 
        {
            void Save(Customer customer);
        }

        public abstract class BaseCustomerService : ICustomerService
        {
            public virtual void Save(Customer customer) 
            {
                Console.WriteLine("Informations Saved to database.");
            }
            public abstract void BuyCoffee();
        }

        public interface ICustomerCheckService 
        {
            bool CheckIfRealPerson(Customer customer);
        }

        public class CustomerCheckService : ICustomerCheckService 
        {
            public bool CheckIfRealPerson(Customer customer)
            {
                if(customer.firstname == "ichuusy" && customer.lastname == "durden") 
                {
                    Console.WriteLine("Information is correct.");
                    return true;

                }
                else 
                {
                    throw new Exception("Information is not correct.");
                }
            }
        }

        public class StarbucksCustomerService : BaseCustomerService 
        {
            ICustomerCheckService _customerCheckService;

            public StarbucksCustomerService(ICustomerCheckService customerCheckService)
            {
                _customerCheckService = customerCheckService;
            }

            public override void Save(Customer customer) 
            {
                if (_customerCheckService.CheckIfRealPerson(customer)) 
                {
                    base.Save(customer);
                }
            }
            public override void BuyCoffee() 
            {
                Console.WriteLine("Starbucks : You earned a star thanks for buying coffee.");
            }
        }
        public class NeroCustomerService : BaseCustomerService 
        {
            public override void Save(Customer customer)
            {
                base.Save(customer);
            }
            public override void BuyCoffee()
            {
                Console.WriteLine("Nero : Thanks for buying coffee.");
            }
        }
    }
}
