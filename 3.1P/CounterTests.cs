using System;
using ClockClass;

namespace ClockTests
{
    [TestFixture]
    public class CounterTests
    {
        private Counter counter;
        [SetUp]
        public void Setup()
        {
            counter = new Counter("TestCounter");
        }

        [Test]
        public void TestCounterO()
        {
            Assert.IsTrue(counter.Count == 0);
        }

        [Test]
        public void TestCounterIncrement()
        {
            counter.Increment();
            Assert.IsTrue(counter.Count == 1);
        }

        [Test]
        public void TestCounterIncrementMultiple()
        {
            
            int target = 5;
            for (int i = 0; i < 5; i++)
            {
                counter.Increment();
            }
            int count = counter.Count;
            Assert.AreEqual(count, target);
        }

        [Test]
        public void TestReset()
        {
            int zero = 0;
            for (int i = 0; i <= 5; i++)
            {
                counter.Increment();
            }
            counter.Reset();
            int count = counter.Count;
            Assert.IsTrue(count == zero);
        }
    }
}
