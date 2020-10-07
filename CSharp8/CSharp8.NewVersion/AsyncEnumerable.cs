using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp8.NewVersion
{
    class AsyncEnumerable
    {
        public async IAsyncEnumerable<int> GetNumbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }

    [TestFixture]
    class AsyncEnumerableTest
    {
        [Test]
        public async Task AsyncWithLoopTest()
        {
            var asyncLoop = new AsyncEnumerable();

            await foreach (var number in asyncLoop.GetNumbers())
                Console.WriteLine(number);
        }
    }
}
