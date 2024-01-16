using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task104.Models
{
    internal class Calendar
    {
        private static List<Calendar> s_CalendarEvents = [];

        public string? TitleEvent { get; set; }

        public DateTime DateEvent { get; set; }

        public string? DescriptionEvent { get; set; }

        public Calendar() { }

        private Calendar(string? titleEvent, DateTime dateEvent) : this()
        {
            TitleEvent = titleEvent;
            DateEvent = dateEvent;
        }

        private Calendar(string? titleEvent, DateTime dateEvent, string? descriptionEvent) :
            this(titleEvent, dateEvent)
        {
            DescriptionEvent = descriptionEvent;
        }

        public void Add()
        {
            Console.Write("Введите название события: ");
            TitleEvent = Console.ReadLine().Trim();
            Console.Write("Введите дату события: ");
            //DateEvent = DateTime.Parse(Console.ReadLine().Trim());
            DateEvent = DateTime.Now;
            Console.Write("Введите описание события: ");
            DescriptionEvent = Console.ReadLine().Trim();
            Calendar newDateEvent = new Calendar(TitleEvent, DateEvent, DescriptionEvent);
            s_CalendarEvents.Add(newDateEvent);
        }
        /*
        public List<Calendar> GetCalendarEvents()
        {
            return s_CalendarEvents;
        }

        public event EventHandler<Event> TodayHappening;

        public void Today()
        {
            OnTodayHappening(new Event());
        }

        public void OnTodayHappening(Event e)
        {
            TodayHappening?.Invoke(this, e);
        }
        */
    }
}
