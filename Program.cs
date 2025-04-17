using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("----| Анализ коробки |----\n");

        int lenght = InputHelper.ReadPositiveInt("Введите Длину: ");
        int widht = InputHelper.ReadPositiveInt("Введите Ширину: ");
        int height = InputHelper.ReadPositiveInt("Введите Высоту: ");
        BoxResult.Print();

        Box box = new Box(lenght, widht, height);
        BoxS boxR = new BoxS(box);
        Box boxCopy = new Box(box);

        Console.WriteLine("\n|Оригинальная коробка|");
        BoxResult.BoxInf(box);
        BoxResult.Print();

        Console.WriteLine("|Копия коробки|");
        BoxResult.BoxInf(boxCopy);
        BoxResult.Print();

        Console.WriteLine("|Анализ коробки|");
        BoxResult.ResInf(boxR);
        BoxResult.Print();

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

static class InputHelper
{
    public static int ReadPositiveInt(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number > 0)
            {
                break;
            }
            Console.WriteLine("Ошибка: введите целое положительное число.");
        }
        return number;
    }
}
