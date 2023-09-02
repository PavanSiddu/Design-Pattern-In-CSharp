using System.Runtime.InteropServices;
using System;

namespace DesignPattern.BehaviouralDesignPattern.ChainOfResponsibilityPattern
{
    public interface IHandler
    {
        void SetNextHandler(IHandler handler);
        void Handle(string incomingSuspect);
    }
}
