using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp8.NewVersion
{
    class MyFile : StreamReader
    {
        public bool IsDead { get; private set; }

        public MyFile(string path) : base(path)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            IsDead = true;
        }
    }

    class UsingBlock
    {
        public MyFile MyFile { get; private set; }

        public void WriteLines(IEnumerable<string> lines)
        {
            using var myFile = new MyFile("test.txt");

            foreach (var line in lines)
                Console.WriteLine(line);

            MyFile = myFile;
        }
    }

    [TestFixture]
    class UsingBlockTest
    {
        [Test]
        public void MyFileTest()
        {
            var block = new UsingBlock();
            block.WriteLines(new List<string>() { "test" });

            var myfile = block.MyFile;
            Assert.That(myfile.IsDead, Is.True);
        }
    }
}
