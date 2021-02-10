using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Customer cus1 = new Customer(), cus2 = new Customer(), cus3 = new Customer(), cus4 = new Customer();

            cus1.Name = "Emre";
            cus1.Surname = "Özçatal";
            cus1.Id = 1234567801;
            cus1.AccountAm = 9999999;

            cus2.Name = "Ayşe";
            cus2.Surname = "Ceviz";
            cus2.Id = 987654311;
            cus2.AccountAm = 8888888;

            cus3.Name = "Ali";
            cus3.Surname = "Geyik";
            cus3.Id = 456382079;
            cus3.AccountAm = 738423;

            cus4.Name = "Işıl";
            cus4.Surname = "Havuç";
            cus4.Id = 329423923;
            cus4.AccountAm = 1134568;


            Customer[] customers = new Customer[] { cus1, cus2, cus3, cus4 };

            CustomerManager customerManager = new CustomerManager();
            
            for(i = 0; i < customers.Length; i++) 
            {
                customerManager.Add(customers[i]);
            }
            for (i = 0; i < customers.Length; i++)
            {
                customerManager.Remove(customers[i]);
            }
            for (i = 0; i < customers.Length; i++)
            {
                customerManager.List(customers[i]);
            }
        }

        
        
    }
}

