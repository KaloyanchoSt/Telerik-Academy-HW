using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Components
{
    public class Battery
    {
        private string batteryModel;
        private float hoursTalk;
        private float hoursIdle;
        private BatteryType batteryType;

        public Battery(string batteryModel)
        {
            this.BatteryModel = batteryModel;
        }

        public Battery(string batteryModel, BatteryType batteryType)
            : this(batteryModel)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string batteryModel, BatteryType batteryType, float hoursTalk, float hoursIdle)
            : this(batteryModel, batteryType)
        {
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;          
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery model cannot be null or empty!");
                }

                this.batteryModel = value;
            }
        }

        public float HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                this.hoursTalk = value;
            }
        }

        public float HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                this.hoursIdle = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("GSM Battery Model: {0}, Hours talked: {1}, Hours idle: {2}, Battery type: {3}", this.BatteryModel, this.HoursTalk, this.HoursIdle, this.BatteryType));

            return result.ToString();
        }
    }
}
