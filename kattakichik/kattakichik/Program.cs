using System;
public class kattakichik
{
    public static void Main(string[] args)
    {
        Console.WriteLine("birinchi son x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ikkinchi son y = ");
        int y = Convert.ToInt32(Console.ReadLine());
        if (x > y)
        {
            Console.WriteLine("x greater is than y");
        }
        else if (x < y)
        {
            Console.WriteLine("x is less than y");
        }
        else if (x == y)
        {
            Console.WriteLine("x is equal to y");
        }
        else
        {
            Console.WriteLine("x and y are not comparable");
        }
    }
}