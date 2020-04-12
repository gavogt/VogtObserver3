using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver3
{
    class Store : IObserveable
   {

        private readonly List<Observer> _observers = new List<Observer>();

        private float _discount;

        public void AddObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void Notify(float discount)
        {
            foreach (var observer in _observers)
            {
                observer.Update(discount);
            }
        }

        public void RemoveObserver(Observer o)
        {
            _observers.Remove(o);
        }


        public void ApplyDiscount()
        {
            Random random = new Random();

            _discount = random.Next(1, 55);
            Notify(_discount);

        }
    }
}
