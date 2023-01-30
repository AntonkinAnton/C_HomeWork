//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.


void NaturalNums(int n) 
{ 
    if (n == 0) return;
    System.Console.WriteLine(n);
    NaturalNums(n-1);

} 
NaturalNums(5);




//----------------------------------------------Next Task-------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120


// void NaturalNums(int n, int m, ref int summ)
// {
//     if (n != m)
//     {
//         summ += n;
//         NaturalNums(n-1, m, ref summ);
//     }
    
// }

// int summ = 1;

// NaturalNums(15, 1, ref summ);

// System.Console.WriteLine(summ);




//-------------------------------------------------Next Task------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if (m != 0 && n == 0)
//         return Akkerman(m - 1, 1);
//     else 
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// System.Console.WriteLine(Akkerman(3,2));