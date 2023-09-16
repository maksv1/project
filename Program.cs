using System;

class Calculator
{
    static void Main()
    {
        int choice;
        double num1, num2, result;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе ");
            Console.WriteLine("5. Возведение в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент из числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 2:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 4:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 5:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Pow(num1, num2);
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 6:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 7:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / 100;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 8:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Factorial(num1);
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 9:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static double Factorial(double num)
    {
        double result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}