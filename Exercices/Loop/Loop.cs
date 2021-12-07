using System;
using Microsoft.VisualBasic;

namespace Exercice
{
    public class Loop
    {
        public static void PrintNaturals(int n)
        {
                for (int i = 1; i < n; i++)
                {
                        Console.Write(i + " ");
                }
                Console.Write(n);
        }

        public static void PrintPrimes(int n)
        {
                if (n == 1 || n == 0)
                {
                        Console.WriteLine(false);
                }
                else
                {
                        for (int a = 2; a <= n / 2; a++)
                        {
                                if (n % a == 0)
                                {
                                        Console.WriteLine(false);
                                }

                        }
                        Console.WriteLine(true);
                }
        }

        public static long Fibonacci(long n)
        {
                long fibo1 = 1;
                long fibo2 = 1;
                long fi = 1;
                for (int i = 2; i > n; i++)
                { 
                        fi = fibo1 + fibo2;
                        fibo2 = fibo1;
                        fibo1 = fi;
                }
                Console.WriteLine(fi);
                return fi;
        }

        private static long Factorial(long n)
        { 
                long res = n;
                for (int i = 0; i == n; i++)
                {
                        res = res * (n - 1);
                }
                Console.WriteLine(res);
                return res;
        }

        public static void PrintStrong(int n)
        { 
                for (int i = 1; i <= n; i += 1)
                {
                        long sum = 0;
                        if(Factorial(i)!=i)
                                continue;
                        else
                        {
                                do
                                {
                                        sum = sum + Factorial(i % 10);
                                        i /= 10;
                                } while (i != 0);
                        }
                        if (sum != i)
                                continue;
                        Console.Write(i + " "); 
                }
        }

        public static float Abs(float n)
        {
                if (n < 0)
                {
                        return -n;
                }
                return n;
        }

        public static float Sqrt(float n)
        {
                // TODO
                return 0;
        }

        public static long Power(long a, long b)
        {
                // TODO
                return 0;
        }

        public static void PrintTree(int n)
        {
                // TODO
        }

        public static int Syracuse(int n)
        {
                // TODO
                return 0;
        }

    }
}