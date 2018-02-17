using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NumberOperationTest
{
    [TestFixture]
    public class NumberTest
    {
        [Test]
        public void AddDigitsTest()
        {
            int number = 1365;

            Number add = new Number();
            int sum = add.AddDigits(number);

            Assert.AreEqual(15, sum);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideDigitsTest()
        {
            int number = 120;

            Number divide = new Number();
            divide.DivideDigits(number);

        }
    }
}

