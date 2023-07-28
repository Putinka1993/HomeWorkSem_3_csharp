
Console.WriteLine("Введите число ");
string num = Console.ReadLine()!;

if (num.Length == 5)
{
    if (num[0] + num[1] == num[4] + num[3])
    {
        Console.WriteLine("Число является палиндромом ");
    }
    else Console.WriteLine("Число не является палиндромом ");
}
else Console.WriteLine("Некорректное число, число должно быть пятизначным ");