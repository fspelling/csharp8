using NUnit.Framework;

namespace CSharp8.NewVersion
{
    ref struct MyStructRef
    {
        public void Dispose() => StructRef.UsingBlockIsDead = true;
    }

    class StructRef
    {
        public static bool UsingBlockIsDead { get; set; } = false;
    }

    [TestFixture]
    class StructRefTest
    {
        [Test]
        public void StructRefWithUsingTest()
        {
            using (var myStructRef = new MyStructRef()) { }
            Assert.That(StructRef.UsingBlockIsDead, Is.True);
        }
    }
}
