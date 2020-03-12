using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    T[] buffer;
    int readIndex;
    int writeIndex;
    int oldestWriteIndex;

    public CircularBuffer(int capacity) => buffer = new T[capacity];

    public T Read()
    {
        var value = buffer[readIndex];
        if(value.isNullOrDefault())
        {
            throw new InvalidOperationException();
        }
        buffer[readIndex] = default(T);
        readIndex = incrementIndex(readIndex);
        if(oldestWriteIndex < readIndex)
        {
            oldestWriteIndex = readIndex;
        }
        return value;
    }

    public void Write(T value)
    {
        if(!buffer[writeIndex].isNullOrDefault())
        {
            throw new InvalidOperationException();
        }
        buffer[writeIndex] = value;
        writeIndex = incrementIndex(writeIndex);
        
    }

    public void Overwrite(T value)
    {
        if(buffer[writeIndex].isNullOrDefault())
        {
            Write(value);
        }
        else
        {
            buffer[oldestWriteIndex] = value;
            oldestWriteIndex = incrementIndex(oldestWriteIndex);
            readIndex = oldestWriteIndex;
        }
    }

    public void Clear() => buffer = new T[buffer.Length];

    public int incrementIndex(int index) => (index + 1) % buffer.Length;
}

public static class GenericExtensions
{
    public static bool isNullOrDefault<T> (this T value) => 
        EqualityComparer<T>.Default.Equals(value, default(T));
}