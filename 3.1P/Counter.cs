using System;
namespace ClockClass
{
    public class Counter
    {
        private int _count;
        private string _name;
        
        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public string Name
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

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Increment()
        {
            _count++;
        }

        public void Reset()
        {
            _count = 0;
        }
    }




    public class MainClass
    {
        public static void Main(string[] args)
        {
            Clock clock = new Clock();

            for (int i = 0; i < 34560; i++)
            {
                clock.Tick();
            }
            
            clock.ReadTime();
        }
    }
}

