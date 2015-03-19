using NUnit.Framework;

namespace CheckUnitTestingAndCodelens
{
    public class SomeClassToBeTested
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    [TestFixture]
    public class TestForSomeClassToBeTested
    {
        [Test]
        public void CheckNonParametrizedTesting()
        {
            var sut = new SomeClassToBeTested();

            int result = sut.Add(2, 2);

            Assert.That(result, Is.EqualTo(4));
        }

        [TestCase(1, 1, 2)]
        [TestCase(3, 4, 7)]
        public void CheckParametrizedTesting(int a, int b, int expected)
        {
            var sut = new SomeClassToBeTested();

            int result = sut.Add(a, b);

            Assert.That(result,Is.EqualTo(expected));
        }

    }
}
