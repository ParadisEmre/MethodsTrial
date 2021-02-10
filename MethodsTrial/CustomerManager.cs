using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsTrial
{
    class CustomerManager
    {
        public void Add(Customer cus)
        {
            Console.WriteLine("Customer is added " + cus.Name + " " + cus.Surname);
        }
        public void Remove(Customer cus)
        {
            Console.WriteLine("Customer is removed " + cus.Name + " " + cus.Surname);
        }
        public void List(Customer cus)
        {
            Console.WriteLine("Customer : " + cus.Name + " " + cus.Surname + " " + cus.Id + " " + cus.AccountAm);
        }

    }
}
