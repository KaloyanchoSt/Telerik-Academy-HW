namespace MobilePhone.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        public static GSM iPhone4S = new GSM("Iphone6Splus", "Apple", 599.99M, "Gosho",
            new Battery("2750mAh", BatteryType.LiIon, 384f, 24f),
            new Display(5.5, 16000000));
        public const decimal pricePerMinute = 0.37m;

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display) : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("GSM model cannot be null or empty!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("GSM manufacturer cannot be null or empty!");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("GSM price cannot be less than 0!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

            set
            {
                this.callHistory = value;
            }
        }

        public GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            if (!this.CallHistory.Contains(call))
            {
                throw new ArgumentException("Call does not exist");
            }

            this.CallHistory.Remove(call);
        }

        public void ClaerCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateTotalCallPrice()
        {
            decimal result = 0;

            foreach (var call in this.CallHistory)
            {
                result += (call.DurationInSeconds / 60) * pricePerMinute;
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("GSM Model is: {0}", this.Model));
            result.AppendLine(string.Format("GSM Manufacturer is: {0}", this.Manufacturer));
            result.AppendLine(string.Format("GSM Price is: ${0}", this.Price));
            result.AppendLine(string.Format("GSM Owner is: {0}", this.Owner));
            result.AppendLine(this.Battery.ToString());
            result.AppendLine(this.Display.ToString());

            return result.ToString();
        }
    }
}
