using System;
using System.Globalization;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

           DateTime date1 = new DateTime(2008, 8, 29, 19, 27, 15);

Console.WriteLine(date1.ToString("d, M",
                  CultureInfo.InvariantCulture));

Console.WriteLine(date1.ToString("d MMMM",
                  CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(date1.ToString("d MMMM",
                  CultureInfo.CreateSpecificCulture("es-MX")));

            }
    }
}
