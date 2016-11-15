namespace MobilePhone.Tests
{
    using System;

    using MobilePhone.Components;

    public class GSMCallHistoryTest
    {

        public static void Main()
        {
            Battery lionBattery = new Battery("Lion", BatteryType.LiIon, 49, 8);
            Display bigDisplay = new Display(4.7, 16000000);

            GSM phone = new GSM("Galaxy", "Samsung", 400.78M, "Pesho", lionBattery, bigDisplay);

            Call currentCall = new Call(DateTime.Now.AddDays(6), "0888888888", 156);
            phone.AddCall(currentCall);

            currentCall = new Call(DateTime.Now, "0777777777", 456);
            phone.AddCall(currentCall);

            currentCall = new Call(DateTime.Now.AddHours(100), "0989565690", 345);
            phone.AddCall(currentCall);

            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine("Call date:{0} Phone number:{1} Duration:{2} seconds", call.Date, call.DialledPhoneNumber, call.DurationInSeconds);
            }


            Console.WriteLine("Total call price is: ${0}", phone.CalculateTotalCallPrice());

            long? maxCallDuration = long.MinValue;
            Call longestCall = new Call(DateTime.Now, "00000000", 0);

            foreach (var currentCallToCheck in phone.CallHistory)
            {
                if (currentCallToCheck.DurationInSeconds > maxCallDuration)
                {
                    maxCallDuration = currentCallToCheck.DurationInSeconds;
                    longestCall = currentCallToCheck;
                }
            }

            phone.RemoveCall(longestCall);

            Console.WriteLine("Total price without longest call: $" + phone.CalculateTotalCallPrice());

            phone.ClaerCallHistory();

            if (phone.CallHistory.Count == 0)
            {
                Console.WriteLine("Calls cleared!");
            }

        }
    }
}
