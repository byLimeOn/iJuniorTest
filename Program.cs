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
        gold -= price;
        allCrystals -= needCrystals;
        Console.WriteLine($"Ваши {price} золота за {needCrystals} кристаллов. Сдача " + gold + " золота. Ваш чек пожалуйста. У нас осталось ещё " + allCrystals + " кристаллов");
    }
}
