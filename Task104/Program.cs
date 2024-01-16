using Task104.Models;
using Task104.Helper;

namespace Task104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendar calendarEvents = new();
            calendarEvents.Add();
            calendarEvents.Add();
            PrintHelper.PrintCalendar(calendarEvents.GetCalendarEvents());

            PrintHelper.PrintCalendar(calendarEvents.GetTodaysEvents());
        }
    }
}
