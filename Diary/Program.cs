namespace Diary;
internal class Program
{
    public static int position = 1;
    public static ConsoleKeyInfo key = Console.ReadKey();
    public static DateTime day = new(2022, 10, 19);
    static void Main()
    {
        day = day.Date;
        Console.WriteLine(day.Date);
        while (key.Key != ConsoleKey.Escape)
        {
            Arrows();
            ChangeDays();
            Lists();
            key = Console.ReadKey();
        }
    }
    static void Arrows()
    {
        if (position == 1 || key.Key == ConsoleKey.DownArrow)
            position++;
        if (key.Key == ConsoleKey.UpArrow || position == 3)
            position--;
    }
    static void ChangeDays()
    {
        if (key.Key == ConsoleKey.LeftArrow)
            day = day.AddDays(-1);
        if (key.Key == ConsoleKey.RightArrow)
            day = day.AddDays(+1);
    }
    static void Lists()
    {
        List<Zametka> Listm = new List<Zametka>();
        Zametka number1 = new();
        number1.Name = "Пойти поспать";
        number1.Description = "я очень устал из-за прошлых заданий, поэтому лучше отоспаться";
        number1.date = new(2022, 10, 19);
        Listm.Add(number1);

        Zametka number2 = new();
        number2.Name = "Пойти погулять";
        number2.Description = "я обещал Насте, что погуляю с ней";
        number2.date = new(2022, 10, 20);
        Listm.Add(number2);

        Zametka number3 = new();
        number3.Name = "Сделать подарок маме";
        number3.Description = "У мамы день рождения и нужно приготовить подарок своими руками.";
        number3.date = new(2022, 10, 22);
        Listm.Add(number3);

        Zametka number4 = new Zametka();
        number4.Name = "Сделать домашнее задание";
        number4.Description = "Выучить конспект по ААС, завершить практическую по пайтону и приступить к C#.";
        number4.date = new(2022, 10, 23);
        Listm.Add(number4);

        Zametka number5 = new Zametka();
        number5.Name = "Выспаться";
        number5.Description = "Я выполнил много дел, пора отдохнуть и хорошенько выспаться";
        number5.date = new(2022, 10, 24);
        Listm.Add(number5);
        List<Zametka> sortedList = Listm.Where(item => item.date == day).ToList<Zametka>();
        Console.Clear();
        Console.WriteLine("Выбрана дата: " + day.Date);
        foreach (Zametka pos in sortedList)
        {
            Console.WriteLine("  " + pos.Name);
        }
        Console.SetCursorPosition(0, position);
        Console.WriteLine("->");
        if (key.Key == ConsoleKey.Enter)
        {
            foreach (Zametka pos in sortedList)
            {
                Console.Clear();
                Console.WriteLine("Название: " + pos.Name);
                Console.WriteLine("-------------------------");
                Console.WriteLine("Описание: " + pos.Description);
                Console.WriteLine("Дата: " + pos.date);
            }
            ConsoleKeyInfo button = Console.ReadKey();
            if (button.Key == ConsoleKey.Enter)
            {
                position = 1;
                Console.Clear();
                Console.WriteLine("Выбрана дата: " + day.Date);
                foreach (Zametka pos in sortedList)
                {
                    Console.WriteLine("  " + pos.Name);
                }
                Console.SetCursorPosition(0, position);
            }
        }
    }
}