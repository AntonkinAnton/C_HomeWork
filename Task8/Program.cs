// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27


void CubeOfNumber (int arg)
{
    int[] Cube = new int[0];
for (int i = 1; i <= arg; i++)
{
    if (i != arg)
    {
        Array.Resize(ref Cube, i + 1);
        Cube[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
    }
    else Cube[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
}
Console.WriteLine($"Все кубы от 1 до {arg}:");
Console.WriteLine(string.Join(" → ", Cube));
}
int N;
Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine();
Console.WriteLine("Программа принимает на вход число выдаёт таблицу кубов чисел от 1 до этого числа");
Console.WriteLine();

do
{
    Console.WriteLine("Введите число:");
    Console.WriteLine();
} while (!int.TryParse(Console.ReadLine(), out N));
Console.WriteLine();

CubeOfNumber(N);
Console.ReadKey();


