using System;
using NUnit.Framework;
using _2_6_WritingASimpleUnitTest.Fundamentals;
using Math = _2_6_WritingASimpleUnitTest.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();
            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
