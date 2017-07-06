namespace Generics
{
    public interface ICircularBuffer
    {
        void Write(double value);

        double Read();
    }
}
