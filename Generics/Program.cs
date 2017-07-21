using System;
using System.Globalization;
using static Generics.BufferExtension;

namespace Generics
{
    class Program
    {
        static void ConsoleWrite(object data)
        {
            Console.WriteLine(data);
        }

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            var buffer = new Buffer<double>();


            processInput(buffer);

            Printer consoleOut = new Printer(ConsoleWrite);

            buffer.Dump(consoleOut);

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
