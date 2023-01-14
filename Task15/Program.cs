// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

void Header()
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
    Console.WriteLine();
    Console.WriteLine("Программа создает заданный Вами массив");
    Console.WriteLine();
}

int[] ArrayFill(int size)
{
    System.Console.WriteLine($"Введите {size} элемента(-ов) массива:");
    System.Console.WriteLine();
    int[] array = new int[size];
    int x = 0;
    for (int i = 0; i < array.Length; i++)
    {
        while (!int.TryParse(Console.ReadLine(), out array[i]))   // для проверки ввода в одну строку
        {
            Console.SetCursorPosition(x, (Console.CursorTop - 1));
            System.Console.WriteLine("                ");
            Console.SetCursorPosition(x, (Console.CursorTop - 1));
        }                                                         // для ввода в одну строку
        x += (int)Math.Log10(array[i]) + 3;                   // из-за такой проверки невозможно ввести отрицательные числа
        if (i != array.Length - 1)                            // можно было добавить еще пару проверок, либо считать x через цикл.....
        {                                                     // но как-нибудь потом....
            Console.SetCursorPosition(x - 2, (Console.CursorTop - 1));
            System.Console.WriteLine(',');
            Console.SetCursorPosition(x, (Console.CursorTop - 1));
        }

    }
    return array;

}

int[] FreeSizedArr()
{
    int x = 0;
    int[] array = new int[1];
    System.Console.WriteLine("Введите массив. По окончанию нажмите Enter, либо введите не цифры:");
    System.Console.WriteLine();
    for (int i = 0; int.TryParse(Console.ReadLine(), out array[i]); i++)
    {

        Array.Resize(ref array, array.Length + 1);
        x += (int)Math.Log10(array[i]) + 3;
        Console.SetCursorPosition(x - 2, (Console.CursorTop - 1));
        System.Console.WriteLine(',');
        Console.SetCursorPosition(x, (Console.CursorTop - 1));

    }
    Array.Resize(ref array, array.Length - 1);
    return array;
}

int[] RandomFillArr(int size)
{
    System.Console.WriteLine("Введите диапазон чисел:");
    System.Console.WriteLine();
    int firstRange;
    int lastRange;
    int x = 0;
    while (!int.TryParse(Console.ReadLine(), out firstRange))
    {
        Console.SetCursorPosition(x, (Console.CursorTop - 1));
        System.Console.WriteLine("                ");
        Console.SetCursorPosition(x, (Console.CursorTop - 1));
    }
    x += (int)Math.Log10(firstRange) + 2;
    if (firstRange==0) x=2;
    Console.SetCursorPosition(x - 1, (Console.CursorTop - 1));
    System.Console.WriteLine('-');
    Console.SetCursorPosition(x, (Console.CursorTop - 1));

    while (!int.TryParse(Console.ReadLine(), out lastRange) || lastRange < firstRange)
    {
        Console.SetCursorPosition(x, (Console.CursorTop - 1));
        System.Console.WriteLine("                ");
        Console.SetCursorPosition(x, (Console.CursorTop - 1));
    }

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(firstRange, lastRange + 1);
    }
    return array;
}

int InputNum(string message)
{
    int num;
    do
    {
        System.Console.WriteLine(message);
    }
    while (!int.TryParse(Console.ReadLine(), out num));
    return num;
}

void ShowArray(int[] array)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Ваш массив:");
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void EndKey()
{
    System.Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGray;
    System.Console.WriteLine("Press any key to terminate...");
    Console.ResetColor();
    Console.ReadKey();
}

Header();

int size = InputNum("Введите размер массива. Для произвольного размера введите 0(ноль):");

System.Console.WriteLine();

if (size == 0)
{
    ShowArray(FreeSizedArr());
}
else
{
    int choose;
    do
    {
        choose = InputNum("Желаете заполнить массив самостоятельно(0), либо случайно(1)?:");
        System.Console.WriteLine();
    } while (choose != 0 && choose != 1);
    if (choose == 0) ShowArray(ArrayFill(size));

    else if (choose == 1) ShowArray(RandomFillArr(size));

}

EndKey();




