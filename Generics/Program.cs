using System;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void ConsoleWrite(double data)
        {
            Console.WriteLine(data);
        }

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            var buffer = new Buffer<double>();


            processInput(buffer);


            buffer.Dump(ConsoleWrite);

            var asInts = buffer.AsEnumerableOf<double, int>();


            //A été ajouté à la méthode d'extension
            //foreach (var item in buffer)
            //{
            //    Console.WriteLine(buffer);
            //}

            processBuffer(buffer);

            Console.ReadLine();
        }

        private static void processBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

        private static void processInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}
