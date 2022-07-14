using System;
class Program
{
    static void Main(string[] args)
    {
        int allCrystals = 100;
        int costOfCrystals = 12;
        Console.WriteLine("Сколько у Вас золотишка?");
        int gold = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сколько кристаллов нужно?");
        int needCrystals = Convert.ToInt32(Console.ReadLine());
        int price = needCrystals * costOfCrystals;
        Console.WriteLine("Ваши " + price + $" золота за {needCrystals} кристаллов. Сдача " + (gold - price) + " золота. Ваш чек пожалуйста. У нас осталось ещё " + (allCrystals - needCrystals) + " кристаллов");
    }
}
