using System.Collections.Generic;
namespace DesignPattern.BehaviouralDesignPattern.IteratorDesignPattern
{
    public class CustomIterableCollection : IIterableCollection
    {
        private List<string> internalList = new List<string>();

        public IIterator CreateIterator()
        {
            return new CustomIterableCollectionIterator(this);
        }

        public CustomIterableCollection()
        {
            internalList.Add("I");
            internalList.Add("love");
            internalList.Add("binary.");
        }
        public int Size()
        {
            return this.internalList.Count;
        }

        public string GetStringAtIndex(int i)
        {
            return this.internalList[i];
        }
    }
}
