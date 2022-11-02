namespace CakeOrder;

internal class ParametersCake
{
    void Cl()
    {
        Console.SetCursorPosition(0, 0);
        Console.Clear();
    }

    void Nav()
    {

    }

    public static int Prises;
    public static void Shape()
    {


        Console.Clear();
        Console.SetCursorPosition(0, 0);

        Console.WriteLine("Нажми Esc чтобы выйти");
        Console.WriteLine("Выберите один из пунктов:\n--------");

        Console.WriteLine("  Круг - 300р");
        Console.WriteLine("  Квадрат - 500р");
        Console.WriteLine("  Прямоугольник  - 550р");
        Console.WriteLine("  Бабочка - 600р");
    }

    public static void size()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        Console.WriteLine("Нажми Esc чтобы выйти");
        Console.WriteLine("Выберите один из пунктов:\n--------");

        Console.WriteLine("  Маленький (диаметр - 15 - 100р)");
        Console.WriteLine("  Средний (диаметр - 20 - 500р)");
        Console.WriteLine("  Большой (диаметр - 25  - 1000р)");

    }

    public static void tasteOfCakes()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        Console.WriteLine("Нажми Esc чтобы выйти");
        Console.WriteLine("Выберите один из пунктов:\n--------");

        Console.WriteLine("  Шоколад - 150р");
        Console.WriteLine("  Карамель - 200р");
        Console.WriteLine("  Ваниль - 250р");
        Console.WriteLine("  Вишня - 300р");
        Console.WriteLine("  Какао - 350р");
    }

    public static void layers()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        Console.WriteLine("Нажми Esc чтобы выйти");
        Console.WriteLine("Выберите один из пунктов:\n--------");

        Console.WriteLine("  1 корж - 100р");
        Console.WriteLine("  2 коржа - 200р");
        Console.WriteLine("  3 коржа - 300р");
        Console.WriteLine("  4 коржа - 400р");
        Console.WriteLine("  5 коржей - 500р");
    }

    public static void glaze()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        Console.WriteLine("Нажми Esc чтобы выйти");
        Console.WriteLine("Выберите один из пунктов:\n--------");

        Console.WriteLine("  Да - 150р");
        Console.WriteLine("  Нет - 0р");
    }

    public static void decor()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        Console.WriteLine("Нажми Esc чтобы выйти");
        Console.WriteLine("Выберите один из пунктов:\n--------");

        Console.WriteLine("  Какао - 50р");
        Console.WriteLine("  Шоколад - 100р");
        Console.WriteLine("  Карамель - 150р");
        Console.WriteLine("  Ваниль - 200р");
    }
}