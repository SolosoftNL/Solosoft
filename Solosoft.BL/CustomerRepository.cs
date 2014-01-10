using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solosoft.BL
{
    public class CustomerRepository
    {

        public Customer Find(List<Customer> customers, int customerId)
        {
            Customer foundCustomer = null;

            var query = customers.Where(c => c.CustomerId == customerId);
            foundCustomer = query.FirstOrDefault();

            return foundCustomer;
        }

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                .ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //    .ThenByDescending(c=>c.FirstName);

            //RW: wat ook kan is reverse gebruiken!
            return SortByName(customerList).Reverse();

        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                .ThenBy(c => c.CustomerTypeId);
        }

        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.LastName + ", " + c.FirstName);
            return query;
        }

        public dynamic GetNamesAndEmails(List<Customer> customerList)
        {
            var query = customerList.Select(c => new
                                                 {
                                                     Name = c.LastName + ", " + c.FirstName,
                                                     Email = c.EmailAddress
                                                 }
                );

            //aangezien het hier om een anonymous type gaat kunnen we de properties alleen binnnen de functie aanroepen!
            //vandaar ook dat de inhoud van de collectie hier wordt uitgelezen. De aanroep gebeurt in de testomgeving van deze class!
            foreach (var s in query)
            {
                Console.WriteLine(s.Name + " : " + s.Email);
            }

            return query;
        } 

        public List<Customer> Retrieve()
        {
            List<Customer> customerList = new List<Customer>
                                          {
                                              new Customer()
                                              {
                                                  CustomerId = 1,
                                                  FirstName = "Ronald",
                                                  LastName = "Wiedijk",
                                                  CustomerTypeId = 1,
                                                  EmailAddress = "ronald@hoi.nl"
                                              },
                                              new Customer()
                                              {
                                                  CustomerId = 2,
                                                  FirstName = "Marcel",
                                                  LastName = "Wiedijk",
                                                  CustomerTypeId = null,
                                                  EmailAddress = "Marcel@hoi.nl"
                                              },
                                              new Customer()
                                              {
                                                  CustomerId = 3,
                                                  FirstName = "Enno",
                                                  LastName = "Zijp",
                                                  CustomerTypeId = 2,
                                                  EmailAddress = "enno@hoi.nl"
                                              },
                                              new Customer()
                                              {
                                                  CustomerId = 4,
                                                  FirstName = "Jordi",
                                                  LastName = "Glas",
                                                  CustomerTypeId = null,
                                                  EmailAddress = "jordi@hoi.nl"
                                              },
                                              new Customer()
                                              {
                                                  CustomerId = 5,
                                                  FirstName = "Nicolien",
                                                  LastName = "Zijp",
                                                  CustomerTypeId = null,
                                                  EmailAddress = "nicolien@hoi.nl"
                                              },
                                              new Customer()
                                              {
                                                  CustomerId = 6,
                                                  FirstName = "Jeroen",
                                                  LastName = "Goudsblom",
                                                  CustomerTypeId = 3,
                                                  EmailAddress = "jeroen@hoi.nl"
                                              },
                                              new Customer()
                                              {
                                                  CustomerId = 7,
                                                  FirstName = "Sjoerd",
                                                  LastName = "Endel",
                                                  CustomerTypeId = 4,
                                                  EmailAddress = "sjoerd@hoi.nl"
                                              }
                                          };
            return customerList;
        }
    }
}
