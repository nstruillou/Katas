using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        bool RemoveObserver(IObserver observer);
        void NotifiyObserver(string notification);
    }
}
