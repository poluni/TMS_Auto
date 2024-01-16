using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task104.Helper;

namespace Task104.Models
{
    internal class Calendar
    {
        private string title;

        private static List<Calendar> s_CalendarEvents = [];

        private static List<Calendar> s_TodaysEvents = [];

        public string TitleEvent 
        {
            get 
            { 
                return title; 
            }
            set
            {
                if (value != null) title = value;
                else throw new Exception("Название события не заполнено.");
            }
        }

        public DateTime DateEvent { get; set; }

        public string? DescriptionEvent { get; set; }

        public Calendar() { }

        private Calendar(string titleEvent, DateTime dateEvent) : this()
        {
            TitleEvent = titleEvent;
            DateEvent = dateEvent;
        }

        private Calendar(string titleEvent, DateTime dateEvent, string? descriptionEvent) :
            this(titleEvent, dateEvent)
        {
            DescriptionEvent = descriptionEvent;
        }

        public void Add()
        {
            Console.Write("Введите название события: ");
            TitleEvent = Console.ReadLine().Trim();
            Console.Write("Введите дату события в формате ГГГГ-ММ-ДД чч:мм:сс : ");
            DateEvent = ConvertHelper.ConvertStringToDateTime(Console.ReadLine().Trim());
            Console.Write("Введите описание события: ");
            DescriptionEvent = Console.ReadLine().Trim();
            Calendar newDateEvent = new Calendar(TitleEvent, DateEvent, DescriptionEvent);
            s_CalendarEvents.Add(newDateEvent);
        }
        
        public List<Calendar> GetCalendarEvents()
        {
            return s_CalendarEvents;
        }

        public List<Calendar> GetTodaysEvents()
        {
            foreach (var date in s_CalendarEvents)
            {
                int res = DateTime.Compare(date.DateEvent, DateTime.Now);
                if (res >= 0)
                {
                    s_TodaysEvents.Add(date);
                }
            }
            return s_TodaysEvents;
        }

        /*
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
