// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int PrintNumber(int msg)
{
    if (msg > 99) Console.Write($"-> {msg % 10}");
    else
    {
        if (msg < -99) Console.Write($"-> {(msg % 10) * -1}");
        else
        {
            Console.Write("-> число не является трёхзначным");
        }
    }
    return msg;
}
int DevisionNumber(int N)
{
    while (N > 1000 || N < -1000)
    {
        N /= 10;
    }
    Console.Write($"{number} ");
    return N;
}

int max = (PrintNumber(DevisionNumber(number)));