using System;
using System.Collections.Generic;
using System.Linq;


namespace SwinAdventure
{
    
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();


        static void Main()
        {

        }

        public IdentifiableObject(string[] indents)
        {
            foreach (string i in indents)
            {
                _identifiers.Add(i);

            }
        }
        public bool AreYou(string id)
        {
            if (_identifiers.Contains(id, StringComparer.OrdinalIgnoreCase))
            {
                return true; 
            }
            return false;
        }

        public string FirstID()
        {
            string holder = "";

            if (_identifiers.Count != 0)
            {
                holder = _identifiers[0];   
            }
            return holder;
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id);
        }
    }
}