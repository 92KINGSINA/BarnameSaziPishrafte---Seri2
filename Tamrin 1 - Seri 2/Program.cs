using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        if (n > m)
        {
            int temp = n;
            n = m;
            m = temp;
        }

        Console.WriteLine($"Prime numbers between {n} and {m}:");
        for (int i = n; i <= m; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
