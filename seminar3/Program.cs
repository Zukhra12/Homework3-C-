/* TASK1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome (int num)
{
      int a = num / 10000;
      int b = num / 1000 % 10;
      int c = num / 10 % 10;
      int d = num % 10;
   if (a == d && b == c)
   {
      Console.WriteLine("Hip, hip, hooray!");
      Console.WriteLine("This five-digit number is a palindrome :)");
   }
   else
   {
      Console.WriteLine("It's not a palindrome :(");
      Console.WriteLine("Try again.");
   }
} 

 Console.Write("Enter five-digit number: ");
 int num = Convert.ToInt32(Console.ReadLine());
 Palindrome(num);*/

/*TASK2

 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 
 double Distance (double xa, double ya, double za, double xb, double yb, double zb)
 {
    double distance =Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
    return distance;
 }

 Console.Write("Enter X coordinates of point A: ");
 int xa = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter Y coordinates of point A: ");
 int ya = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter Z coordinates of point A: ");
 int za = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter X coordinates of point B: ");
 int xb = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter Y coordinates of point B: ");
 int yb = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter Z coordinates of point B: ");
 int zb = Convert.ToInt32(Console.ReadLine());

 double distance = Distance (xa, ya, za, xb, yb, zb);
 Console.Write($"Distanace between points AB = {distance} "); */

 /*TASK3 
 Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N 

 void Num (double number)
 { int res = 1;
   while (res <= number)
   {
    Console.Write(res*res*res + " ");
    res++;
   }
 }
Console.Write("Enter the positive number: ");
double number = Convert.ToInt32(Console.ReadLine());
if (number < 0) 
Console.Write("Pray, enter the positive number!");
Num(number);*/

