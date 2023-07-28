Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);

int index = 1;

while (index <= num)
{
    Console.WriteLine(Math.Pow(index, 3));
    index++;
}