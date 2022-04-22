// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int n = 5;
int i = 1;
while (i < n)
{
    System.Console.Write($"{i * i}, ");
    i++;
}
System.Console.Write($"{n * n * n}.");