using System.Collections.Generic;

namespace Generics
{
    public class CircularBufferGeneric<T> : ICircularBufferGeneric<T>
    {
       
        private T[] _buffer;
        private int _start;
        private int _end;
        private int _capacity;

        public int Capacity
        {
            get { return _buffer.Length; }
        }

        public bool IsEmpty
        {
            get { return _end == _start; }
        }

        public bool IsFull
        {
            get { return (_end + 1) % _buffer.Length == _start; }
        }

        public CircularBufferGeneric() : this(capacity: 10)
        {
        }

        public CircularBufferGeneric(int capacity)
        {
            _buffer = new T[capacity + 1];
            _start = 0;
            _end = 0;
            _capacity = capacity;
        }

        public void Write(T value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;
            if (_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
            }

        }

        public T Read()
        {
            var result = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return result;
        }

    }
}
