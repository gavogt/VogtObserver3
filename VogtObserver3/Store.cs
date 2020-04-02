using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver3
{
    class Store : IObserveable
   {

        private readonly List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {

            }
        }

        public void RemoveObserver(Observer o)
        {
            _observers.Remove(o);
        }
    }
}
