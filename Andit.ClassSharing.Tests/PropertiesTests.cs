using Andit.ClasseSharing;
using Andit.ClassSharing.Tests;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void t0_getPropertyList()
        {
            var ex = new ExampleClass();

            SharingFactory sf = new SharingFactory();
            Assert.AreEqual("UserName", sf.GetProperties(ex)[1]);
        }

        [Test]
        public void t1_GetSpecificInfoByType()
        {
            var ex = new ExampleClass();

            SharingFactory sf = new SharingFactory();
            Assert.AreEqual("UserId", sf.GetPropertyNameByType(ex, "Identifier"));
        }

        [Test]
        public void t2_GetValueByType()
        {
            var ex = new ExampleClass()
            {
                UserId = 5,
                UserName = "A"
            };

            SharingFactory sf = new SharingFactory();
            Assert.AreEqual(5, sf.GetValueByType(ex, "Identifier"));
        }
    }
}