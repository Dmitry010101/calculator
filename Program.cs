using System;
using System.ComponentModel.Design;


static void vtoroe ()
{
    Console.WriteLine("   Сидеть дома 2 ");
    Console.WriteLine("   Ехать в техникум 2 ");
}
static void tretie()
{
    Console.WriteLine("   Сидеть дома 3 ");
    Console.WriteLine("   Ехать в техникум 3 ");
}
static void chetver()
{
    Console.WriteLine("   Сидеть дома 4  ");
    Console.WriteLine("   Ехать в техникум 4 ");
}
static void piatoe()
{
    Console.WriteLine("   Сидеть дома 5");
    Console.WriteLine("   Ехать в техникум 5");
}

    static void shestoe()
    {
        Console.WriteLine("   Сидеть дома 6 ");
        Console.WriteLine("   Ехать в техникум 6");
    }
    static void strelki()
    {
        int pos = 1;
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("->");
    }
    DateTime date = new DateTime(2022, 10, 1);

    int pos = 1;

    Console.WriteLine(date);
    while (true)
    {
        strelki();
        ConsoleKeyInfo key = Console.ReadKey();
        Console.Clear();
        if (key.Key == ConsoleKey.UpArrow)
        {
            pos--;
        }
        if (key.Key == ConsoleKey.DownArrow)
        {
            pos++;
        }
        if (key.Key == ConsoleKey.LeftArrow)
        {
            date = date.AddDays(-1);
            Console.WriteLine(date);
        }
        if (key.Key == ConsoleKey.RightArrow)
        {
            date = date.AddDays(+1);
            Console.WriteLine(date);
        }
    if (date.Day == 2)
    {
        Console.Clear();
        Console.WriteLine(date);
        vtoroe();
        if (key.Key == ConsoleKey.Enter)
        {
            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 2: " + "\n" + "   Сплю  2");
            }
            else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 2: " + "\n " + "   Учи философию 2");
            }
        }
    }


    if (date.Day == 3)
    {
        Console.Clear();
        Console.WriteLine(date);
        tretie();
        if (key.Key == ConsoleKey.Enter)
        {
            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 3: " + "\n" + "   Сплю  3");
            }
            else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 3: " + "\n " + "   Учи философию 3");
            }
        }
    }
    if (date.Day == 4)
    {
        Console.Clear();
        Console.WriteLine(date);
        chetver();
        if (key.Key == ConsoleKey.Enter)
        {
            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 4: " + "\n" + "   Сплю 4 ");
            }
            else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 4:" + "\n " + "   Учу философию 4 ");
            }
        }
    }
    if (date.Day == 5)
    {
        Console.Clear();
        Console.WriteLine(date);
        piatoe();
        if (key.Key == ConsoleKey.Enter)
        {
            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 5: " + "\n" + "   Сплю 5 ");
            }
            else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 5: " + "\n " + "   Учу философию 5 ");
            }
        }
    }
    if (date.Day == 6)
    {
        Console.Clear();
        Console.WriteLine(date);
        shestoe();
        if (key.Key == ConsoleKey.Enter)
        {
            if (pos == 1)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 6: " + "\n" + "   Сплю 6 ");
            }
            else if (pos == 2)
            {
                Console.Clear();
                Console.WriteLine("Выбрана дата:" + " " + date + "\n" + "------------------------------------" + "\n" + "   Описание 6: " + "\n " + "   Учу философию 6 ");
            }
        }
    }
        }
    


