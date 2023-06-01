using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Observer
{
    internal interface IObserver
    {
        void OnSubjectChanged(IObservable obj);
    }
}
