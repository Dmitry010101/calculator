static int fact(int n)
{
    int resultat;

    resultat = 1;
    for (int i = 1; i <= n; i++)
        resultat *= i;
    return resultat;

}

Console.WriteLine(@"Выберите действие:
1. Сложить 2 числа
2. Вычесть первое из второго
3. Перемножить два числа
4. Разделить первое на второе
5. Возвести в степень N первое число
6. Найти квадратный корень из числа
7. Найти 1 процент от числа
9. Выйти из программы");
while (true)
{
    string c = Console.ReadLine();
    double a;
    double b;
    double w;
    Console.WriteLine(' ');
    Console.WriteLine(' ');
    {
        if (c == "1")
        {
            Console.WriteLine("Введите первое значение");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат сложения = {0}", a + b);
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");

        }
        if (c == "2")
        {
            Console.WriteLine("Введите первое значение");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат вычитания = {0}", a - b);
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");


        }
        if (c == "3")
        {
            Console.WriteLine("Введите первое значение");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат умножения = {0}", a * b);
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");

        }
        if (c == "4")
        {
            Console.WriteLine("Введите первое значение");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            b = double.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hа 0 делить нельзя");
            }
            else
                Console.WriteLine("Результат деления = {0}", a / b);
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");

        }
        if (c == "5")
        {
            Console.WriteLine("Введите первое значение");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(a, b));
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");

        }
        if (c == "6")
        {
            Console.WriteLine("Введите число из которого будет найден корень");
            w = double.Parse(Console.ReadLine());
            Console.WriteLine("квадратный корень = {0}", Math.Sqrt(w));
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");


        }
        if (c == "7")
        {
            Console.WriteLine("Введите число от которого будте найден 1%");
            w = double.Parse(Console.ReadLine());
            Console.WriteLine(" 1 процент от числа = {0}", w / 100);
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");

        }
        if (c == "8")
        {
            Console.WriteLine("Введите число для которого нужно найти факториал:");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}!={1}", h, fact(h));
            Console.WriteLine("Введите операцию еще раз");

        }

            if (c == "9")
        {
            Environment.Exit(0);
        }
       
    }
}
Console.ReadKey();