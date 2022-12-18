//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//mod: Занести значения в List
//получаем число N, начинаем перебор четных от 1 с внесением в List, с отсечкой по N

Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine();
Console.WriteLine("Программа показывает все четные числа от 1 до введенного числа");
Console.WriteLine();
Console.WriteLine("Введите число:");
Console.WriteLine();


int N = int.Parse(Console.ReadLine());
int count = 1;
List<int> Numbers = new List<int>();
while (count <= N)
{
    if (count % 2 == 0)
    {
        Numbers.Add(count);
    }
    count++;
}


Console.WriteLine(string.Join(":", Numbers));