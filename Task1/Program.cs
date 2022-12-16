//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//ждем ввод двух чисел, сверяем одно с другим, выводим макс.
Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine(" ");
Console.WriteLine("Программа показывает большее из двух чисел");
Console.WriteLine(" ");
int num1;
int num2;
try 
{
Console.WriteLine("Введите первое число:");
 num1 = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Введите второе число:");
 num2 = int.Parse(Console.ReadLine());
}
catch 
{
    Console.WriteLine("Вы втираете какую-то дичь. Прощайте!");
    Console.ReadKey();
    return;
}
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