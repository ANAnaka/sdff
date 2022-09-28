        int zadachaa = 1;
do
{
    Console.WriteLine("Выберите программу, которую хотите запустить");
    Console.WriteLine("1. Угадай число");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. выход из программы");
    int zadacha = Convert.ToInt32(Console.ReadLine());

    if (zadacha == 1)
    {
        Ugadai();
    }
    if (zadacha == 2)
    {
        Umnoj();
    }

    if (zadacha == 3)
    {
        Delitel();
    }

    if (zadacha == 4)
    {

        Environment.Exit(0);

    }
} while (zadachaa != 4);

static void Ugadai()
{
    Random rnd = new Random();
    int a = rnd.Next(0, 100);
    Console.WriteLine("Введите число от 0 до 100");
    int b = 0;

    do
    {
        b = Convert.ToInt32(Console.ReadLine());

        if (a == b)
        { Console.WriteLine("Вы угадали число!"); }

        else if (a > b)
        {
            Console.WriteLine("Нужно большее число");
        }
        else if (a < b)
        { Console.WriteLine("Нужно меньшее число"); }
    } while (a != b);
}
     
static void Umnoj()
{
    int[,] a = new int[10, 10];

    for (int b = 1; b < 10; b++)
    {
        for (int c = 1; c < 10; c++)
        {
            Console.Write(a[b, c] + b * c + "\t");
        }

        Console.WriteLine();
    }
}
static void Delitel()
{

    int a = 0;
    do
    {
        Console.WriteLine("Чтобы выйти из задачи введите 0");
        Console.WriteLine("Введите число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Делители :");
        for (int x = 1; x <= a; x++)
        {
            if (a % x == 0)
            {
                Console.WriteLine(x);
            }
        }
    } while (a != 0);
}