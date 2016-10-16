using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpnCalculator.Observer;

namespace RpnCalculator.Model
{
    public abstract class AbstractCalculator : IObservable
    {
        private List<IObserver> observers;

        public AbstractCalculator()
        {
            this.observers = new List<IObserver>();
        }

        public abstract void Calculate(string expression);

        public void AddObserver(IObserver observer)
        {
            if (observer != null)
            {
                this.observers.Add(observer);
            }
        }

        public bool RemoveObserver(IObserver observer)
        {
            return this.observers.Remove(observer);
        }

        public void NotifiyObserver(string notification)
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(notification);
            }
        }

        public List<IObserver> Observers
        {
            get
            {
                return this.observers;
            }
        }
    }
}
