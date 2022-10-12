/*
Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        Console.WriteLine();

        int m = InputNumbers("Введите m: ");
        int n = InputNumbers("Введите n: ");

        static int A(int a, int b)
        {
            if (a == 0)
                return b + 1;
            else
              if (a != 0 && b == 0)
                return A(a - 1, 1);
            else
                return A(a - 1, A(a, b - 1));
        }
        int num = A(m, n);
        Console.WriteLine($"\nA({m}, {n}) = {num}");
    }
}