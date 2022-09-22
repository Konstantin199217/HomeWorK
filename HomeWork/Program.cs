void Zadanie1()
{
    Console.Write("Введите трехзначное чиcло  ");
    int numbers = int.Parse(Console.ReadLine());
    numbers = numbers / 10 % 10;
    Console.WriteLine(numbers);
}
void Zadanie2()
{
    Console.Write("Введите чиcло  ");
    int numbers = int.Parse(Console.ReadLine());
    numbers = numbers % 10;
    if( numbers < 100)
    {
        Console.WriteLine("Этой цифры нет");
        return;
    }
    Console.WriteLine(numbers);

}
void Zadanie3()
{
    Console.Write("Введите число от 1 до 7  ");
    int numbers = int.Parse(Console.ReadLine());
    if (numbers == 1)
    {
        Console.WriteLine("Это Понедельник");
        return;
    }
    if (numbers == 2)
    {
        Console.WriteLine("Это Вторник");
        return;
    }
    if (numbers == 3)
    {
        Console.WriteLine("Это Среда");
        return;
    }
    if (numbers == 4)
    {
        Console.WriteLine("Это Четверг");
        return;
    }
    if (numbers == 5)
    {
        Console.WriteLine("Это Пятница");
        return;
    }
    if (numbers == 6)
    {
        Console.WriteLine("Это Суббота. Выходной");
        return;
    }
    if (numbers == 7)
    {
        Console.WriteLine("Это Воскресенье. Выходной");
        return;
    }
}
Zadanie1();
Zadanie2();
Zadanie3();




