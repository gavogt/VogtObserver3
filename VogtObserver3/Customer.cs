using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver3
{
    class Customer : Observer
    {
        private readonly string _name;
        private readonly string _favoriteStore;
        
        public Customer(string name, string favoriteStore)
        {
            _name = name;
            _favoriteStore = favoriteStore;

        }
        public override void Update(float discount)
        {
            Console.WriteLine("Discount is discount");
        }

        public Store AddCustomerToStore(Customer cust, Store store)
        {
            store.AddObserver(cust);

            return store;
        }

        public Store RemoveCustomerFromStore(Customer cust, Store store)
        { 
            store.AddObserver(cust);

            return store;
        }

    }
}
