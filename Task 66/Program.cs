/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine($"\n");
        int m = InputNumbers("Введите m: ");
        int n = InputNumbers("Введите n: ");


        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        int SumRec(int n)
        {
            if (m > 0)
            {
                if (n == m) return m;
                else return n + SumRec(n - 1);
            }
            else if (n == 0) return 0;
            else return n + SumRec(n - 1);
        }
        Console.WriteLine($"Сумма найденная через рекурсию: {SumRec(n)}");
    }
}