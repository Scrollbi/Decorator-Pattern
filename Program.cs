using Decorator_Pattern;
using System;
using System.Collections.Generic;

public interface INotifier
{
    void Send(string message);
}

public class Program
{
    public static void Main(string[] args)
    {
        List<string> EmailList = new List<string> { "admin_num1@mer.ci.nsu.ru", "admin_num2@mer.ci.nsu.ru", "admin_num3@mer.ci.nsu.ru" };
        INotifier Notifier = new Class(EmailList);

        Notifier = new SMS(Notifier);
        Notifier = new Facebook(Notifier);

        Notifier.Send("Сообщение 123");
    }
}