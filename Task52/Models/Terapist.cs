﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task52.Models
{
    internal class Terapist : Doctor
    {
        public override void Heal() => Console.WriteLine("Лечит терапевт...");
    }
}
