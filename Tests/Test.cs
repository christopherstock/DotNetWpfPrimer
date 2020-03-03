using NUnit.Framework;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            Assert.IsFalse( false, "Test 1" );
        }
    }
}
