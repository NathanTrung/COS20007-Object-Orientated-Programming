using System;
using SwinAdventure;

namespace SwinAdventureTests
{
    public class PlayerTest
    {
        Player playerTest;
        Item testItem;

        [SetUp]
        public void SetUp()
        {
            playerTest = new Player("Nathan", "Young");
            string[] itemIDS = { "Gun" };
            testItem = new Item(itemIDS, "Gun", "Pin-Point");
        }

        [Test]
        public void TestPlayerIsIdentifiable()
        {
            Assert.IsTrue(playerTest.AreYou("me"));
            Assert.IsTrue(playerTest.AreYou("inventory"));
        }

        [Test]
        public void TestPlayerLocateItems()
        {
            playerTest.inventory.Put(testItem);
            Assert.AreEqual(playerTest.Locate("Gun"), testItem);
        }

        [Test]
        public void PlayerLocatesItself()
        {
            Assert.AreEqual(playerTest.Locate("me"), playerTest);
        }

        [Test]
        public void PlayerLocatesNothing()
        {
            Assert.IsTrue(playerTest.Locate("Slipper") == null);
        }

        [Test]
        public void PlayerFullDescription()
        {
            string[] newitemIDS = { "Axe" };
            Item newtestItem = new Item(newitemIDS, "Axe", "Sharp");
            playerTest.inventory.Put(newtestItem);
            string fullDescrip = "You are Nathan Young\nYou are carrying:\nAxe (Axe)";
            fullDescrip += " / ";
            Assert.AreEqual(playerTest.FullDescription, fullDescrip);
        } 
    }
}
