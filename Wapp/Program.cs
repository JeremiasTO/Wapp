using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Wapp
{
    class Program
    {
        public static int secondsCount = 0;
       public static Timer aTmr = new Timer(2000);
        static void Main(string[] args)
        {
            aTmr.Elapsed += ATmr_Elapsed;
            aTmr.Enabled = true;
            aTmr.AutoReset = true;
            aTmr.Start();
            aTmr.Stop();
            Console.ReadKey();
        }
        private static void ATmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            secondsCount++;
            Console.WriteLine(secondsCount + "Seconds");
        }
    }
}
