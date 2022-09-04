using System;

namespace ClockClass
{
    public class Clock
    {
        private Counter _hours;
        private Counter _minutes;
        private Counter _seconds;

        public Clock()
        {
            _hours = new Counter("hours");
            _minutes = new Counter("minutes");
            _seconds = new Counter("seconds");
        }

        public void Reset()
        {
            _hours.Reset();
            _minutes.Reset();
            _seconds.Reset();
        }

        public void Tick()
        {
            if (_seconds.Count == 59)
            {
                _seconds.Reset();
                if (_minutes.Count == 59)
                {
                    _minutes.Reset();
                    if (_hours.Count == 23)
                    {
                        Reset();
                    }
                    else
                    {
                        _hours.Increment();
                    }
                }
                else
                {
                    _minutes.Increment();
                }
            }
            else
            {
                _seconds.Increment();
            }
        }
    

        public void ReadTime()
        {
            Console.WriteLine(_hours.Count.ToString("00") + ":" + _minutes.Count.ToString("00") + ":" + _seconds.Count.ToString("00"));
        }
       
    }
}