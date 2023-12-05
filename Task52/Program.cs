using Task52.Models;

namespace Task52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreatmentPlan treatmanPlanId = new TreatmentPlan();
            treatmanPlanId.TreatmentPlanId = 2;
            Patient patient = new(treatmanPlanId.TreatmentPlanId);
            patient.AssignDoctor(treatmanPlanId.TreatmentPlanId);
        }
    }
}
