using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task104.Helper
{
    internal static class ConvertHelper
    {
        public static DateTime ConvertStringToDateTime(string? stringDate)
        {
            DateTime parsedDate;

            if (DateTime.TryParse(stringDate, out parsedDate))
            {
                return parsedDate;
            }
            else throw new Exception("Не удалось преобразовать строку в дату.");
        }
    }
}
