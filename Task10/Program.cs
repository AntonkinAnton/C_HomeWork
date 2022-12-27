//Задать N и вывести # до N елочкой 
void Header()
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
    Console.WriteLine();
    Console.WriteLine("Рисуем ёлочку до N четного и нечетного");
    Console.WriteLine();
    Console.WriteLine("Введите толщину основания:");
}
void Setcolor(int clr)

{
    if (clr == 1) Console.ForegroundColor = ConsoleColor.Blue;
    else if (clr == 2) Console.ForegroundColor = ConsoleColor.Cyan;
    else if (clr == 3) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 4) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 5) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 6) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 7) Console.ForegroundColor = ConsoleColor.DarkMagenta;
    else if (clr == 8) Console.ForegroundColor = ConsoleColor.DarkRed;
    else if (clr == 9) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 10) Console.ForegroundColor = ConsoleColor.Gray;
    else if (clr == 11) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 12) Console.ForegroundColor = ConsoleColor.Magenta;
    else if (clr == 13) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 14) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 15) Console.ForegroundColor = ConsoleColor.Yellow;
}
int N;
Header();
while (!int.TryParse(Console.ReadLine(), out N))
{
    Header();
}
int i;
int clr;
string hashes;
string spaces;
int CountSpaces = N;
while (true)
{
for (i=1; i <= N; i+=2, CountSpaces-=2)
{
    if (i==1)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    // else Console.ForegroundColor = ConsoleColor.Green;  - для статичной зеленой елки

    spaces =new string (' ', CountSpaces/2);
    if (N%2==0)       //для четного N  (и пусть макушка чуть набекрень....)
    {
        if (i == 1)
        {
            Console.WriteLine($"{spaces} #");
            // Console.ForegroundColor = ConsoleColor.Green;
        }
       hashes =new string ('#', i+1); 
    }
     else hashes =new string ('#', i);
    Console.WriteLine(spaces+hashes);
    Console.ResetColor();
    Setcolor(clr=new Random().Next(1, 16));
}
Console.WriteLine();
Console.WriteLine("С НАСТУПАЮЩИМ НОВЫМ ГОДОМ!!!");
Thread.Sleep(200);
Console.Clear();
CountSpaces=N;
}
//<-----------------------------------Через Сеткурсорпозишн------------------------------------->
// Console.Clear();
// int Ypos = 1;
// for (i = 1; i <= N; i +=2, CountSpaces -= 2, Ypos++)
// {
//     Console.SetCursorPosition(CountSpaces / 2, Ypos);
//     hashes =new string ('#', i);
//     Console.WriteLine(hashes);
// }