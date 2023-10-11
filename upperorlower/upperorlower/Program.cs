using System;
public class upperorlower
{
    public static void Main(string[] args)
    {
        Console.Write("Katta va kichik harflarni aralashtrib biror so`z kiriting  ");
        string str = Console.ReadLine();
        Console.Write("Biror bir son kiriting  ");
        int x = int.Parse(Console.ReadLine());
        if (x > str.Length)
        {
            Console.WriteLine(str.ToUpper());
        }
        else
        {
            Console.WriteLine(str.ToLower());
        }
    }
}
