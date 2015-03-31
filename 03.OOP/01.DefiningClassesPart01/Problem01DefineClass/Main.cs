using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    class Phones
    {
        static void Main()
        {
            GSMTest tester = new GSMTest();
            tester.PrintPhones();

            GSMCallHistoryTest historyTester = new GSMCallHistoryTest();
            historyTester.TestPhone();
        }
    }
}
