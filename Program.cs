using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            cons objTime = new cons(2000,3,7,14,50,20);

            // mengambil nilai dengan property
            Console.WriteLine("Year : {0}", objTime.Year.ToString());
            Console.WriteLine("Month : {0}", objTime.Month.ToString());
            Console.WriteLine("Date : {0}", objTime.Date);
            Console.WriteLine("Hour : {0}", objTime.Hour);
            Console.WriteLine("Minute : {0}", objTime.Minute);
            Console.WriteLine("Second : {0}", objTime.Second);
            Console.ReadKey();
        }
        
    }
}
