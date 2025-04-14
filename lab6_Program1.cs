using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Класс для проверки ввода целых чисел
    public class InputValidator
    {
        public static int GetValidInteger(string prompt)
        {
            int number;
            bool isValid;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                isValid = int.TryParse(input, out number);

                if (!isValid)
                {
                    Console.WriteLine("Ошибка: Введите целое число.");
                }
            } while (!isValid);

            return number;
        }
    }

    // Базовый класс с тремя целочисленными полями
    public class IntegerClass
    {
        private int field1;
        private int field2;
        private int field3;

        // Конструктор по умолчанию
        public IntegerClass()
        {
            field1 = 0;
            field2 = 0;
            field3 = 0;
        }

        // Конструктор с параметрами
        public IntegerClass(int field1, int field2, int field3)
        {
            this.field1 = field1;
            this.field2 = field2;
            this.field3 = field3;
        }

        // Конструктор копирования
        public IntegerClass(IntegerClass other)
        {
            this.field1 = other.field1;
            this.field2 = other.field2;
            this.field3 = other.field3;
        }

        // Метод для вычисления произведения полей
        public int CalculateProduct()
        {
            return field1 * field2 * field3;
        }

        // Перегруженный метод ToString()
        public override string ToString()
        {
            return $"Поле 1: {field1}, Поле 2: {field2}, Поле 3: {field3}";
        }

        public int Field1
        {
            get { return field1; }
            set { field1 = value; }
        }

        public int Field2
        {
            get { return field2; }
            set { field2 = value; }
        }

        public int Field3
        {
            get { return field3; }
            set { field3 = value; }
        }
    }

    // Дочерний класс: Класс "Операции с числами"
    public class NumberOperations : IntegerClass
    {
        // Конструкторы
        public NumberOperations() : base() { }
        public NumberOperations(int a, int b, int c) : base(a, b, c) { }
        public NumberOperations(NumberOperations other) : base(other) { }

        // Метод 1: Вычисление суммы всех полей
        public int CalculateSum()
        {
            return Field1 + Field2 + Field3;
        }

        // Метод 2: Вычисление разности первого поля и суммы двух других
        public int CalculateDifference()
        {
            return Field1 - (Field2 + Field3);
        }

        // Метод 3: Проверка, является ли хотя бы одно поле отрицательным
        public bool HasNegativeValue(out int negativeValue)
        {
            negativeValue = 0;
            if (Field1 < 0)
            {
                negativeValue = Field1;
                return true;
            }
            if (Field2 < 0)
            {
                negativeValue = Field2;
                return true;
            }
            if (Field3 < 0)
            {
                negativeValue = Field3;
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Объект 1 :");

            // Создание объекта с помощью конструктора с параметрами
            int field1 = InputValidator.GetValidInteger("Введите значение для поля 1: ");
            int field2 = InputValidator.GetValidInteger("Введите значение для поля 2: ");
            int field3 = InputValidator.GetValidInteger("Введите значение для поля 3: ");
            IntegerClass obj2 = new IntegerClass(field1, field2, field3);
            Console.WriteLine("Объект 2 (конструктор с параметрами):");
            Console.WriteLine($"  Поле 1: {obj2.Field1}");
            Console.WriteLine($"  Поле 2: {obj2.Field2}");
            Console.WriteLine($"  Поле 3: {obj2.Field3}");
            Console.WriteLine($"  Произведение полей: {obj2.CalculateProduct()}");
            Console.WriteLine();

            // Создание объекта с помощью конструктора копирования
            IntegerClass obj3 = new IntegerClass(obj2);
            Console.WriteLine("Объект 3 (конструктор копирования):");
            Console.WriteLine($"  Поле 1: {obj3.Field1}");
            Console.WriteLine($"  Поле 2: {obj3.Field2}");
            Console.WriteLine($"  Поле 3: {obj3.Field3}");
            Console.WriteLine();

            // Создание объекта с помощью конструктора с параметрами
            int num1 = InputValidator.GetValidInteger("Введите первое число: ");
            int num2 = InputValidator.GetValidInteger("Введите второе число: ");
            int num3 = InputValidator.GetValidInteger("Введите третье число: ");
            NumberOperations numOp2 = new NumberOperations(num1, num2, num3);
            Console.WriteLine("Объект Чисел (конструктор с параметрами):");
            Console.WriteLine($"  Число 1: {numOp2.Field1}");
            Console.WriteLine($"  Число 2: {numOp2.Field2}");
            Console.WriteLine($"  Число 3: {numOp2.Field3}");
            Console.WriteLine($"  Сумма чисел: {numOp2.CalculateSum()}");
            Console.WriteLine($"  Разность первого и суммы двух других: {numOp2.CalculateDifference()}");

            int negativeValue;
            if (numOp2.HasNegativeValue(out negativeValue))
            {
                Console.WriteLine($"  Есть отрицательное число: {negativeValue}");
            }
            else
            {
                Console.WriteLine("  Отрицательных чисел нет.");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }

}
