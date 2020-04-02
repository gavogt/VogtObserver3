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

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_discount);
            }
        }

        public void RemoveObserver(Observer o)
        {
            _observers.Remove(o);
        }

        public float GetDiscount()
        {
            return _discount;

        }
    }
}
