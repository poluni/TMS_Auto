namespace Task1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число (ввод дробных чисел с разделителем \",\" ): ");
        decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Знак операции (+, - , * , /): ");
        string operationSign = Console.ReadLine();
        Console.Write("Введите второе число (ввод дробных чисел с разделителем \",\" ): ");
        decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
        decimal result = DoOperation(firstNumber, operationSign, secondNumber);
        if (!divisionByZero(operationSign, secondNumber))
        {
            Console.WriteLine($"{firstNumber} {operationSign} {secondNumber} = {result}");
        }
        else
            Console.WriteLine("Ошибка деления на нуль. Введите делитель отличный от нуля.");

        decimal DoOperation(decimal firstNumber, string operationSign, decimal secondNumber)
        {
            decimal result = operationSign switch
            {
                "+" => DoSum(firstNumber, secondNumber),
                "-" => DoSubstract(firstNumber, secondNumber),
                "*" => DoMultiply(firstNumber, secondNumber),
                "/" => DoDivision(firstNumber, secondNumber),
            };
            return result;
        }

        decimal DoSum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        decimal DoSubstract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        decimal DoMultiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        decimal DoDivision(decimal firstNumber, decimal secondNumber)
        {
            decimal divResult = 0.0m;
            if (!divisionByZero("/", secondNumber))
            {
                divResult = firstNumber / secondNumber;
            }
            return divResult;
        }

        bool divisionByZero(string operationSign, decimal secondNumber)
        {
            return secondNumber == 0 && operationSign.Equals("/") ? true : false;
        }
    }
}