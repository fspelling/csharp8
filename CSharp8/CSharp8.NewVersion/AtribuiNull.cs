using NUnit.Framework;

namespace CSharp8.NewVersion
{
    [TestFixture]
    class AtribuiNullTest
    {
        [Test]
        public void AtribuiVariableNullTest()
        {
            string test = null;
            test ??= "123";

            Assert.That(test, Is.Not.Null);
        }

        [Test]
        public void AtribuiVariableNotNullTest()
        {
            string test = "test";
            test ??= "123";

            Assert.That(test, Is.EqualTo("test"));
        }
    }
}
