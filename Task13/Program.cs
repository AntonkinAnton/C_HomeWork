// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)

//Сказано написать цикл, значит готовый метод Math.Pow не подойдет. Напишем свой ¯\_(ツ)_/¯

int InputNum(string message)
{
    int num;
    do
    {
        System.Console.WriteLine(message);
    }
    while (!int.TryParse(Console.ReadLine(), out num));
    return num;
}

void MyPow(int num, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
        result *= num;
    CW(num, degree, result);
}

string ToUpperIndex(int degree)
{
    string UpIndex = degree.ToString();
    string result = String.Empty;
    for (int i = 0; i < UpIndex.Length; i++)   //иногда нормально отображается верхний индекс, иногда "?". хз почему, терминал...
    {                                          
        if (UpIndex[i] == '0') result += '⁰';
        if (UpIndex[i] == '1') result += '¹';
        if (UpIndex[i] == '2') result += '²';
        if (UpIndex[i] == '3') result += '³';
        if (UpIndex[i] == '4') result += '⁴';
        if (UpIndex[i] == '5') result += '⁵';
        if (UpIndex[i] == '6') result += '⁶';
        if (UpIndex[i] == '7') result += '⁷';
        if (UpIndex[i] == '8') result += '⁸';
        if (UpIndex[i] == '9') result += '⁹';

    }
    return result;

}

void CW(int num, int degree, int result)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{num}{ToUpperIndex(degree)} = {result}");
}

void Header()
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
    Console.WriteLine();
    Console.WriteLine("Программа возводит указанное число в указанную степень");
    Console.WriteLine();

}

Header();

int num = InputNum("Введите число:");
int degree = InputNum("Введите степень:");

MyPow(num, degree);

Console.ReadKey();
