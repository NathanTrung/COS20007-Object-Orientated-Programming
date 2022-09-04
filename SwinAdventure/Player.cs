using System;
using SwinAdventure;

namespace SwinAdventure
{
    public class Player : GameObject
    {
        private Inventory _inventory;

        public Player(string name, string desc) :
            base ( new string[] {"me", "inventory"}, name, desc)
            
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
                return $"You are {this.Name} {base.FullDescription}\nYou are carrying:\n{_inventory.ItemList}";
            }

        }

        public Inventory inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}

