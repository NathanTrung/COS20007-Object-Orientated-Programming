using System;
namespace SwinAdventure
{
    public class Inventory 
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        public void Put(Item item)
        {
            _items.Add(item);
        }

        public Item Take(string id)
        {
            foreach (Item i in _items)
            {
                if(i.AreYou(id))
                {
                    _items.Remove(i);
                    return i;
                }
            }
            return null;
        }

        public Item Fetch(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    return i;
                }
            }
            return null;

        }

        public string ItemList
        {
            get
            {
                string itemList = "";
                foreach (Item i in _items)
                {
                    itemList += i.ShortDescription + " / ";
                }
                return itemList;
            }
        }
    }
}

