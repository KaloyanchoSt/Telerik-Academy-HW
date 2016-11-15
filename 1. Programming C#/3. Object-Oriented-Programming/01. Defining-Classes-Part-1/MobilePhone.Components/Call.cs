namespace MobilePhone.Components
{
    using System;

    public class Call
    {
        private DateTime date;
        private string dialledPhoneNumber;
        private int durationInSeconds;

        public Call(DateTime date)
        {
            this.Date = date;
        }

        public Call(DateTime date, string dialledPhoneNumber, int durationInSeconds) : this(date)
        {
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.DurationInSeconds = durationInSeconds;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }

            set
            {
                this.dialledPhoneNumber = value;
            }
        }

        public int DurationInSeconds
        {
            get
            {
                return this.durationInSeconds;
            }

            set
            {
                this.durationInSeconds = value;
            }
        }

    }
}
