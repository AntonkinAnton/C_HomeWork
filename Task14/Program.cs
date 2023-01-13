//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 4523 -> 14

void Header()
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
    Console.WriteLine();
    Console.WriteLine("Программа показывает сумму цифр в числе (которое нарисует)");
    Console.WriteLine();

}

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

async void DigitSum(int num)
{                          // изначально цикл сложения был проще, т.к начинался с конца числа и делился остатком до нуля
    int result = 0;        // пришлось сделать его с начала числа для последовательного сложения
    int count;
    int degree;

    for (; num != 0; num %= degree)
    {
        count = (int)Math.Log10(num) + 1;
        degree = (int)Math.Pow(10, count - 1);
        result += num / degree;
        await Task.Delay(1050);
        Console.SetCursorPosition(12,10); //иногда "залетный" символ прилетает во время рисования цифр, видимо, беда терминала
        System.Console.Write(result);
        
    }
    
}

async void DrawNumb(int Num)
{
    string convert = Num.ToString();
    char draw;
    int x = 0;
    int y = 2;
    for (int i = 0; i < convert.Length; i++)
    {

        if (convert[i] == '1')
        {
            draw = '1';  //1
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 6+y);
            System.Console.Write(draw);
        }

        if (convert[i] == '2')
        {
            draw = '2';  //2
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
        }

        if (convert[i] == '3')
        {
            draw = '3';  //3
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, +y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 6+y);
            System.Console.Write(draw);
        }


        if (convert[i] == '4')
        {
            draw = '4';
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, +y);  //4
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
        }

        if (convert[i] == '5')
        {
            draw = '5';
            await Task.Delay(50);         //5
            Console.SetCursorPosition(x + 5, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 6+y);
            System.Console.Write(draw);
        }

        if (convert[i] == '6')
        {
            draw = '6';
            await Task.Delay(50);         //6
            Console.SetCursorPosition(x + 5, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 3+y);
            System.Console.Write(draw);
        }

        if (convert[i] == '7')
        {
            draw = '7';
            await Task.Delay(50);     //7
            Console.SetCursorPosition(x + 1, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
        }

        if (convert[i] == '8')
        {
            draw = '8';
            await Task.Delay(50);  //8
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 4+y);
            System.Console.Write(draw);
        }

        if (convert[i] == '9')
        {
            draw = '9';
            await Task.Delay(50);  //9
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 6+y);
            System.Console.Write(draw);
        }

        if (convert[i] == '0')
        {
            draw = '0';   //0
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 0+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 1+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 2+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 3+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 4+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 5, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 4, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 3, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 2, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 6+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 5+y);
            System.Console.Write(draw);
            await Task.Delay(50);
            Console.SetCursorPosition(x + 1, 4+y);
            System.Console.Write(draw);
        }
        x += 7;

    }
    Console.SetCursorPosition(0,0);
}

Header();

int Num = InputNum("Введите число:");

Console.Clear();

System.Console.WriteLine("Ваше число:");
DrawNumb(Num);
Console.SetCursorPosition(0,10);
System.Console.WriteLine("Cумма цифр: ");
DigitSum(Num);

Console.SetCursorPosition(0,12);
Console.ForegroundColor = ConsoleColor.DarkGray;
System.Console.WriteLine("Press any key to terminate...");
Console.ResetColor();
Console.ReadKey();
Console.Clear();