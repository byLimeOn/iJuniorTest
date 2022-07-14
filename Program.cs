using System;
class Program
{
    static void Main(string[] args)
    {
        int onePeopleTime = 10;
        int minutesPerHour = 60;
        Console.Write("Войдя в поликлинику, Вы видите толпу старушек. Окинув взглядом, насчиталось ");
        int allPeople = Convert.ToInt32(Console.ReadLine());
        int inTurnTime = allPeople * onePeopleTime;
        int inTurnHours = inTurnTime / minutesPerHour;
        int inTurnMinutes = inTurnTime % minutesPerHour;
        Console.WriteLine("Время ожидания составит " + inTurnHours + " часа " + inTurnMinutes + " минут.");
    }
}
