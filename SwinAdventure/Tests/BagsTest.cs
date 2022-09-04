using System;
using NUnit.Framework; 
using SwinAdventure;

namespace SwinAdventureTests
{

    [TestFixture]
    public class BagsTest
    {
        private Item torch = new Item(new string[] { "Torch" }, "Torch", "Shines light");
        private Item apple = new Item(new string[] { "Apple" }, "Apple", "Juciy");
        private Bags testBag = new Bags(new string[] { "TB", "Traveller's Bag" }, "Traveller's Bag", "Holds items for the  player");
        [SetUp]
        public void SetUp()
        {
            Bags testBag = new Bags(new string[] { "TB" }, "Traveller's Bag", "Holds items for the  player");
        }

        [Test]
        public void TestLocateItems()
        {
            testBag.Inventory.Put(torch);
            testBag.Inventory.Put(apple);
            Assert.That(apple, Is.EqualTo(testBag.Locate("Apple")));
            Assert.That(torch, Is.EqualTo(testBag.Locate("Torch")));
        }

        [Test]
        public void TestBagLocatesItself()
        {
            Assert.That(testBag, Is.EqualTo(testBag.Locate("Traveller's Bag")));
        }

        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.That(testBag.Locate("False item"), Is.EqualTo(null));
        }

        [Test]
        public void TestFullDescription()
        {
            testBag.Inventory.Put(torch);
            testBag.Inventory.Put(apple);
            string fullDesc = "Traveller's Bag contains: Torch (Torch) / Apple (Apple) / ";
            Assert.That(fullDesc, Is.EqualTo(testBag.FullDescription));
            
        }

        [Test]
        public void TestBaginBag()
        {
            // new bag
            Bags testBag2 = new Bags(new string[] { "Another Bag" }, "Another Bag", "Second bag");
            Item laptop = new Item(new string[] { "Laptop" }, "Laptop", "Portable device");
            // new item in bag 2
            testBag2.Inventory.Put(laptop);
            // bag 2 into bag1
            testBag.Inventory.Put(testBag2);
            // bag 1 contents
            testBag.Inventory.Put(apple);
            testBag.Inventory.Put(torch);
            // bag 1 contents locate test
            Assert.That(apple, Is.EqualTo(testBag.Locate("Apple")));
            Assert.That(torch, Is.EqualTo(testBag.Locate("Torch")));
            // test that bag 2 items cannot be located within bag 1
            Assert.That(testBag.Locate("Laptop") == null);
            // removing 
            testBag.Inventory.Take(testBag2.Name);
            testBag.Inventory.Take(torch.Name);
            testBag.Inventory.Take(apple.Name);
        }


    }
}

