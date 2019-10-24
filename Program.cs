using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите первое число ");
                decimal a, b;
                while (!decimal.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Нужно ввести число");
                }
                Console.WriteLine("Введите второе число");
                while (!decimal.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Нужно ввести число");
                }

                Console.WriteLine("Что вы хотите сделать?");
                string choice = Console.ReadLine();
                
                if (choice == "+")
                {
                    decimal c = Addition(a, b);
                    Console.WriteLine($"Если сложить {a} и {b} получится {c}");
                }
                else if (choice == "-")
                {
                    decimal c = Subtraction(a, b);
                    Console.WriteLine($"Если вычесть из {a} {b} получится {c}");
                }
                else if (choice == "/")
                {
                    decimal c = Split(a, b);
                    Console.WriteLine($"Если разделить {a} на {b} получится {c}");
                }
                else if (choice == "*")
                {
                    decimal c = Multiplication(a, b);
                    Console.WriteLine($"Если умножить {a} на {b} получится {c}");
                }
                else
                {
                    Console.WriteLine("Я так не умею, начни заново или введи exit для закрытия");
                    continue;
                }


                static decimal Addition(decimal a, decimal b)
                {
                    decimal c = a + b;
                    return c;
                }
                static decimal Split(decimal a, decimal b)
                {

                    decimal c = a / b;
                    return c;
                }


                static decimal Subtraction(decimal a, decimal b)
                {
                    decimal c = a - b;
                    return c;
                }

                static decimal Multiplication(decimal a, decimal b)
                {
                    decimal c = a * b;
                    return c;

                }


            }
            while (Console.ReadLine() != "exit");

        }
    }
}
