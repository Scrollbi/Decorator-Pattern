using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Class : INotifier
    {
        private List<string> _EmailList;

        public Class(List<string> EmailList)
        {
            _EmailList = EmailList;
        }

        public void Send(string message)
        {
            foreach (var email in _EmailList) Console.WriteLine($"email отправлен на {email}: {message}");
        }
    }
}
