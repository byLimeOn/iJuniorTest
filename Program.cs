using System;
class Program
{
    static void Main(string[] args)
    {
        int onePeopleTime = 10;
        Console.Write("Войдя в поликлинику, Вы видите толпу старушек. Окинув взглядом, насчиталось ");
        int allPeople = Convert.ToInt32(Console.ReadLine());
        int inTurnTime = allPeople * onePeopleTime;
        int hours = inTurnTime / 60;
        int minutes = inTurnTime % 60;
        Console.WriteLine("Время ожидания составит " + hours + " часа " + minutes + " минут.");
    }
}
