using System;
using System.Text.RegularExpressions;

namespace fourthHW
{
    internal class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод ФИО");
            Console.WriteLine(GetFullName("Журавлева", "Василиса", "Марковна"));
            Console.WriteLine(GetFullName("Ушакова", "Екатерина", "Алексеевна"));
            Console.WriteLine(GetFullName("Малышева", "Сафия", "Тихоновна"));
            Console.WriteLine(GetFullName("Майоров", "Артём", "Эминович"));
            Console.WriteLine("____________________________________");

            Console.WriteLine("Сумма чисел в строке");
            Console.Write("Введите строку с числами через запятую: ");
            string numbersString = Console.ReadLine();
            Console.WriteLine($"Сумма чисел в строке: {StringNubmerSumm(numbersString).ToString()}");
            Console.WriteLine("____________________________________");

            Console.WriteLine("Определение времени года");
            int monthNumber = ParseString("Введите номер месяца: ");
            Console.WriteLine($"Месяц {monthNumber} это {GetSeasonByNumber(monthNumber)}");
            Console.WriteLine("____________________________________");

            Console.WriteLine("Определение числа Фиббоначи");
            int fibbonachiNumber = ParseString("Введите порядковый номер члена последовательности: ");
            Console.WriteLine($"{fibbonachiNumber}-й член последовательности = {GetFibbonachiNumber(fibbonachiNumber)}");
            Console.WriteLine("____________________________________");

            Console.ReadKey();

        }

        protected static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return ($" {firstName} {lastName} {patronymic}");
        }

        protected static int StringNubmerSumm(string numbersString)
        {
            MatchCollection matches = Regex.Matches(numbersString, @"-?\d+(?:\.\d+)?");
            int sumNumbers = 0;
            foreach (var match in matches)
            {
                sumNumbers += Convert.ToInt32(match.ToString());
            }
            return sumNumbers;
        }

        protected static string GetSeasonByNumber(int month)
        {
            string result = string.Empty;
            switch (month)
            {
                case 1: result = Seasons.Winter.ToString(); break;
                case 2: result = Seasons.Winter.ToString(); break;
                case 3: result = Seasons.Spring.ToString(); break;
                case 4: result = Seasons.Spring.ToString(); break;
                case 5: result = Seasons.Spring.ToString(); break;
                case 6: result = Seasons.Summer.ToString(); break;
                case 7: result = Seasons.Summer.ToString(); break;
                case 8: result = Seasons.Summer.ToString(); break;
                case 9: result = Seasons.Autumn.ToString(); break;
                case 10: result = Seasons.Autumn.ToString(); break;
                case 11: result = Seasons.Autumn.ToString(); break;
                case 12: result = Seasons.Winter.ToString(); break;
                default: result = "Ошибка: введите число от 1 до 12"; break;
            }
            return result;
        }

        protected static int GetFibbonachiNumber(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return GetFibbonachiNumber(num - 2) + GetFibbonachiNumber(num - 1);
            }
        }

        protected static int ParseString(string messageString)
        {
            bool isInt = true;
            int result = 0;

            do
            {
                Console.Write(messageString);
                isInt = Int32.TryParse(Console.ReadLine(), out result);
                if (!isInt)
                {
                    Console.WriteLine("Ошибка ввода, введите целое число.");
                }
            } while (!isInt);
            return result;
        }
    }
}