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
        }
    }
    static void Main2()
    {
        Zametka1();
        foreach (Zametka pos in menuList)
        {
            Console.WriteLine("Название: " + pos.Name);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Описание: " + pos.Description);
            Console.WriteLine("Дата: " + pos.date);
        }
        foreach (Zametka pos in menuList)
        {
            Console.WriteLine("# " + pos.Name);
        }
    }
    static void Zametka1()
    {
        Zametka number1 = new();
        number1.Name = "Пойти поспать";
        number1.Description = "я очень устал из-за прошлых заданий, поэтому лучше отоспаться";
        number1.date = new(2022, 10, 19);
        List<Zametka> menuList = new List<Zametka>();
        menuList.Add(number1);
    }
    static void Zametka2()
    {
        Zametka number2 = new();
        number2.Name = "Пойти погулять";
        number2.Description = "я обещал Насте, что погуляю с ней";
        number2.date = new(2022, 10, 20);
        menuList.Add(number2);
    }
    static void Zametka3()
    {
        Zametka number3 = new();
        number3.Name = "Сделать подарок маме";
        number3.Description = "У мамы день рождения и нужно приготовить подарок своими руками.";
        number3.date = new(2022, 10, 22);
        menuList.Add(number3);
    }
    static void Zametka4()
    {
        Zametka number4 = new Zametka();
        number4.Name = "Сделать домамшнее задание";
        number4.Description = "Выучить конспект по ААС, завершить практическую по пайтону и приступить к C#.";
        number4.date = new(2022, 10, 23);
        menuList.Add(number4);
    }
    static void Zametka5()
    {
        Zametka number5 = new Zametka();
        number5.Name = "Выспаться";
        number5.Description = "Я выполнил много дел, пора отдохнуть и хорошенько выспаться";
        number5.date = new(2022, 10, 24);
        menuList.Add(number5);
    }

}