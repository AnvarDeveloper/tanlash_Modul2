using System;
public class haftakunlari
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hafta kunlarini o`zbek tilida kiriting");
        var operation = Console.ReadLine();
        var result = operation switch
        {
            "dushanba"   => "Mondey",
            "seshanba"   => "Tuesday",
            "chorshanba" => "Wendnesday",
            "payshanba"  => "Thursday",
            "juma"       => "Friday",
            "shanba"     => "Sunday",
            "yakshanba"  => "Yesterday",
            "Dushanba"   => "Mondey",
            "Seshanba"   => "Tuesday",
            "Chorshanba" => "Wendnesday",
            "Payshanba"  => "Thursday",
            "Juma"       => "Friday",
            "Shanba"     => "Sunday",
            "Yakshanba"  => "Yesterday",
            _ => "Bunday hafta kuni yo`q",
        };
        Console.WriteLine(result);
    }
}