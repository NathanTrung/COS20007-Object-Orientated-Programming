using System;
using ClockClass;

namespace ClockTests
{
    [TestFixture]
    public class ClockTests
    {
        private Clock clock;

        [SetUp]
        public void SetUp()
        {
            clock = new Clock();
        }

        [Test]
        public void TestTick()
        {

        }

    }
}

