using System;

class Program
{
    
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        int i = 2;
        while (i <= Math.Sqrt(n))
        {
            if (n % i == 0)
                return false;

            i++;
        }

        return true;
    }

   
    static bool IsPerfectNumber(int n)
    {
        if (n <= 1)
            return false;

        int sum = 1;
        int i = 2;

        while (i <= n / 2)
        {
            if (n % i == 0)
                sum += i;

            i++;
        }

        return sum == n;
    }

    static void Main()
    {
        Console.Write("Nhap N: ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("N phai la so nguyen duong!");
            return;
        }

        
        if (IsPrime(N))
            Console.WriteLine($"{N} la So nguyen to!");
        else
            Console.WriteLine($"{N} KHONG la So nguyen to.");

        
        if (IsPerfectNumber(N))
            Console.WriteLine($"{N} la So hoan hao!");
        else
            Console.WriteLine($"{N} KHONG la So hoan hao.");

        
        Console.Write($"Day Fibonacci {N} so: ");

        int f1 = 0;
        int f2 = 1;

        for (int i = 1; i <= N; i++)
        {
            if (i == 1)
            {
                Console.Write(f1);
            }
            else if (i == 2)
            {
                Console.Write(", " + f2);
            }
            else
            {
                int f3 = f1 + f2;
                Console.Write(", " + f3);

                f1 = f2;
                f2 = f3;
            }
        }

        Console.WriteLine();
    }
}
