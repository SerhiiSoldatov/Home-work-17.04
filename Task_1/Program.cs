// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");
int num;
num = int.Parse(Console.ReadLine());

int a = num / 10000;
int b = ((num / 1000) % 10);
int c = ((num / 100) %10);
int d = ((num / 10) %10);
int e = num %10;

if ((a == e) & (b == d))
    System.Console.WriteLine("Введённое Вами число является палиндромом");
else
    System.Console.WriteLine("Введённое Вами число НЕ является палиндромом");
