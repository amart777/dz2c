//Console.WriteLine("Введите натуральное число ");
//int x=Convert.ToInt32 (Console.ReadLine());
//int y = x*x;
//Console.WriteLine("Вот посчитали квадрат введенного вами числа и это цифра - "+y);
//if (x==8)
//{
//   Console.WriteLine("Вы ввели восемь");
//}
//else Console.WriteLine("Вы ввели число отличное от 8");
//int i = 0;
//while (i<x)
//{
//    Console.WriteLine($"Счетчик цикла равен {i}");
//    i=i+1;
//}
// Console.WriteLine("Введите первое число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int y=Convert.ToInt32 (Console.ReadLine());
// if (x*x == y) Console.WriteLine("Второе число является квадратом первого");
// else if (y*y == x) Console.WriteLine("Первое число является квадратом второго");
// else Console.WriteLine("Нет");

// ДЗ 1 Задача 2
// Console.WriteLine("Введите первое число ");
// int a=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b=Convert.ToInt32 (Console.ReadLine());
// if (a > b) Console.WriteLine($"Первое число больше второго и равно {a}");
// else if (a < b) Console.WriteLine($"Второе число больше первого и равно {b}");
// else Console.WriteLine("Числа равны");

// ДЗ 1 Задача 4
// Console.WriteLine("Введите первое число ");
// int a=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите третье число ");
// int c=Convert.ToInt32 (Console.ReadLine());
// int i=0;
// if (a > b) i=a;
// else i=b;
// if (i < c) i=c;
// Console.WriteLine($"Максимальное из трех чисел = {i}");

// ДЗ 1 Задача 6
// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// int y=x % 2;
// if (y == 0) Console.WriteLine("Число чётное");
// else Console.WriteLine("Число не чётное");

// ДЗ 1 Задача 8
// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// int i = 1;
// while (i <= x)
// {
//     if (i % 2 == 0) Console.Write(i+", "); 
//     i=i+1;
// }
// ___________________________________________________________________________________
// Домашнее Задание 2
// ___________________________________________________________________________________
// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число ");
int x=Convert.ToInt32 (Console.ReadLine());
int y0=x/10;
int y1= y0 % 10;
Console.WriteLine($"Второе число {y1}");




// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// int y0=x/100;
// int y1= y0 % 10;
// int y2= x % 10;
// int y3=x/1000;
// int y4= y3 % 10;
// if (y1 == 0 && y0 <= 0) Console.WriteLine("Третьей цифры нет ");
// else if (y4 > 0) Console.WriteLine($"Третья цифра {y1}");
// else Console.WriteLine($"Третья цифра {y2}");

// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет,
//  является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру, обозначающую день недели (Например: понедельник 1, воскресенье 7)");
// int x=Convert.ToInt32 (Console.ReadLine());
// if (x < 6) Console.WriteLine("Нет. Это не выходной");
// if (x == 6 || x==7) Console.WriteLine("Да. Это выходной");
// else if (x == 0 || x > 7) Console.WriteLine($"цифра {x} не соответствует дню недели");