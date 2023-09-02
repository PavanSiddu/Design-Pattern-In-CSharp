namespace DesignPattern.BehaviouralDesignPattern.IteratorDesignPattern
{
    public class CustomIterableCollectionIterator : IIterator
    {
        private CustomIterableCollection collection;
        private int size;
        private int currentIndex = -1;
        public CustomIterableCollectionIterator(CustomIterableCollection collection)
        {
            this.collection = collection;
            this.size = collection.Size();
        }

        public string GetNext()
        {
            currentIndex++;
            return this.collection.GetStringAtIndex(currentIndex);
        }

        public bool HasMore()
        {
            return currentIndex + 1 < size;
        }
    }
}
