using NUnit.Framework;

namespace CSharp8.NewVersion
{
    class MyPaternProperty
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    class SwithProperty
    {
        public int GetValue(MyPaternProperty obj)
        {
            return obj switch
            {
                { Type: "A" } => 2,
                { Value: "B" } => 4,
                { Type: "C" } => 6,
                _ => 0
            };
        }
    }

    [TestFixture]
    class PaternPropertyTest
    {
        [Test]
        public void GetValueTest()
        {
            var patern = new SwithProperty();

            var value1 = patern.GetValue(new MyPaternProperty() { Type = "A" });
            var value2 = patern.GetValue(new MyPaternProperty() { Value = "B" });
            var value3 = patern.GetValue(new MyPaternProperty() { Type = "C" });
            var value4 = patern.GetValue(new MyPaternProperty() { Type = "D" });

            Assert.That(value1, Is.EqualTo(2));
            Assert.That(value2, Is.EqualTo(4));
            Assert.That(value3, Is.EqualTo(6));
            Assert.That(value4, Is.EqualTo(0));
        }
    }
}
