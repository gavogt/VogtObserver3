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

            store.AddObserver(cust);
            store.AddObserver(cust2);
            store2.AddObserver(cust2);

            store.RemoveObserver(cust2);





        }
    }
}
