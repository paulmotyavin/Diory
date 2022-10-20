namespace Diary
{
    public class Zametki
    {
        public string name;
        public string description;
        public DateTime DateOfZametki;
        private void Main()
        {
            string name;
            string description;
            DateTime DateOfZametki; 
        }
        public string[] Zametka10()
        {   
            string name;
            string description;
            DateTime DateOfZametki;
            name = "Сходить на пары";
            description = "Учеба начинается со 2 пары до 5";
            string[] bebra = { name, description };
            return bebra;
        }
        public void Zametka1()
        {
            DateTime day = new(2022, 10, 19);
            int position = 2;
            day.ToString();
            day = day.Date;
            day.ToString();
            Console.WriteLine(day);
            ConsoleKeyInfo key = Console.ReadKey();
            Zametki zametka1 = new Zametki();
            zametka1.name = "1. Идти на пары";
            description = "Учеба начинается со 2 пары до 5.";
            zametka1.DateOfZametki = day;
        }
        public void Zametka2()
        {
            Zametki zametka2 = new Zametki();
            zametka2.name = "1. Пойти в магазин";
            description = "Пойти в пятерочку и купить: салат, овощи, фрукты для ужина.";
            zametka2.DateOfZametki = day;
        }
        public void Zametka3()
        {
            Zametki zametka3 = new Zametki();
            zametka3.name = "1. Ничего не делать";
            description = "Я сделал довольно большую работу, поэтому можно отдохнуть.";
            zametka3.DateOfZametki = day;
        }
        public void Zametka4()
        {
            Zametki zametka3 = new Zametki();
            zametka3.name = "1. Ничего не делать";
            description = "Я сделал довольно большую работу, поэтому можно отдохнуть.";
            zametka3.DateOfZametki = date;
        }
    }


namespace ConsolApp1
    {
        internal class Pizza
        {
            public string Name;
            public int Diameter;
        }
    }
    Pizza margarita = new Pizza();
    margarita.Name = "Маргарита";
margarita.Diameter = 28;

Console.WriteLine(margarita.Name);
Console.WriteLine(margarita.Diameter);

Pizza havai = new Pizza();
    havai.Diameter = "Гавайская";
havai.
    }
}

