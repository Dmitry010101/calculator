Console.WriteLine(@"Выберите действие:
1. Сложить 2 числа
2. Вычесть первое из второго
3. Перемножить два числа
4. Разделить первое на второе
5. Возвести в степень N первое число
6. Найти квадратный корень из числа
7. Найти 1 процент от числа
9. Выйти из программы");
do
{
    Console.WriteLine();
    Console.WriteLine("Введите номер программы");
    int c = Convert.ToInt32(Console.ReadLine());
    {
        if (c == 1)
        {
            Console.WriteLine("Введите первое значение");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = Convert.ToInt32(Console.ReadLine());
            int summa = a + b;
            Console.WriteLine("Результат сложения :" + summa);
        }
        if (c == 2)
        {
            Console.WriteLine("Введите первое значение");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = Convert.ToInt32(Console.ReadLine());
            int raznost= a - b;
            Console.WriteLine("Результат вычитания : "+ raznost);
        }
        if (c == 3)
        {
            Console.WriteLine("Введите первое значение");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = Convert.ToInt32(Console.ReadLine());
            int umnoj = a * b;
            Console.WriteLine("Результат умножения : " + umnoj);
        }
        if (c == 4)
        {
            Console.WriteLine("Введите первое значение");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = Convert.ToInt32(Console.ReadLine());
            int delenie = a / b;
            if (b == 0)
            {
                Console.WriteLine("Hа 0 делить нельзя");
            }
            else
                Console.WriteLine("Результат деления: " + delenie);
        }
        if (c == 5)
        {
            Console.WriteLine("Введите первое значение");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = Convert.ToInt32(Console.ReadLine());
            double stepen = Math.Pow(a, b);
            Console.WriteLine("Результат возведения числа в степень: " + stepen);

        }
        if (c == 6)
        {
            Console.WriteLine("Введите число из которого будет найден корень");
            int w = Convert.ToInt32(Console.ReadLine());
           double koren = Math.Sqrt(w);
            Console.WriteLine("квадратный корень: " + koren);
        }
        if (c == 7)
        {
            Console.WriteLine("Введите число от которого будте найден 1%");
            int w = Convert.ToInt32(Console.ReadLine());
            int oneproc = w / 100;
            Console.WriteLine(" 1 процент от числа: " + oneproc);
        }
        if (c == 8)
        {
            Console.WriteLine("Ввудите число которое нужно возвести в факториал: ");
           int a = Convert.ToInt32(Console.ReadLine()); 
            int fact = 1;
            do
            {
                fact= fact *a;
                a--;
            } while (a > 0);
            Console.WriteLine("Factorial :" + fact);
        }
        if (c == 9)
        {
            break;
        }
    }
}
while (true);