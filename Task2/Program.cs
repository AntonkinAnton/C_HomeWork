// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// mod: программа принимает от трех чисел, выдает полученный массив, макс значение и его индекс
// Заполняем произвольный массив, находим большее из введенных, выводим массив и макс

Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine();
Console.WriteLine("Программа показывает большее из трех и более введенных в массив чисел");
Console.WriteLine();

int[] array = new int[1];
int index = 0;

Console.WriteLine("Введите первое число:");
array[index] = int.Parse(Console.ReadLine());
index++;
Array.Resize(ref array, index + 1);
Console.WriteLine("Введите второе число:");
array[index] = int.Parse(Console.ReadLine());
index++;
Array.Resize(ref array, index + 1);
Console.WriteLine("Введите третье число:");
array[index] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите следующее число, либо любой символ, чтобы завершить ввод:");

while (int.TryParse(Console.ReadLine(), out int input))
{
    index++;
    Array.Resize(ref array, index + 1);
    array[index] = input;
    Console.WriteLine("Введите следующее число, либо любой символ, чтобы завершить ввод:");
}
Console.WriteLine();
index = 0;
int max = array[index];
int lenght = array.Length;
int maxind = index;
while (index < lenght)
{
    if (array[index] > max)
    {
        max = array[index];
        maxind = index;     
    }
    index++;
}

Console.WriteLine("Массив: " + string.Join(", ", array));
Console.WriteLine();
Console.WriteLine("Наибольшее значение (и его индекс): " + max + "({0})", maxind);
Console.WriteLine();





