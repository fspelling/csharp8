using NUnit.Framework;
using System.Drawing;

namespace CSharp8.NewVersion
{
    enum MyColor
    {
        Red,
        Green,
        Yellow,
        Blue
    }

    class MyColorClass
    {
        public Color GetColor(MyColor myColor)
        {
            return myColor switch
            {
                MyColor.Blue => Color.Blue,
                MyColor.Green => Color.Green,
                MyColor.Red => Color.Red,
                MyColor.Yellow => Color.Yellow
            };
        }
    }

    [TestFixture]
    class SwithExp
    {
        [Test]
        public void SwithExpTest()
        {
            var myColorClass = new MyColorClass();
            var color = myColorClass.GetColor(MyColor.Blue);

            Assert.That(color, Is.EqualTo(Color.Blue));
        }
    }
}
