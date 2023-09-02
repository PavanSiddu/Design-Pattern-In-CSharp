using System;

namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    public class Message
    {
        private readonly string message;

        public Message(string message)
        {
            this.message = message;
        }

        public string GetMessage()
        {
            return this.message;
        }
    }
}
