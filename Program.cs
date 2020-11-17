using System;

namespace ClassBasics
{
    public class Customer
    {
        private string FirstName { get; set; }

        private string LastName { get; set; }

        public bool IsLocal { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public void ChangeFirstName(string FirstName)
        {
            if (FirstName.Length > 1)
            {
                FirstName = firstName;
            }
        }
    }

    public class DeliveryService
    {
        // Properties

        public string Name { get; set; }

        public string TransitType { get; set; }

        // Methods

        public void Deliver(Product product, Customer customer)
    }

    public void Ship(Customer customer, DeliveryService service)
    {
        if (!customer.IsLocal)
        {
            service.Deliver(this, customer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.ChangeFirstName("a");
            Console.Write(customer.FullName);

            Product tinkerToys = new Product()
            {
                TypeInitializationException = "Tinker Yoys",
                    Description = "You can build anything oyu want",
                    Predicate = 32.99,
                    Quantity = 25
            }
        }
    }
}