using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// this is to watch the config file for 
[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace Log4NetStart
{
    class Program
    {
        // this tells what class you are in when the logging accuared 
        private static readonly log4net.ILog log = LogHelper.GetLogger(); //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            
        static void Main(string[] args)
        {
            log.Debug("Developer: Tuturial run");
            log.Info("Oil change needed");
            log.Warn("Car is geting hot");

            var i = 0;
            var str = "hello my name is brandon";

            log.Info(str);

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {

                log.Error("Developer, We have a problem !! ", ex);
            }

            log.Fatal("Water Pump Exploded!!! ");


            Console.ReadLine();

        }
    }
}
