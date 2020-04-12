using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver3
{
    interface IObserveable
    {
        public abstract void AddObserver(Observer o);

        public abstract void RemoveObserver(Observer o);

        public abstract void Notify(float discount);

    }
}
