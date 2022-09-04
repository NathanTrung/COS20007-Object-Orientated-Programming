﻿using System;
using System.Collections.Generic;
public class Counter
    {
        private int _count;
        private string _name;


        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public int Increment()
        {
            _count++;
        return _count;
        }

        public void Reset()
        {
            _count = 0;
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Ticks
        {
            get
            {
                return _count;
            }
        }
    
}


