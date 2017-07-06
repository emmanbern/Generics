using System.Collections.Generic;

namespace Generics
{
    public class Buffer<T> : IBuffer<T>
    {
        Queue<T> _queue = new Queue<T>();

        public bool IsEmpty
        {
            get
            {
                return _queue.Count == 0;
            }
        }

        public void Write(T value)
        {
            _queue.Enqueue(value);
        }

        public T Read()
        {
            return _queue.Dequeue();
        }
    }
}
