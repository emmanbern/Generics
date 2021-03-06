﻿namespace Generics
{
    public interface ICircularBufferGeneric<T>
    {
        bool IsEmpty { get; }

        void Write(T value);

        T Read();
    }
}
