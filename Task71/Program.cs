// Задача "Обработка исключений". Задача 1.

namespace Task71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistrationData.ValidateRegistrationData(login: "yula15", password: "op 5gh_m", confirmPassword: "op5gh_m");
            //RegistrationData.ValidateRegistrationData(login: "yula15", password: "opgh_m", confirmPassword: "op5gh_m");
            //RegistrationData.ValidateRegistrationData(login: "yula15", password: "op5gh_m", confirmPassword: "op5gh_m");
        }
    }
}
