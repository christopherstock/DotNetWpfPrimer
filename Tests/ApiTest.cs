using NUnit.Framework;

namespace DotNetWpfPrimer.Tests
{
    [TestFixture]
    public class ApiTest
    {
        [Test]
        public void Test_ICNDB_URL()
        {
            var url = Api.GetRandomJokeUrl();

            Assert.AreEqual( "http://api.icndb.com/jokes/random", url );
        }
    }
}
