using System.Collections.Generic;
using System.ComponentModel;

namespace Generics
{
    public static class BufferExtension
    {

        public delegate void Printer(object data);

        public static void Dump<T>(this IBuffer<T> buffer, Printer print)
        {
            foreach (var item in buffer)
            {
                print(item);
            }
        }

        public static IEnumerable<TOutput> AsEnumerableOf<T, TOutput>(this IBuffer<T> buffer)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in buffer)
            {
                TOutput result = (TOutput)converter.ConvertTo(item, typeof(TOutput));
                yield return result;
            }
        }
    }
}
