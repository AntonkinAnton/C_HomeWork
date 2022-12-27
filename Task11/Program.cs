Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine();
Console.WriteLine("Программа для расчета ликвидности покупки жилья");
Console.WriteLine();
Console.WriteLine("Сколько у вас налички?");
double Cash = double.Parse(Console.ReadLine());
Console.WriteLine("Какой годовой % вклада?");
double Invest = double.Parse(Console.ReadLine());
Console.WriteLine("Сколько стоит квартира?");
double FlatPrice = double.Parse(Console.ReadLine());
Console.WriteLine("Какой % инфляции?");
double Inflation = double.Parse(Console.ReadLine());
Console.WriteLine();
int Years;
if (Cash < FlatPrice)
{
    if (Invest > Inflation)
    {
        for (Years = 0; Cash < FlatPrice; Years++)
        {
            Cash = Cash * (1 + Invest / 100);
            FlatPrice = FlatPrice * (1 + Inflation / 100);

        }
        Console.WriteLine($"Вы сможете купить квартиру всего через {Years} лет");
    }
    else Console.WriteLine("Плохие новости...Может стоит выбрать квартиру подешевле?");
}
else Console.WriteLine("Дружище, беги покупай квартиру сейчас!");
Console.ReadKey();