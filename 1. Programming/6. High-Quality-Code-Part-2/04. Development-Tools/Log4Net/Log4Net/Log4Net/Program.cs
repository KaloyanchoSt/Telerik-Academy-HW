using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]
    
namespace Log4Net
{
    using log4net;
    using log4net.Config;

    public class Log4NetTest
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetTest));

        public static void Main()
        {
            Console.WriteLine("hello");
            XmlConfigurator.Configure();
            var someSpecialValue = 5;
            try
            {
                for (var i = 0; i < 50; i++)
                {
                    if (i == someSpecialValue)
                    {
                        throw new ArgumentException();
                    }

                    Log.Info(i + " error");
                }
            }

            catch
            {
                Log.Error("Oh, no! We have a problem!");
            }
        }
    }
}
