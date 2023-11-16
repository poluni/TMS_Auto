using System;
namespace TypesAndOpreators;

    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            switch (x)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                default:
                    Console.WriteLine("Не соответствует условиям");
                    break;
            }

            string name = "Alex";

            switch (name)
            {
                case "Alex":
                    Console.WriteLine("Alex");
                    break;
                case "Tom":
                    Console.WriteLine("Tom");
                    break;
            }

            string name1 = "Alex";

            switch (name1.Equals("Alex"))
            {
                case true:
                    Console.WriteLine("Alex");
                    break;
                case false:
                    Console.WriteLine("Tom");
                    break;
            }

            Console.WriteLine(DoOperation(1));
            Console.WriteLine(DoOperation1(2));
            Console.WriteLine(DoOperation2(3));


            int DoOperation(int x)
            {
                switch (x)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    default: return 0;
                }
            }

            int DoOperation1(int x)
            {
                int result = x switch
                {
                    1 => 1,
                    2 => 2,
                    _ => 0
                };

                return result;
            }

            int DoOperation2(int x) => x switch
            {
                1 => 1,
                2 => 2,
                _ => 0
            };
        }
    }
