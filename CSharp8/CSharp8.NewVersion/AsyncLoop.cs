using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp8.NewVersion
{
    class AsyncLoop
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
    class AsyncLoopTest
    {
        [Test]
        public async Task AsyncWithLoopTest()
        {
            var asyncLoop = new AsyncLoop();

            await foreach (var number in asyncLoop.GetNumbers())
                Console.WriteLine(number);
        }
    }
}
