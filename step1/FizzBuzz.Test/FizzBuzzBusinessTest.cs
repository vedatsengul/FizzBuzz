using FizzBuzz.Business;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Test
{
    public class FizzBuzzBusinessTest
    {
        [Test]
        public void ProcessRangeInput()
        {
            var fizzBuzzBusiness = new FizzBuzzBusiness();

            var expectedResult = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz";

            Assert.AreEqual(fizzBuzzBusiness.ProcessInputRange(1, 20), expectedResult);
        }
    }
}
