/*Problem 8.* Events

    Read in MSDN about the keyword event in C# and how to publish events.
    Re-implement the above using .NET events and following the best practices.
*/
using System;

namespace Problem08Events
{
    public class TimeElapsedEventArgs : EventArgs
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(2);
            t.IntervalPassed += Tick;
            t.Run();
        }

        static void Tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");
        }
    }
}
