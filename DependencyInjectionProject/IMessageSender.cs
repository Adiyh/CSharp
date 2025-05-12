using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionProject
{
    internal interface IMessageSender
    {
        void Send(string msg);

    }
    internal class EmailSender : IMessageSender
    {
        public void Send(string msg)
        {
            Console.WriteLine("Sending Email:" + msg);
        }
    }
    internal class SmsSender : IMessageSender
    {
        public void Send(string msg)
        {
            Console.WriteLine("Sending SMS:" + msg);
        }

    }
    internal class MessageService
    {
        IMessageSender sender;
        public MessageService(IMessageSender stand)
        {
            this.sender = stand;
        }
        public void SendMessage(string msg)
        {
            sender.Send(msg);
        }

    }
}
