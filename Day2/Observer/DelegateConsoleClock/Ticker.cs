using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleClock
{
    public class Ticker
    {
        public Ticker()
        {
        }

        private bool done;

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public event Action OnTenths;
        public event Action OnHundredths;
        public event Action OnSeconds;
        public event Action OnMinutes;
        public event Action OnHours;

        public void Run()
        {
            int count = 0;
            while (!done)
            {
                Thread.Sleep(0);

                Interlocked.Increment(ref count);

                OnHundredths?.Invoke();

                if (count % 10 == 0)
                {
                    OnTenths?.Invoke();
                }
                if (count % 100 == 0)
                {
                    OnSeconds?.Invoke();
                }
                if (count % 6000 == 0)
                {
                    OnMinutes?.Invoke();
                }
                if (count % 36000 == 0)
                {
                    OnHours?.Invoke();
                }
            }
        }
    }
}
