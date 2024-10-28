using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Введення дробів вручну
            MyFrac frac1 = InputFraction("Enter the first fraction (format: numerator/denominator): ");
            MyFrac frac2 = InputFraction("Enter the second fraction (format: numerator/denominator): ");

            // Вивід до консолі
            Console.WriteLine("\nTesting ToString:");
            Console.WriteLine(frac1);  // Виводимо frac1
            Console.WriteLine(frac2);  // Виводимо frac2

            // Додавання дробів
            MyFrac sum = frac1.Plus(frac2);
            Console.WriteLine("\nTesting Plus:");
            Console.WriteLine($"{frac1} + {frac2} = {sum}");

            // Віднімання дробів
            MyFrac difference = frac1.Minus(frac2);
            Console.WriteLine("\nTesting Minus:");
            Console.WriteLine($"{frac1} - {frac2} = {difference}");

            // Множення дробів
            MyFrac product = frac1.Multiply(frac2);
            Console.WriteLine("\nTesting Multiply:");
            Console.WriteLine($"{frac1} * {frac2} = {product}");

            // Ділення дробів
            MyFrac quotient = frac1.Divide(frac2);
            Console.WriteLine("\nTesting Divide:");
            Console.WriteLine($"{frac1} / {frac2} = {quotient}");

            // Перетворення з цілою частиною
            Console.WriteLine("\nTesting ToStringWithIntPart:");
            Console.WriteLine(frac1.ToStringWithIntPart());
            Console.WriteLine(sum.ToStringWithIntPart() + " - sum");
            Console.WriteLine(quotient.ToStringWithIntPart() + " - quotient");

            // Вивід дійсних значень
            Console.WriteLine("\nTesting DoubleValue:");
            Console.WriteLine($"Double value of {frac1} is {frac1.DoubleValue()}");
            Console.WriteLine($"Double value of {frac2} is {frac2.DoubleValue()}");
        }

        // Метод для зчитування дробу з консолі
        private static MyFrac InputFraction(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            string[] parts = input.Split('/');

            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid fraction format. Use 'numerator/denominator'.");
            }

            // Парсимо чисельник і знаменник
            long numerator = long.Parse(parts[0]);
            long denominator = long.Parse(parts[1]);

            return new MyFrac(numerator, denominator);
        }
    }