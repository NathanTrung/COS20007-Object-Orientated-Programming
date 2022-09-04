using System;
using NUnit.Framework;
using SwinAdventure;

namespace SwinAdventureTests
{
    public class ItemTest
    {
        Item testItem;
        private string[] testIDS = new[] { "Shove", "Dig" };

        [SetUp]
        public void SetUp()
        {
            testItem = new Item(testIDS, "Shovel", "Big");
        }

        [Test]
        public void TestItemIsIdentifiable()
        {
            Assert.IsTrue(testItem.AreYou("Shove"));
            Assert.IsTrue(testItem.AreYou("Dig"));
        }

        [Test]
        public void TestItemShortDescription()
        {
            Assert.AreEqual("Shovel (Shove)", testItem.ShortDescription);
        }

        [Test]
        public void TestItemFullDescription()
        {
            Assert.AreEqual("Big", testItem.FullDescription);
        }
   
    }
}

