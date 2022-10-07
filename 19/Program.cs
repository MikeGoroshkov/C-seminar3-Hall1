//Задача 19: Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет 23432 -> да 12821 -> да
Console.Write("Введите пятизначное число n: ");
int n = int.Parse(Console.ReadLine());
int n1 = n/10000;
int n2 = (n/1000)%10;
int n4 = (n/10)%10;
int n5 = n%10;
Console.Write(n1);
Console.Write(n2);
Console.Write(n4);
Console.Write(n5);
if (n1 == n5 && n2 == n4) {Console.WriteLine($"Число {n} является палиндромом");}
else {Console.WriteLine($"Число {n} не является палиндромом");}