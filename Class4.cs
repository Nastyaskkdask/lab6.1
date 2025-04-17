using System;

public static class BoxResult
{
    public static void BoxInf(Box box)
    {
        Console.WriteLine(box.ToString());
        Console.WriteLine($"Произведение Параметров (Объём): {box.Product()}");
    }

    public static void ResInf(BoxS boxR)
    {
        Console.WriteLine($"Периметр дна: {boxR.GetSBottom()}");
        Console.WriteLine($"Максимальная площадь стен: {boxR.GetMax()}");
        Console.WriteLine($"Является коробом: {(boxR.IsKorob() ? "Да" : "Нет")}");
    }

    public static void Print()
    {
        Console.WriteLine(new string('_', 35));
    }

}
