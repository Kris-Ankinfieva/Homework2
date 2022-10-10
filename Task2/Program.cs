// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int random = new Random().Next(-999, 1000);

int FilNumber(int number)
{
    Console.Write($"Случайное трёхзначное число: {random} ");
    return number;
}
int DelNumber(int n)
{
    int n1 = (n % 1000) / 100;
    int n2 = random % 10;
    if (n > 100 & n < 1000) System.Console.Write($"-> {n1}{n2}");
    else
    {
    if (n > -999 & n < -99) System.Console.Write($"-> {n1}{n2 * -1}");
    else
    {
        Console.Write("- число не является трёхзначным");
    }
    }
    return n;
}
int result = (DelNumber(FilNumber(random)));