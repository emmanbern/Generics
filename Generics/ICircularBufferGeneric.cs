namespace Generics
{
    public interface ICircularBufferGeneric<T>
    {
        void Write(T value);

        T Read();
    }
}
