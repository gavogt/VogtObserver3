using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver3
{
    class Test
    {
        public static void Run()
        {
            Store store = new Store();
            Store store2 = new Store();

            Customer cust = new Customer("Julie", "Bed Bath & Beyond");
            Customer cust2 = new Customer("Doug", "Hot Topic");

            cust.AddCustomerToStore(cust,store);
            cust2.AddCustomerToStore(cust2, store);
            cust2.AddCustomerToStore(cust2, store2);

            //store.AddObserver(cust);
            //store.AddObserver(cust2);
            //store2.AddObserver(cust2);


            for (int i = 0; i < 20; i++)
            {
                store.ApplyDiscount();
                store2.ApplyDiscount();
            }


            store.RemoveObserver(cust2);


            for (int i = 0; i < 20; i++)
            {
                store.ApplyDiscount();
                store2.ApplyDiscount();
            }

        }
    }
}
