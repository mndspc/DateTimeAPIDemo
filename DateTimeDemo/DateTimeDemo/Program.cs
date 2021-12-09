using System;

namespace DateTimeDemo
{
    //  This program demo. how to work with DateTime struct.
    class Program
    {
        static void Main(string[] args)
        {
            //  How to construct DateTime Object
            DateTime dateTime = new DateTime(2021, 05, 20);
            Console.WriteLine($"Date is:{dateTime} Year={dateTime.Year}\t Month={dateTime.Month} Day={dateTime.Day}");
            Console.WriteLine($"After formatting Date:{dateTime.ToString("dd-MMM-yyyy")}");

            //  How to get system date and time
            Console.WriteLine($"System date and time is:{DateTime.Now.ToString("dd-MMM-yy")} Year={DateTime.Now.Year} Month={DateTime.Now.Month} Day={DateTime.Now.Day}");

            //  How to convert string to DateTime
            var dateString = "09/28/2021";
            DateTime dateTime1;
            DateTime.TryParse(dateString, out dateTime1);
            //var dateTIme2 = DateTime.Parse(dateString);
            Console.WriteLine($"After converting string into a DateTime:{dateTime1.ToString("dd-MMM-yy")}");

            //  How to calculate difference between two datetime.
            DateTime dateTimeFirst = new DateTime(2021,09,28);
            DateTime dateTimeSecond = new DateTime(2021, 08, 28);

            Console.WriteLine($"After sub Date2 from Date1:{dateTimeFirst-dateTimeSecond}");

            TimeSpan timeSpan = new TimeSpan(24, 0, 0);
            Console.WriteLine($"After adding 24 hrs new date is:{(dateTimeFirst+timeSpan).ToString("dd-MMM-yy")}");
            Console.WriteLine($"After adding 10 days:{dateTimeSecond.AddDays(10).ToString("dd-MMM-yy")}");
            Console.ReadLine();
        }
    }
}
