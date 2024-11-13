using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Facebook : Decorator
    {
        public Facebook(INotifier Notifier) : base(Notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Отправка сообщения на Facebook: {message}");
        }
    }
}
