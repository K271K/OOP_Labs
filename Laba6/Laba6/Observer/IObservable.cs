using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Observer
{
    internal interface IObservable
    {
        void Notify();
        void AddObserver(IObserver obj);
    }
}
