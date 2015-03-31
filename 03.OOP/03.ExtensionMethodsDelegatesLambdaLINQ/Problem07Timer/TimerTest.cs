/*Problem 7. Timer

    Using delegates write a class Timer that can execute certain method at each t seconds.
*/
using System;
using System.Threading;

namespace Problem07Timer
{
    class TimerTest
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(5, 2, delegate() { Console.WriteLine("tick"); });
            Thread tThread = new Thread(new ThreadStart(t.Run));
            tThread.Start();
        }
    }
}
