namespace Phones
{
    using System;

    public class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType? batteryType;

        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, int? hoursTalked, int? hoursIdle, BatteryType batteryType)
            : this(model)
        {
            this.hoursTalk = hoursTalked;
            this.hoursIdle = hoursIdle;
            this.batteryType = batteryType;
        }

        public string Model
        {
            get
            {
                if (this.model == string.Empty)
                {
                    throw new ArgumentNullException("There is no battery model.");
                }
                return this.model;
            }
        }
        public int? HoursTalk
        {
            get
            {
                if (this.hoursTalk == null)
                {
                    throw new ArgumentNullException("Hours talked not set.");
                }
                return this.hoursTalk;
            }
        }
        public int? HoursIdle
        {
            get
            {
                if (this.hoursIdle == null)
                {
                    throw new ArgumentNullException("Hours idle not set.");
                }
                return this.hoursIdle;
            }
        }
        public BatteryType? BatteryType
        {
            get
            {
                if (this.batteryType == null)
                {
                    throw new ArgumentNullException("There is no battery type.");
                }
                return this.batteryType;
            }
        }
        
    }
}
