using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class Decorator : INotifier
    {
        protected INotifier _Notifier;

        public Decorator(INotifier Notifier)
        {
            _Notifier = Notifier;
        }

        public virtual void Send(string message)
        {
            _Notifier.Send(message);
        }
    }
}
