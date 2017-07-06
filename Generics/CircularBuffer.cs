using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CircularBuffer : ICircularBuffer
    {

        private double[] _buffer;
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

        public CircularBuffer() : this(capacity:10)
        {
        }

        public CircularBuffer(int capacity)
        {
            _buffer = new double[capacity + 1];
            _start = 0;
            _end = 0;
            _capacity = capacity;
        }

        public void Write(double value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;
            if(_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
            }

        }

        public double Read()
        {
            var result = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return result;
        }

    }
}
