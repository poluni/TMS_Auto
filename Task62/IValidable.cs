using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task62
{
    internal interface IValidable
    {
        bool IsValid(DateTime expiriationDate);
    }
}
