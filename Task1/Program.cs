//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//ждем ввод двух чисел, сверяем одно с другим, выводим макс.
Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine(" ");
Console.WriteLine("Программа показывает большее из двух чисел");
Console.WriteLine(" ");
Console.WriteLine("Введите первое число:");

int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
if (num1 > num2)
{
    Console.WriteLine("Число {0} больше", num1);
}
else if (num1 == num2)
{
     Console.WriteLine("Числа равны!");
}
else
{
    Console.WriteLine("Число {0} больше", num2);
}
Console.ReadKey();