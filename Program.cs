using cakes;


namespace Торт
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {

                text();

            }
            Console.Clear();
        }

        static void text()
        {
            Console.WriteLine("Заказ тортов" + "\n" + "Выберите параметры торта" + "\n" + "-----------------------------" + "\n" + "  Форма" + "\n" + "  Размер" + "\n" + "  Начинка" + "\n" + "  Количество коржей" + "\n" + "  Глазурь" + "\n" + "  Декор" + "\n" + "  Конец заказа" + "\n" + "---------------------------------" + "\n");
            menu();
        }
        static void menu()
        {
            
            while (true)
            {               
                int pos = 3;                
                ConsoleKeyInfo cursor = Console.ReadKey();
                while (cursor.Key != ConsoleKey.Escape)
                {
                    if (cursor.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(0, pos++);
                        Console.WriteLine("->");

                    }
                    else if (cursor.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(0, pos--);
                        Console.WriteLine("->");
                    }
                      if (cursor.Key == ConsoleKey.Enter && pos == 3)
                    {
                        Console.Clear();
                        menuu per1 = new menuu("  квадрат", 200);
                        per1.per();
                        menuu per2 = new menuu("  круг", 200);
                        per2.per();
                        menuu per3 = new menuu("  треугольник", 150);
                        per3.per();
                        int Posin = 0;
                        Console.SetCursorPosition(0, Posin);
                        Console.WriteLine("->");
                        ConsoleKeyInfo ram = Console.ReadKey();
                        while (ram.Key != ConsoleKey.Enter)
                        {
                            if (ram.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, Posin++);
                                Console.WriteLine("->");
                            }
                            if (ram.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, Posin--);
                                Console.WriteLine("->");
                            }
                            if (Posin == 0)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per1.desc + " - " + per1.cost);
                                }
                            }
                            if (Posin == 1)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {                                                     
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per2.desc + " - " + per2.cost);
                                }
                            }
                            if (Posin == 2)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per3.desc + " - " + per3.cost);
                                }
                            }
                            Console.Clear();
                            per1.per();
                            per2.per();
                            per3.per();
                            Console.SetCursorPosition(0,Posin);
                            Console.WriteLine("->");
                            ram = Console.ReadKey();
                        }
                        string sum1 = per1.desc + per2.desc+ per3.desc;
                        Console.WriteLine(sum1);
                    }
                    if (cursor.Key == ConsoleKey.Enter && pos == 4)
                    {
                        Console.Clear();
                        menuu per1 = new menuu("  маленький", 150);
                        per1.per();
                        menuu per2 = new menuu("  средний", 200);
                        per2.per();
                        menuu per3 = new menuu("  большой", 250);
                        per3.per();
                        int Posin = 0;
                        Console.SetCursorPosition(0, Posin);
                        Console.WriteLine("->");
                        ConsoleKeyInfo ram = Console.ReadKey();
                        while (ram.Key != ConsoleKey.Enter)
                        {
                            if (ram.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, Posin++);
                                Console.WriteLine("->");
                            }
                            if (ram.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, Posin--);
                                Console.WriteLine("->");
                            }
                            if (Posin == 0)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per1.desc + " - " + per1.cost);
                                }
                            }
                            if (Posin == 1)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per2.desc + " - " + per2.cost);
                                }
                            }
                            if (Posin == 2)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per3.desc + " - " + per3.cost);
                                }
                            }
                            Console.Clear();
                            per1.per();
                            per2.per();
                            per3.per();
                            Console.SetCursorPosition(0, Posin);
                            Console.WriteLine("->");
                            ram = Console.ReadKey();
                        }
                        string sum2 = per1.desc + per2.desc + per3.desc;
                    }
                    if (cursor.Key == ConsoleKey.Enter && pos == 5)
                    {
                        Console.Clear();
                        menuu per1 = new menuu("  клубника", 200);
                        per1.per();
                        menuu per2 = new menuu("  карамель", 200);
                        per2.per();
                        menuu per3 = new menuu("  шоколад", 200); 
                        per3.per();
                        int Posin = 0;
                        Console.SetCursorPosition(0, Posin);
                        Console.WriteLine("->");
                        ConsoleKeyInfo ram = Console.ReadKey();
                        while (ram.Key != ConsoleKey.Enter)
                        {
                            if (ram.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, Posin++);
                                Console.WriteLine("->");
                            }
                            if (ram.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, Posin--);
                                Console.WriteLine("->");
                            }
                            if (Posin == 0)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Пользователи\\User\\рабочий стол\\тортики.txt", per1.desc + " - " + per1.cost);
                                }
                            }
                            if (Posin == 1)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Пользователи\\User\\рабочий стол\\тортики.txt", per2.desc + " - " + per2.cost);
                                }
                            }
                            if (Posin == 2)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Пользователи\\User\\рабочий стол\\тортики.txt", per3.desc + " - " + per3.cost);
                                }
                            }
                            Console.Clear();

                            per1.per();
                            per2.per();
                            per3.per(); ;
                            Console.SetCursorPosition(0, Posin);
                            Console.WriteLine("->");
                            ram = Console.ReadKey();
                        }
                    }
                    if (cursor.Key == ConsoleKey.Enter && pos == 6)
                    {
                        Console.Clear();
                        menuu per1 = new menuu("  два", 200);
                        per1.per();
                        menuu per2 = new menuu("  три", 300);
                        per2.per();
                        menuu per3 = new menuu("  четыре", 400);
                        per3.per();
                        int Posin = 0;
                        Console.SetCursorPosition(0, Posin);
                        Console.WriteLine("->");
                        ConsoleKeyInfo ram = Console.ReadKey();
                        while (ram.Key != ConsoleKey.Enter)
                        {
                            if (ram.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, Posin++);
                                Console.WriteLine("->");
                            }
                            if (ram.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, Posin--);
                                Console.WriteLine("->");
                            }
                            if (Posin == 0)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per1.desc + " - " + per1.cost);
                                }
                            }
                            if (Posin == 1)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per2.desc + " - " + per2.cost);
                                }
                            }
                            if (Posin == 2)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per3.desc + " - " + per3.cost);
                                }
                            }
                            Console.Clear();
                            per1.per();
                            per2.per();
                            per3.per();
                            Console.SetCursorPosition(0, Posin);
                            Console.WriteLine("->");
                            ram = Console.ReadKey();
                        }
                    }
                    if (cursor.Key == ConsoleKey.Enter && pos == 7)
                    {
                        Console.Clear();
                        menuu per1 = new menuu("  добавлять", 200);
                        per1.per();
                        menuu per2 = new menuu("  не добавлять", 0);
                        per2.per();
                        int Posin = 0;
                        Console.SetCursorPosition(0, Posin);
                        Console.WriteLine("->");
                        ConsoleKeyInfo ram = Console.ReadKey();
                        while (ram.Key != ConsoleKey.Enter)
                        {
                            if (ram.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, Posin++);
                                Console.WriteLine("->");
                            }
                            if (ram.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, Posin--);
                                Console.WriteLine("->");
                            }
                            if (Posin == 0)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per1.desc + " - " + per1.cost);
                                }
                            }
                            if (Posin == 1)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per2.desc + " - " + per2.cost);
                                }
                            }                          
                            Console.Clear();
                            per1.per();
                            per2.per();                        
                            Console.SetCursorPosition(0, Posin);
                            Console.WriteLine("->");
                            ram = Console.ReadKey();
                        }
                    }
                    if (cursor.Key == ConsoleKey.Enter && pos == 8)
                    {
                        Console.Clear();
                        menuu per1 = new menuu("  кокосовая стружка", 200);
                        per1.per();
                        menuu per2 = new menuu("  мастика", 300);
                        per2.per();
                        menuu per3 = new menuu("  шоколадная стружка", 150);
                       per3.per();
                        int Posin = 0;
                        Console.SetCursorPosition(0, Posin);
                        Console.WriteLine("->");
                        ConsoleKeyInfo ram = Console.ReadKey();
                        while (ram.Key != ConsoleKey.Enter)
                        {
                            if (ram.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, Posin++);
                                Console.WriteLine("->");
                            }
                            if (ram.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, Posin--);
                                Console.WriteLine("->");
                            }
                            if (Posin == 0)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                { 
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per1.desc + " - " + per1.cost);
                                }
                            }
                            if (Posin == 1)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per2.desc + " - " + per2.cost);
                                }
                            }
                            if (Posin == 2)
                            {
                                if (ram.Key == ConsoleKey.Enter)
                                {
                                    File.WriteAllText("C:\\Users\\User\\Рабочий стол\\тортики.txt", per3.desc + " - " + per3.cost);
                                }
                            }
                            Console.Clear();
                            per1.per();
                            per2.per();
                            per3.per();
                            Console.SetCursorPosition(0, Posin);
                            Console.WriteLine("->");
                            ram = Console.ReadKey();
                        }
                    }
                    if (cursor.Key == ConsoleKey.Enter && pos == 9)
                    {
                        Console.Clear();
                        Console.WriteLine("заказ готов! Нажмите ESC для выхода"+"\n"+"Если хотите сделать заказ заново нажмте z ");
                        ConsoleKeyInfo vih = Console.ReadKey();
                        Console.Clear();
                        while (true)
                        {
                            if (vih.Key == ConsoleKey.Escape)
                            {
                                Environment.Exit(0);
                            }
                            else if(vih.Key==ConsoleKey.Z)
                            {
                                Console.WriteLine("еще раз нажмите на z");
                                menu();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                    
                    Console.Clear();
                    Console.WriteLine("Заказ тортов" + "\n" + "Выберите параметры торта" + "\n" + "-----------------------------" + "\n" + "  Форма" + "\n" + "  Размер" + "\n" + "  Начинка" + "\n" + "  Количество коржей" + "\n" + "  Глазурь" + "\n" + "  Декор" + "\n" + "  Конец заказа" + "\n" + "---------------------------------" + "\n" );
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    cursor = Console.ReadKey();                  
                }
            }
        }
    }
}