using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_ViewComponent.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public static Customer GetCustomerByID(int id)
        {
            List<Customer> customers = new List<Customer>
            {
                 new Customer { ID = 1, Name = "Karim", Email = "karim@gmail.com" },
            new Customer { ID = 2, Name = "Rahim", Email = "rahim@gmail.com" },
            new Customer { ID = 3, Name = "Nadia", Email = "nadia@gmail.com" },
            new Customer { ID = 4, Name = "Samira", Email = "samira@gmail.com" },
            new Customer { ID = 5, Name = "Tariq", Email = "tariq@gmail.com" }
            };
            return customers.FirstOrDefault(x => x.ID == id);
        }
    }
}