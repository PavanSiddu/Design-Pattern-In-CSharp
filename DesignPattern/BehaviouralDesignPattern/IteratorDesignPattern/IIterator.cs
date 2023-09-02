using System;

namespace DesignPattern.BehaviouralDesignPattern.IteratorDesignPattern
{
    public interface IIterator
    {
        string GetNext();
        bool HasMore();
    }
}
