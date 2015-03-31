﻿namespace Phones
{   using System;

    class GSMCallHistoryTest
    {
        private GSM phone = new GSM("HTC Desire", "HTC");

        public void TestPhone()
        {
            AddCalls();
            DisplayCallInfo();
            Console.WriteLine("Total call price: " + phone.CalculateCallPrice(0.37f));
            RemoveLongestCall();

            Console.WriteLine();
            Console.WriteLine("Longest call has been removed.");
            Console.WriteLine();      
           
            
            DisplayCallInfo();

            phone.ClearCallHistory();
            Console.WriteLine("Call history cleared!");
            Console.WriteLine();

            DisplayCallInfo();
        }

        private void RemoveLongestCall()
        {
            int longestCallID = 0;
            for (int i = 0; i < phone.CallHistory.Count - 1; i++)
            {
                if (phone.CallHistory[i + 1].Duration > phone.CallHistory[i].Duration)
                {
                    longestCallID = i;
                }
            }
            phone.DeleteCall(phone.CallHistory[longestCallID]);
        }

        private void AddCalls()
        {
            phone.AddCalls(new Call("13/02/2014", "13:30", "+359870303212", 12));
            phone.AddCalls(new Call("10/01/2013", "17:43", "+359870303537", 6));
            phone.AddCalls(new Call("17/05/2014", "07:59", "+359870354321", 3));
        }
        private void DisplayCallInfo()
        {
            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                Console.WriteLine("Date: " + phone.CallHistory[i].Date);
                Console.WriteLine("Time: " + phone.CallHistory[i].Time);
                Console.WriteLine("Dialed number: " + phone.CallHistory[i].DialedNumber);
                Console.WriteLine("Duration: {0} minutes.", phone.CallHistory[i].Duration);
                Console.WriteLine();
            }
        }
    }
}
