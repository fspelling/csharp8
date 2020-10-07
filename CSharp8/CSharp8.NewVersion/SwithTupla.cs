using NUnit.Framework;

namespace CSharp8.NewVersion
{
    class SwithTupla
    {
        public int GetValue(string type, string value)
        {
            return (type, value) switch
            {
                ("A", "A") => 2,
                ("B", "B") => 4,
                ("C", "C") => 6,
                _ => 0,
            };
        }
    }

    [TestFixture]
    class PaternTuplaTest
    {
        [Test]
        public void GetValueTest()
        {
            var patern = new SwithTupla();

            var value1 = patern.GetValue("A", "A");
            var value2 = patern.GetValue("B", "B");
            var value3 = patern.GetValue("C", "C");
            var value4 = patern.GetValue("A", null);

            Assert.That(value1, Is.EqualTo(2));
            Assert.That(value2, Is.EqualTo(4));
            Assert.That(value3, Is.EqualTo(6));
            Assert.That(value4, Is.EqualTo(0));
        }
    }
}
