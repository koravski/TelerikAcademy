namespace Phones
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

      
        private static GSM iPhone4S = new GSM("4S", "Apple", 899, "Me", 
                                      new Battery("Apple", 2000, 1, BatteryType.Li_Ion),
                                      new Display(5, 16000000));


        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer)
        {
            this.price = price;
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get
            {
                if (this.model == string.Empty)
                {
                    throw new ArgumentNullException("There is no model.");
                }
                return this.model;
            }
        }

        public string Manifacture
        {
            get 
            {
                if (this.manufacturer == string.Empty)
                {
                    throw new ArgumentException("There is no manifacture.");
                }
                return this.manufacturer;
            }
        }

        public decimal? Price
        {
            get 
            {
                if (price == null)
                {
                    throw new ArgumentException("There is no price.");
                }
                return this.price;

            }
        }

        public string Owner
        {
            get 
            {
                if (this.owner==string.Empty)
                {
                    throw new ArgumentException("There is no owner.");
                }
                return this.owner;
            }
        }

        public Battery Battery
        {
            get
            {
                if (this.battery == null)
                {
                    throw new ArgumentNullException("There is no battery.");
                }
                return this.battery;
            }
        }
        public Display Display
        {
            get
            {
                if (this.display == null)
                {
                    throw new ArgumentNullException("There is no display.");
                }
                return this.display;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                if (iPhone4S == null)
                {
                    throw new ArgumentNullException("No iPhone 4S!");
                }
                return iPhone4S;
            }
        }

        public override string ToString()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine("Phone Characteristics:");
            information.AppendLine("Model: " + this.model);
            information.AppendLine("Manufacturer: " + this.manufacturer);
            information.AppendLine("Price: " + this.price);
            information.AppendLine("Owner: " + this.owner);
            information.AppendLine("Battery: " + this.battery.Model);
            information.AppendLine("Display: " + this.display.ScreenSize);

            return information.ToString();
        }


        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }
        public float CalculateCallPrice(float pricePerMinute)
        {
            float price = 0;

            uint totalTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalTime += callHistory[i].Duration;
            }

            price = pricePerMinute * totalTime;

            return price;
        }
    }
}
