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

            calendarEvents.HappenTonight += Notify;
            calendarEvents.GetTodaysEvents();
        }

        public static void Notify(object sender, Event e) =>
            Console.WriteLine($"Уведомление о событии {e.Title} {e.Date} {e.Description} отправлено.");
    }
}
