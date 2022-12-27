// В первой и единственной строке входных данных записано целое число w (1 ≤ w ≤ 100) — вес купленного ребятами арбуза
// 10 кг арбуз
// ВЫВОД
// 2 8
// 4,6
// 6,4
// 8,2


void CutMelon (int arg)
{
if (arg % 2 == 0)
{
    int i;
    int count=0;
    Console.WriteLine("Арбуз можно разделить на четные кусочки:");
    for (i = 2; i < arg; i += 2, count++)
    {
        Console.WriteLine($"{i}кг и {arg - i}кг"); 
    }
    Console.WriteLine();
    Console.WriteLine($"Всего {count} вариаций");

}
else Console.WriteLine("Арбуз не клетка. Ровно не делится");
}
void Header ()
{
Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine();
Console.WriteLine("Введите вес арбуза в кг от 1 до 100:");
}

Header();
int WMelon; 
while (!int.TryParse(Console.ReadLine(), out WMelon) || WMelon<1 || WMelon > 100)
{
Header();
}

Console.WriteLine();
CutMelon(WMelon);
Console.ReadKey();
