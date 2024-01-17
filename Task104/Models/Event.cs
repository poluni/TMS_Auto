using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task104.Helper;

namespace Task104.Models
{
    public class Event : EventArgs
    {
        private string title;

        public string Title
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

        public DateTime Date { get; set; }

        public string? Description { get; set; }
    }
}
