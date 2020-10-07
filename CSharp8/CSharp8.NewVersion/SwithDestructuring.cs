using NUnit.Framework;

namespace CSharp8.NewVersion
{
    class MyPoint
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public MyPoint(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }

    enum Quadrant
    {
        Unknow,
        Origin,
        One,
        Two,
        Three
    }

    class SwithDestructuring
    {
        public Quadrant GetQuadrant(MyPoint point) =>
            point switch
            {
                (0, 0) => Quadrant.Origin,
                var (x, y) when x > 0 && y > 0 => Quadrant.One,
                var (x, y) when x < 0 && y > 0 => Quadrant.Two,
                var (x, y) when x > 0 && y < 0 => Quadrant.Three,
                _ => Quadrant.Unknow
            };
    }

    [TestFixture]
    class SwithDestructuringTest
    {
        [Test]
        public void GetQuadrantTest()
        {
            var destruct = new SwithDestructuring();

            var value1 = destruct.GetQuadrant(new MyPoint(0, 0));
            var value2 = destruct.GetQuadrant(new MyPoint(1, 1));
            var value3 = destruct.GetQuadrant(new MyPoint(-1, 1));
            var value4 = destruct.GetQuadrant(new MyPoint(1, -1));
            var value5 = destruct.GetQuadrant(new MyPoint(-1, -1));

            Assert.That(value1, Is.EqualTo(Quadrant.Origin));
            Assert.That(value2, Is.EqualTo(Quadrant.One));
            Assert.That(value3, Is.EqualTo(Quadrant.Two));
            Assert.That(value4, Is.EqualTo(Quadrant.Three));
            Assert.That(value5, Is.EqualTo(Quadrant.Unknow));
        }
    }
}
