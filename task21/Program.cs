﻿Console.WriteLine("Введите первую точку");
int ax = int.Parse(Console.ReadLine()!);
int ay = int.Parse(Console.ReadLine()!);
int az = int.Parse(Console.ReadLine()!);


Console.WriteLine("Введите вторую точку");
int bx = int.Parse(Console.ReadLine()!);
int by = int.Parse(Console.ReadLine()!);
int bz = int.Parse(Console.ReadLine()!);

double ab = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));
Console.WriteLine($"{ab:f2}");