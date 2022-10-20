using System.Runtime.InteropServices;

namespace Diary;
internal class Program
{

    static void Main()
    {


        DateOnly day = new(2022, 10, 19);
        int position = 2;
        Console.WriteLine(day);
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Escape)
        {
            if (position == 1 || key.Key == ConsoleKey.DownArrow)
                position++;
            if (key.Key == ConsoleKey.UpArrow || position == 3)
                position--;
            if (key.Key == ConsoleKey.LeftArrow)
                day = day.AddDays(-1);
            if (key.Key == ConsoleKey.RightArrow)
                day = day.AddDays(+1);
            Console.Clear();
            Console.WriteLine("Выбрана дата: " + day);
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            key = Console.ReadKey();
            Bebra();
        }
    }
    static void Bebra()
    {
        DateTime day = new(2022, 10, 19);
        int position = 2;
        day.ToString();
        day = day.Date;
        day.ToString();
        Console.WriteLine(day);
        ConsoleKeyInfo key = Console.ReadKey();
        Zametki zametka1 = new Zametki
        {
            name = "1. Идти на пары",
            description = "Учеба начинается со 2 пары до 5.",
            DateOfZametki = day
        };
        Console.WriteLine(zametka1.name);
    }
}
    
           