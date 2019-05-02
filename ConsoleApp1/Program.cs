using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customer=new CustomerRepository();

            //Customers AddCustomer=new Customers()
            //{
            //    FullName = "علی محمدی",
            //    CustomerImage = "NoPhoto",
            //    Mobile = "09351212125"
                  
            //};
            //customer.InsertCustomer(AddCustomer);
            //customer.Save();

            var list = customer.GetAllCustomers();
        }
    }
}
