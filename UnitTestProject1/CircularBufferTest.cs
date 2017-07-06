using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;

namespace UnitTestProject1
{
    [TestClass]
    public class CircularBufferTest
    {
        [TestMethod]
        public void Overwrite_When_More_Than_Capacity()
        {
            var buffer = new CircularBuffer();
            var values = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            foreach(var value in values)
            {
                buffer.Write(value);
            }

            Assert.IsTrue(buffer.IsFull);
            Assert.AreEqual(values[2], buffer.Read());
            Assert.AreEqual(values[2], buffer.Read());
            Assert.AreEqual(values[2], buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }
    }
}
