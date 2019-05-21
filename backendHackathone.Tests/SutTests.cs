using NUnit.Framework;
using backendHackathone.Core;

namespace Tests
{
    public class SutTests
    {
        [TestCase(1,2,3)]
        [TestCase(1, 4, 5)]
        public void Test1(int a, int b, int result)
        {
            var sutClass = new SUTClass();

            Assert.AreEqual(sutClass.SUTMethod(a,b), result);
        }
    }
}