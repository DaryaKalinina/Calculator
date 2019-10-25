using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList operations = new ArrayList();
            do
            {
                decimal a, b;
                Console.WriteLine("Что будем делать? Введи арифметический знак, там где \n +  сложение\n -  вычитание\n" +
                    " * умножение\n / деление\n ");
                string choice = Console.ReadLine();
                if (choice == "+")
                {
                    InputNumbers(out a, out b);
                    decimal c = Addition(a, b, operations);
                    Console.WriteLine($"Если сложить {a} и {b} получится {c}");
                }
                else if (choice == "-")
                {
                    InputNumbers(out a, out b);
                    decimal c = Subtraction(a, b, operations);
                    Console.WriteLine($"Если вычесть из {a} {b} получится {c}");
                }
                else if (choice == "/")
                {
                    InputNumbers(out a, out b);
                    decimal c = Split(a, b, operations);
                    Console.WriteLine($"Если разделить {a} на {b} получится {c}");
                }
                else if (choice == "*")
                {
                    InputNumbers(out a, out b);
                    decimal c = Multiplication(a, b, operations);
                    Console.WriteLine($"Если умножить {a} на {b} получится {c}");
                }
                else if (choice == "history")
                {
                    for (int i = 0; i < operations.Count; i++)
                    {
                        Console.WriteLine(operations[i]);
                    }
                    Console.WriteLine("Для продолжения вычислений нажмите Enter");

                }
                else
                {
                    Console.WriteLine("Я так не умею, начни заново или введи exit для закрытия");
                    continue;
                }
            }
            while (Console.ReadLine() != "exit");
            }
        
        
        static void InputNumbers(out decimal a, out decimal b)
        {
            Console.WriteLine("Введите первое число ");

            while (!decimal.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Нужно ввести число");
            }
            Console.WriteLine("Введите второе число");
            while (!decimal.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Нужно ввести число");
            }

        }
        static decimal Addition(decimal a, decimal b, ArrayList operations)
        {
            decimal c = a + b;
            string op = "+";
            AddToHistory(a, b, c, op, operations);
            return c;
        }
        static decimal Split(decimal a, decimal b, ArrayList operations)
        {

            decimal c = a / b;
            string op = "/";
            AddToHistory(a, b, c, op, operations);
            return c;
            
        }

        static String AddToHistory(decimal a, decimal b, decimal c, string op, ArrayList operations)
        {

            History history = new History
            {
                firstNum = a,
                secondNum = b,
                operation = op,
                answer = c
            };

            String new_history = String.Format("{0}{1}{2}={3}", history.firstNum, history.operation, history.secondNum, history.answer);
            operations.Add(new_history);

            return new_history;
        }
        static decimal Subtraction(decimal a, decimal b, ArrayList operations)
        {
            decimal c = a - b;
            string op = "-";
            AddToHistory(a, b, c, op, operations);
            return c;
        }

        static decimal Multiplication(decimal a, decimal b, ArrayList operations)
        {
            decimal c = a * b;
            string op = "*";
            AddToHistory(a, b, c, op, operations);
            return c;            

        }
    }
}
