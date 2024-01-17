using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task104.Helper;

namespace Task104.Models
{
    public class Calendar
    {
        private static List<Event> s_CalendarEvents = [];

        private static List<Event> s_TodaysEvents = [];

        public void Add()
        {
            Event eventDate = new();
            Console.Write("Введите название события: ");
            eventDate.Title = Console.ReadLine().Trim();
            Console.Write("Введите дату события в формате ГГГГ-ММ-ДД чч:мм:сс : ");
            eventDate.Date = ConvertHelper.ConvertStringToDateTime(Console.ReadLine().Trim());
            Console.Write("Введите описание события: ");
            eventDate.Description = Console.ReadLine().Trim();
            s_CalendarEvents.Add(eventDate);
        }

        public List<Event> GetCalendarEvents()
        {
            return s_CalendarEvents;
        }

        public List<Event> GetTodaysEvents()
        {
            foreach (var date in s_CalendarEvents)
            {
                int res = DateTime.Compare(date.Date, DateTime.Now);
                if (res >= 0)
                {
                    s_TodaysEvents.Add(date);
                    OnHappenTonight(date);
                }
            }
            return s_TodaysEvents;
        }

        public event EventHandler<Event> HappenTonight;

        public void OnHappenTonight(Event e)
        {
            HappenTonight?.Invoke(this, e);
        }
    }
}
