using NUnit.Framework;

namespace CSharp8.NewVersion
{
    class TypeNullable
    {
    }

    [TestFixture]
    class TypeNullableTest
    {
        [Test]
        public void TypeNullableNotNullTest()
        {
            string test = null;
            TypeNullable test2 = null;
        }

        [Test]
        public void TypeNullableWithNullTest()
        {
#nullable enable
            string test = null;
            TypeNullable test2 = null;
#nullable enable
        }
    }
}
