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



        public CircularBuffer() : this(capacity:10)
        {
        }

        public CircularBuffer(int capacity)
        {
            _buffer = new double[capacity + 1];
            _start = 0;
            _end = 0;
        }


        public bool IsFull { get; set; }
        public bool IsEmpty { get; set; }

        public void Write(double number)
        {
            Console.WriteLine(number);
        }

        public double Read()
        {
            return 1.2;
        }



    }
}
