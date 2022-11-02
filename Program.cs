using CakeOrder;
using System.IO;

int position = 3;
string[] CakePar = new[] { "", "", "", "", "", "" };
string CakeFile = null;
DateTime dateTime = DateTime.Now;
bool second = false;



void Menu()
{
    Console.WriteLine("Выберите и купите торт из множества ниже перечисленных. \nВыбери свой торт\n---------------------------------------------------------------");

    Console.WriteLine("  Форма торта");
    Console.WriteLine("  Размер торта");
    Console.WriteLine("  Вкус пироженного");
    Console.WriteLine("  Количество слоев");
    Console.WriteLine("  Глазурь");
    Console.WriteLine("  Декор \n  --------");
    Console.WriteLine("  Конец заказа");

    Console.Write("\n цена в  руб: ");
    CakeOrder.countPrice.CountingResult();

    Console.WriteLine(" Твой торт:");
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine(CakePar[i]);
    }
}

int i;
void Cl()
{
    Console.SetCursorPosition(0, 0);
    Console.Clear();
}

while (second == true) ; 
{
    while (true)
    {
        Cl();
        Menu();
        Console.SetCursorPosition(0, position);
        Console.WriteLine("->");

        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.UpArrow && position >= 4)
        {
            if (position == 10)
            {
                position = 8;
                continue;
            }

            position--;
            continue;
        }

        if (key.Key == ConsoleKey.DownArrow && position <= 9)
        {
            if (position == 8)
            {
                position = 10;
                continue;
            }

            position++;
            continue;
        }

        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 3)
            {

                while (!false)
                {
                    CakeOrder.ParametersCake.Shape();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    ConsoleKeyInfo keyChape = Console.ReadKey();
                    {
                        

                        if (keyChape.Key == ConsoleKey.Enter)
                        {

                            if (position == 3)
                            {
                                CakeOrder.countPrice.One = 300;
                                CakePar[0] = " Форма: круг";
                                break;
                            }

                            if (position == 4)
                            {
                                CakeOrder.countPrice.One = 500;
                                CakePar[0] = " Форма: квадрат";
                                position = 3;
                                break;
                            }

                            if (position == 5)
                            {
                                CakeOrder.countPrice.One = 550;
                                CakePar[0] = " Форма: прямоугольник";
                                position = 3;
                                break;
                            }

                            if (position == 6)
                            {
                                CakeOrder.countPrice.One = 600;
                                CakePar[0] = " Форма: бабочка";
                                position = 3;
                                break;
                            }
                        }

                        if (keyChape.Key == ConsoleKey.UpArrow && position >= 4)
                        {
                            position--;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.DownArrow && position <= 5)
                        {
                            position++;
                            continue;
                        }

                        if (position <= 3)
                        {
                            position = 3;
                            continue;
                        }

                        if (position >= 6)
                        {
                            position = 6;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.Escape)
                        {
                            position = 3;
                            break;
                        }


                    }
                    if (position == 4)
                    {


                    }

                }

            }

            if (position == 4)
            {
                while (!false)
                {
                    CakeOrder.ParametersCake.size();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    ConsoleKeyInfo keyChape = Console.ReadKey();
                    {

                        if (keyChape.Key == ConsoleKey.Enter)
                        {

                            if (position == 3)
                            {
                                CakeOrder.countPrice.Two = 100;
                                CakePar[1] = " Размер: маленький";
                                position = 3;
                                break;
                            }

                            if (position == 4)
                            {
                                CakeOrder.countPrice.Two = 500;
                                CakePar[1] = " Размер: средний";
                                position = 3;
                                break;
                            }

                            if (position == 5)
                            {
                                CakeOrder.countPrice.Two = 1000;
                                CakePar[1] = " Размер: большой";
                                position = 3;
                                break;
                            }
                        }

                        if (keyChape.Key == ConsoleKey.UpArrow && position >= 4)
                        {
                            position--;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.DownArrow && position <= 5)
                        {
                            position++;
                            continue;
                        }

                        if (position <= 3)
                        {
                            position = 3;
                            continue;
                        }

                        if (position >= 5)
                        {
                            position = 5;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                }

            }

            if (position == 5)
            {
                position = 3;
                while (!false)
                {

                    CakeOrder.ParametersCake.tasteOfCakes();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    ConsoleKeyInfo keyChape = Console.ReadKey();
                    {

                        if (keyChape.Key == ConsoleKey.Enter)
                        {

                            if (position == 3)
                            {
                                CakeOrder.countPrice.Three = 150;
                                CakePar[2] = " Вкус торта: шоколад";
                                position = 3;
                                break;
                            }

                            if (position == 4)
                            {
                                CakeOrder.countPrice.Three = 200;
                                CakePar[2] = " Вкус торта: карамель";
                                position = 3;
                                break;
                            }

                            if (position == 5)
                            {
                                CakeOrder.countPrice.Three = 250;
                                CakePar[2] = " Вкус торта: ваниль";
                                position = 3;
                                break;
                            }

                            if (position == 6)
                            {
                                CakeOrder.countPrice.Three = 300;
                                CakePar[2] = " Вкус торта: вишня";
                                position = 3;
                                break;
                            }

                            if (position == 7)
                            {
                                CakeOrder.countPrice.Three = 350;
                                CakePar[2] = " Вкус торта: какао";
                                position = 3;
                                break;
                            }
                        }

                        if (keyChape.Key == ConsoleKey.UpArrow && position >= 4)
                        {
                            position--;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.DownArrow && position <= 6)
                        {
                            position++;
                            continue;
                        }

                        if (position <= 3)
                        {
                            position = 3;
                            continue;
                        }

                        if (position >= 5)
                        {
                            position = 5;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.Escape)
                        {
                            break;
                        }


                    }
                }
            }

            if (position == 6)
            {
                position = 3;
                while (!false)
                {
                    CakeOrder.ParametersCake.layers();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    ConsoleKeyInfo keyChape = Console.ReadKey();
                    {

                        if (keyChape.Key == ConsoleKey.Enter)
                        {

                            if (position == 3)
                            {
                                CakeOrder.countPrice.Four = 100;
                                CakePar[3] = " Количество слоев: 1 корж";
                                position = 3;
                                break;
                            }

                            if (position == 4)
                            {
                                CakeOrder.countPrice.Four = 200;
                                CakePar[3] = " Количество слоев: 2 коржа";
                                position = 3;
                                break;
                            }

                            if (position == 5)
                            {
                                CakeOrder.countPrice.Four = 300;
                                CakePar[3] = " Количество слоев: 3 коржа";
                                position = 3;
                                break;
                            }

                            if (position == 6)
                            {
                                CakeOrder.countPrice.Four = 400;
                                CakePar[3] = " Количество слоев: 4 коржа";
                                position = 3;
                                break;
                            }

                            if (position == 7)
                            {
                                CakeOrder.countPrice.Four = 500;
                                CakePar[3] = " Количество слоев: 5 коржей";
                                position = 3;
                                break;
                            }
                        }

                        if (keyChape.Key == ConsoleKey.UpArrow && position >= 4)
                        {
                            position--;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.DownArrow && position <= 6)
                        {
                            position++;
                            continue;
                        }

                        if (position <= 3)
                        {
                            position = 3;
                            continue;
                        }

                        if (position >= 7)
                        {
                            position = 7;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                }
            }

            if (position == 7)
            {
                position = 3;
                while (!false)
                {
                    CakeOrder.ParametersCake.glaze();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    ConsoleKeyInfo keyChape = Console.ReadKey();
                    {

                        if (keyChape.Key == ConsoleKey.Enter)
                        {

                            if (position == 3)
                            {
                                CakeOrder.countPrice.Five = 150;
                                CakePar[4] = " Глазурь: да";
                                position = 3;
                                break;
                            }

                            if (position == 4)
                            {
                                CakeOrder.countPrice.Five = 0;
                                CakePar[4] = " Глазурь: нет";
                                position = 3;
                                break;
                            }
                        }

                        if (keyChape.Key == ConsoleKey.UpArrow && position >= 4)
                        {
                            position--;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.DownArrow && position <= 4)
                        {
                            position++;
                            continue;
                        }

                        if (position <= 3)
                        {
                            position = 3;
                            continue;
                        }

                        if (position >= 4)
                        {
                            position = 4;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.Escape)
                        {
                            break;
                        }

                    }
                }
            }

            if (position == 8)
            {
                position = 3;
                while (!false)
                {
                    CakeOrder.ParametersCake.decor();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    ConsoleKeyInfo keyChape = Console.ReadKey();
                    {

                        if (keyChape.Key == ConsoleKey.Enter)
                        {

                            if (position == 3)
                            {
                                CakeOrder.countPrice.Six = 50;
                                CakePar[5] = "Декор: какао";
                                position = 3;
                                break;
                            }

                            if (position == 4)
                            {
                                CakeOrder.countPrice.Six = 100;
                                CakePar[5] = " Декор: шоколад";
                                position = 3;
                                break;
                            }

                            if (position == 5)
                            {
                                CakeOrder.countPrice.Six = 150;
                                CakePar[5] = " Декор: карамель";
                                position = 3;
                                break;
                            }

                            if (position == 6)
                            {
                                CakeOrder.countPrice.Six = 200;
                                CakePar[5] = " Декор: ваниль";
                                position = 3;
                                break;
                            }
                        }

                        if (keyChape.Key == ConsoleKey.UpArrow && position >= 4)
                        {
                            position--;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.DownArrow && position <= 5)
                        {
                            position++;
                            continue;
                        }

                        if (position <= 3)
                        {
                            position = 3;
                            continue;
                        }

                        if (position >= 6)
                        {
                            position = 6;
                            continue;
                        }

                        if (keyChape.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                }
            }


            if (position == 10)
            {

                for (int j = 0; j < 6; j++)
                {
                    CakeFile += CakePar[j];
                }

                File.AppendAllText("C:\\Users\\User\\Desktop\\тортики.txt" , "\nВремя заказа: " +"  "+ dateTime );
                File.AppendAllText("C:\\Users\\User\\Desktop\\тортики.txt" ,"\nЦена: " + Convert.ToString(CakeOrder.countPrice.Result) + "руб");
                File.AppendAllText("C:\\Users\\User\\Desktop\\тортики.txt",  "\nПараметры торта: " + CakeFile + "\n");

                Cl();
                Console.WriteLine("Если вы хотите начать делать заказ занова нажмите A");
                ConsoleKeyInfo keyNext = Console.ReadKey();
                if (keyNext.Key == ConsoleKey.A)
                {
                    second = true;
                    CakeOrder.countPrice.One = 0;
                    CakeOrder.countPrice.Two = 0;
                    CakeOrder.countPrice.Three = 0;
                    CakeOrder.countPrice.Four = 0;
                    CakeOrder.countPrice.Five = 0;
                    CakeOrder.countPrice.Six = 0;
                    CakeOrder.countPrice.Result = 0;

                    for (int l1 = 0; l1 < CakePar.Length; l1++)
                    {
                        CakePar[l1] = null;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
} 

