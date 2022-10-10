// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// // array[] = {intIndex[0], intIndex[1], intIndex[2]};
// int result = intIndex[1];
// Console.WriteLine(result);

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int index1(int n)
{
    int result = (n % 100) / 10;
    if (n > 99 & n < 1000) Console.WriteLine($"{result} - второе значение числа");

else 
{
    if (n > -1000 & n < -99) Console.WriteLine($"{result * -1} второе значение числа");
    else
    {
        Console.WriteLine($"Число {n} не трёхзначное");
    }
}   
return n;
}

int result = index1(n);