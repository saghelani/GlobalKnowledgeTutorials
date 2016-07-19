using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleClock
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Ticker ticker = new Ticker();

            SecondClock clock = new SecondClock(0, 0, ConsoleColor.DarkYellow, ticker);
            SecondClock clock2 = new SecondClock(0, 1, ConsoleColor.Yellow, ticker);
            TenthSecondClock clock3 = new TenthSecondClock(0, 2, ConsoleColor.Green);
            HundredthSecondClock clock4 = new HundredthSecondClock(0, 3, ConsoleColor.Red);

            ticker.OnTenths += clock3.TenthSecond;
            ticker.OnHundredths += clock4.HundredthSecond;

            Thread thread = new Thread(ticker.Run);
            thread.Start();

            Console.ReadLine();

            ticker.Done = true;
            thread.Join();
        }
    }
}

