using NUnit.Framework;
using System;

namespace CSharp8.NewVersion
{
    interface IPerson
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime BirthDate { get; set; }

        int GetAge() => DateTime.Now.Year - BirthDate.Year;
    }

    class Customer : IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    class User : IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    [TestFixture]
    class InterfaceMethod
    {
        [Test]
        public void InterfaceMethodTest()
        {
            IPerson person = new Customer()
            {
                ID = 1,
                Name = "test",
                BirthDate = Convert.ToDateTime("21/10/1991")
            };

            var years = DateTime.Now.Year - person.BirthDate.Year;
            var yearsAge = person.GetAge();

            Assert.That(years, Is.EqualTo(yearsAge));
        }
    }
}
