using System;
namespace SwinAdventure
{
    public class Bags : Item
    {
        private Inventory _inventory;

        public Bags(string[] id, string name, string desc) : base(id, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this; 
            }
            return _inventory.Fetch(id); 
        }

        public override string FullDescription
        {
            get
            {
                string description = $"{this.Name} contains: ";
                description += _inventory.ItemList;
                return description;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

    }
}

