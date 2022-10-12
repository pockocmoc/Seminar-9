/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine($"\n");
        int n = InputNumbers("Введите n: ");

        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        string NumRec(int a, int b)
        {
            if (a <= b) return NumRec(a + 1, b) + $"{a} ";
            else return string.Empty;
        }

        Console.WriteLine(NumRec(1, n));
    }
}