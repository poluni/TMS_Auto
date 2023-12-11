using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task71.CustomExceptions;

namespace Task71
{
    internal class RegistrationData
    {
        public RegistrationData(string login, string password, string confirmPassword)
        {
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        private static string? Login { get; set; }

        private static string? Password { get; set; }

        private static string? ConfirmPassword { get; set; }

        public static bool ValidateRegistrationData(string login, string password, string confirmPassword)
        {
            bool loginIsValid = false;
            bool passwordIsValid = false;

            try
            {
                if (login.Length < 20
                    && !login.Contains(" ")
                    && !string.IsNullOrWhiteSpace(login))
                {
                    Login = login;
                    loginIsValid = true;
                }
                else throw new WrongLoginException();
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine($"Ошибка ввода логина: {ex.GetType()} {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} {ex.Message}");
            }

            try
            {
                if (password.Length < 20
                    && !password.Contains(" ")
                    && new Regex("[0-9]").IsMatch(password)
                    && !string.IsNullOrWhiteSpace(password)
                    && password == confirmPassword)
                {
                    Password = password;
                    passwordIsValid = true;
                }
                else throw new WrongPasswordException();
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine($"Ошибка ввода пароля: {ex.GetType()} {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} {ex.Message}");
            }
            return loginIsValid && passwordIsValid;
        }
    }
}
