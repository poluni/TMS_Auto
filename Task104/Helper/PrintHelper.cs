using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task104.Models;

namespace Task104.Helper
{
    internal static class PrintHelper
    {
        public static void PrintCalendar(List<Calendar> dates)
        {
            foreach (var date in dates)
            {
                Console.WriteLine($"{date.TitleEvent} {date.DateEvent} {date.DescriptionEvent}");
            }
            Console.WriteLine();
        }
    }
}
