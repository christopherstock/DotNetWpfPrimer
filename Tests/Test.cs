using NUnit.Framework;

namespace DotNetWpfPrimer.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.IsFalse( false, "Test 1" );
        }

        [Test]
        public void Test2()
        {
            Assert.IsFalse( true, "Test 2" );
        }
    }
}
