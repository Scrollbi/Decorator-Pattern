using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class SMS : Decorator
    {
        public SMS(INotifier Notifier) : base(Notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Отправка SMS: {message}");
        }
    }
}
