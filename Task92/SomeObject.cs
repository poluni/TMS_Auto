using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task92
{
    internal class SomeObject
    {
        private Guid id;

        public SomeObject() => this.id = Guid.NewGuid();
    }
}
