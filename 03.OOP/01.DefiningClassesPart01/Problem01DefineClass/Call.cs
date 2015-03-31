namespace Phones
{   
    using System;
    using System.Text;
    class Call
    {
        

        private string date;
        private string time;
        private string dialedNumber;
        private uint duration;


        public Call (string date, string time, string dialedNumber, uint duration)
        {
            this.date = date;
            this.time = time;
            this.dialedNumber = dialedNumber;
            this.duration = duration;

        }

        public string Date
        {
            get { return this.date; }
        }
        public string Time
        {
            get { return this.time; }
        }
        public string DialedNumber
        {
            get { return this.dialedNumber; }
        }
        public uint Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();

            printer.AppendLine("Date: " + date);
            printer.AppendLine("Time: " + time);
            printer.AppendLine("Dialed number: " + dialedNumber);
            printer.AppendLine("Duration: " + duration);

            return printer.ToString();
        }

    }
}
