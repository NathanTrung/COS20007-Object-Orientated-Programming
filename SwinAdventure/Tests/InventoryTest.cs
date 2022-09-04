using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using SwinAdventure;

namespace SwinAdventureTests
{
    public class InventoryTest
    {
        private Inventory testInventory;
        private Item testItem;
        private Item apple;
        private Item bow;

        [SetUp]
        public void SetUp()
        {
            string[] sword = { "Sword" };
            testInventory = new Inventory();
            testItem = new Item(sword, "Sword", "Long");
            string[] appleID = { "Apple" };
            apple = new Item(appleID, "Apple", "Tasty");
            string[] bowID = { "Bow" };
            bow = new Item(bowID, "Bow", "Flimsy");
        }

        [Test]
        public void TestFindItem()
        {
            testInventory.Put(testItem);
            Assert.IsTrue(testInventory.HasItem("Sword"));
        }

        [Test]
        public void NoItemFind()
        {
            Assert.IsFalse(testInventory.HasItem("Stick"));
        }

        [Test]
        public void TestFetchItem()
        {
            testInventory.Put(testItem);
            Assert.AreEqual(testInventory.Fetch("Sword"), testItem);
        }

        [Test]
        public void TestTakeItem()
        {
            testInventory.Put(testItem);
            testInventory.Take("Sword");
            Assert.False(testInventory.HasItem("Sword"));
        }
        [Test]
        public void TestItemList()
        { 
            testInventory.Put(apple);
            testInventory.Put(bow);
            string inventoryList = "Apple (Apple) / Bow (Bow) / ";
            Assert.AreEqual(inventoryList, testInventory.ItemList);
        }
    }
}

