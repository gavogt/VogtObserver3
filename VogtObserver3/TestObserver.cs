using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver3
{
    class TestObserver
    {
        public static void Run()
        {
            Store store = new Store();
            Store store2 = new Store();

            Customer cust = new Customer("Julie", "Bed Bath & Beyond");
            Customer cust2 = new Customer("Doug", "Hot Topic");

            TestObserver test = new TestObserver();

            test.AddCustomerToStore(cust,store);
            test.AddCustomerToStore(cust2, store);
            test.AddCustomerToStore(cust2, store2);

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

        public void AddCustomerToStore(Customer cust, Store store)
        {
            store.AddObserver(cust);

        }

        public void RemoveCustomerFromStore(Customer cust, Store store)
        {
            store.RemoveObserver(cust);

        }
    }
}
