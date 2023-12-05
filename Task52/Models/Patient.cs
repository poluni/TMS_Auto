using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task52.Models
{
    internal class Patient
    {
        public Patient(int treatmanPlanId)
        {
            this.CardNumber = string.Concat(new Random().Next(1, 10).ToString());
            this.TreatmentPlanId = treatmanPlanId;
        }

        public int TreatmentPlanId { get; set; }

        public string CardNumber { get; set; }

        public void AssignDoctor(int TreatmentPlanId)
        {
            switch (TreatmentPlanId)
            {
                case 1:
                    {
                        Surgeon surgeon = new Surgeon();
                        surgeon.Heal();
                        break;
                    }
                case 2:
                    {
                        Dantist dantist = new Dantist();
                        dantist.Heal();
                        break;
                    }
                default:
                    {
                        Terapist terapist = new Terapist();
                        terapist.Heal();
                        break;
                    }
            }
        }
    }
}
