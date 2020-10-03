using NUnit.Framework;

namespace CSharp8.NewVersion
{
    enum CalculationTypes
    {
        Sum,
        Multiply
    }

    class FunctionLocalStatic
    {
        public int Calculate(int numberA, int numberB, CalculationTypes type)
        {
            return type switch
            {
                CalculationTypes.Sum => Sum(numberA, numberB),
                CalculationTypes.Multiply => Multiply(numberA, numberB),
            };
            
            static int Sum(int numberA, int numberB) => numberA + numberB;
            static int Multiply(int numberA, int numberB) => numberA * numberB;
        }
    }

    [TestFixture]
    class FunctionLocalStaticTest
    {
        [Test]
        public void CalculateFunctionLocalTest()
        {
            var calc = new FunctionLocalStatic();
            var value1 = calc.Calculate(1, 1, CalculationTypes.Sum);
            var value2 = calc.Calculate(1, 1, CalculationTypes.Multiply);

            Assert.That(value1, Is.EqualTo(2));
            Assert.That(value2, Is.EqualTo(1));
        }
    }
}
