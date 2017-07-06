using Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CircularBufferGenericTest
    {
        [TestMethod]
        public void Test_With_String()
        {
            var buffer = new CircularBufferGeneric<string>(capacity: 3);
            var value1 = "1.1";
            var value2 = "2.3";

            buffer.Write(value1);
            buffer.Write(value2);

            Assert.AreEqual(value1, buffer.Read());
            Assert.AreEqual(value2, buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }
    }
}
