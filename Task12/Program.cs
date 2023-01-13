//Напишите программу, которая принимает на вход число (А) и выдаёт сумму, произведение чисел от 1 до А.
void Setcolor(int clr)

{

    if (clr == 1) Console.ForegroundColor = ConsoleColor.White;
    else if (clr == 2) Console.ForegroundColor = ConsoleColor.Blue;
    else if (clr == 3) Console.ForegroundColor = ConsoleColor.Red;

}
int A;
int sum = 0;
long mult = 1;
int flag = 1;
bool show=false;
ConsoleKeyInfo Key;
do
{
    Console.Clear();
    Console.WriteLine("Программа показывает сумму и произведение чисел от 1 до A");
    Console.WriteLine();
    Console.WriteLine("Введите число:");
} while (!int.TryParse(Console.ReadLine(), out A));

do
{
    Console.WriteLine();
    Console.WriteLine($"Показать все числа от 1 до {A}? Y/N");
    Key = Console.ReadKey();
} while (Key.Key != ConsoleKey.Y && Key.Key != ConsoleKey.N);
if (Key.Key == ConsoleKey.N) show = false;
if (Key.Key == ConsoleKey.Y) show = true;
Console.WriteLine();
for (int i = 1; i <= A; i++, flag++)
{
    if (show)
    {
    Setcolor(flag);
    Console.Write(i);
    Console.Write(" ");
    }
    sum += i;
    mult *= i;
    flag %= 3;
}
Console.WriteLine();
Console.WriteLine();
Console.ResetColor();
Console.WriteLine($"Сумма = {sum}");

Console.WriteLine(mult == 0 && A > 0 ? "Произведение больше чем 9223372036854775807" : "Произведение = " + mult);

Console.WriteLine("Количество цифр числа " + A + " = " + ((int)Math.Log10(A) + 1));
Console.ReadKey();

