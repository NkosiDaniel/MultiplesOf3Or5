﻿
public class Multiples
{
    private static int sum;

    static void Main(string[] args)
    {
        int baseCase = 0;
        SumOfMultiples(baseCase);
    }

    private static void SumOfMultiples (int num)
    {
        if(num % 3 == 0 || num % 5 == 0)
        {
            sum += num;
        }
        if(num == 999)
        {
            Console.WriteLine(sum);
            return;
        }
        SumOfMultiples(num + 1);
    }
}
