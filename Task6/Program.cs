//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//<-------------------------Через инт число---------------------->
int CountDigits (int arg1)
{

int digits;
for (digits=0; arg1>0; digits++)
{
    arg1/=10;
}

return digits;
}
void Palindrome (int input, int dig)
{
int count = 0;
int CutOff = dig;
for (int i=0; i<CutOff/2; i++, dig-=2)
{
    if(input/Convert.ToInt32(Math.Pow(10,dig-1))==input%10)
    {
        count++;
    }

    input = input%Convert.ToInt32(Math.Pow(10, dig-1))/10;
}
Console.WriteLine(CutOff/2 == count ? "Число является палиндромом" : "Число не является палиндромом");
}

Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine();
Console.WriteLine("Программа принимает на вход ЛЮБОЕ число и проверяет, является ли оно палиндромом");
Console.WriteLine();
Console.WriteLine("Введите число:");
Console.WriteLine();

int InputNum;
while (!int.TryParse(Console.ReadLine(), out InputNum));
int digits = CountDigits(InputNum);
Palindrome(InputNum, digits);


// //<-----------------------------Через массив------------------------------>
// Console.Clear();
// int[] array = new int[1];
// int index = 0;
// int fill;
// Console.WriteLine("Введите числа массива");
// while (int.TryParse(Console.ReadLine(), out fill))
// {
//     Array.Resize(ref array, index + 1);
//     array[index] = fill;
//     index++;
// }
// int LenghtOfArray = array.Length;
// int compare = 0;
// for (int i = 0; i < array.Length / 2; i++, LenghtOfArray--)
// {
//     if (array[i] == array[LenghtOfArray - 1])
//     {
//         compare++;
//     }
// }
// Console.WriteLine("Введенный массив: " + string.Join("-", array));
// Console.WriteLine(array.Length / 2 == compare ? "Число является палиндромом" : "Число не является палиндромом");




// <----------------------------Через стринги------------------------------------->
// Console.Clear();
// Console.WriteLine("Введите число:");
// long NumbInput = long.Parse(Console.ReadLine());
// string Numb = Convert.ToString(NumbInput);
// int LenghtOfNumb = Numb.Length;
// int compare=0;
// for (int i =0; i<Numb.Length/2; i++, LenghtOfNumb--)
// {
//     if (Numb[i]==Numb[LenghtOfNumb-1])
//     {
//        compare++;
//     }
// }
// Console.WriteLine(Numb.Length/2 == compare ? "Число является палиндромом" : "Число не является палиндромом");