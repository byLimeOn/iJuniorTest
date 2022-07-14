using System;
class Program
{
    static void Main(string[] args)
    {
        int pictures = 52;
        int picturesInRow = 3;
        int fullRows = pictures / picturesInRow;
        int remain = pictures % picturesInRow;
        Console.WriteLine($"Из {pictures} картинок по {picturesInRow} в ряд получилось {fullRows} полных рядов. {remain} картинок вышло сверх меры");
    }
}
