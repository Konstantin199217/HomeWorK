void Zadanie1()
{
    Console.Write("Введите трехзначное чило  ");
    int numbers = int.Parse(Console.ReadLine());
    numbers = numbers / 10 % 10;
    Console.WriteLine(numbers);
}






