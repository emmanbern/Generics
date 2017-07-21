using System;
using System.Globalization;

namespace Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            //Exemple de délégate avec lambda
            Action<bool> print = d => Console.WriteLine(d);

            //Delegate avec un type de retour.
            Func<double, double> square = d => d * d;

            //Delegate avec deux parametre **le dernier parametre est toujour le type de retour.
            Func<double, double, double> addition = (x, y) => x + y;

            //Predicate **retourne toujour un boolean.
            Predicate<double> isLessThanTen = d => d < 10;

            //Permet de chainer les types de delegate.
            print(isLessThanTen(addition(square(3), 3)));

            var buffer = new Buffer<double>();

            processInput(buffer);


            buffer.Dump(d => Console.WriteLine(d));

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
