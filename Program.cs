using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здрав будь, иноземец! Дабы проследовать в покои царские на вопросы ответь сперва");
        Console.WriteLine("Как величать тебя?");
        string name = Console.ReadLine();
        Console.WriteLine("Откуда путь держишь?");
        string city = Console.ReadLine();
        Console.WriteLine("Лет от роду как много?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Иноземец " + name + " из места, именуемого " + city + ", лет от роду прожив " + age + ", почтил нас своим визитом!");
    }
}
