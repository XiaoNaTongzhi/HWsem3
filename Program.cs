// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введи пятизначное число: ");
// int n = int.Parse(Console.ReadLine());

//  int b = n / 1000;
//  int d = n % 100;

// if ((b / 10) == (d % 10) && (b % 10) == (d / 10))

// {
//     Console.WriteLine("Палиндром.");
// }
// else
// {
// Console.WriteLine("НЕ палиндром.");
// }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координаты точек:");

// Console.Write("x1 = ");
// double x1 = double.Parse(Console.ReadLine());

// Console.Write("y1 = ");
// double y1 = double.Parse(Console.ReadLine());

// Console.Write("z1 = ");
// double z1 = double.Parse(Console.ReadLine());

// Console.Write("x2 = ");
// double x2 = double.Parse(Console.ReadLine());

// Console.Write("y2 = ");
// double y2 = double.Parse(Console.ReadLine());

// Console.Write("z2 = ");
// double z2 = double.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
// Console.Write($"Расстояние между точками -> {result:f2}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("Введи число: ");
// int n = int.Parse(Console.ReadLine());
// for (int a = 1; a <= n; a++)
// {
//     Console.Write($"{Math.Pow(a,3)}; ");
// }


// _________________________________

// С СЕМИНАРА:

// На вход координаты точки (ненулевые), выдаёт номер четверти на плоскости

// Первая попытка：

// Console.WriteLine("Введите координаты точки:");

// Console.Write("x = ");
// int x = int.Parse(Console.ReadLine());

// Console.Write("y = ");
// int y = int.Parse(Console.ReadLine());

// if ((x == 0) && (y == 0))
// {
//     Console.WriteLine("Точка находится на пересечении осей.");
// }

// else
// {
//     if (x == 0)
//     {
//         Console.WriteLine("Точка лежит на оси Y.");
//     }


//     else
//     {
//     if (y == 0)
//     {
//         Console.WriteLine("Точка лежит на оси X.");
//     }
    

//         else
//         {
//             if((x > 0) && ( y > 0))
//             {
//                 Console.WriteLine("Первая четверть.");
//             }

//             else
//             {
//                 if((x < 0) && (y < 0))
//                 {
//                     Console.WriteLine("Третья четверть.");
//                 }
//                  else
//                 {
//                     if((x < 0) && (y > 0))
//                     {
//                         Console.WriteLine("Вторая четверть.");
//                     }
//                     else
//                     {
//                         if((x > 0) && (y < 0))
//                         {
//                             Console.WriteLine("Четрвёртая четверть.");
//                         }
//                     }
//                 }
//             }
//         }
//     }
// }


// _______________________________________________

// Переписано через else if：

// Console.WriteLine("Введите координаты точки:");

// Console.Write("x = ");
// int x = int.Parse(Console.ReadLine());

// Console.Write("y = ");
// int y = int.Parse(Console.ReadLine());

// if ((x == 0) && (y == 0))
// {
//     Console.WriteLine("Точка находится на пересечении осей.");
// }

// else if (x == 0)
//     {
//         Console.WriteLine("Точка лежит на оси Y.");
//     }

// else if (y == 0)
//     {
//         Console.WriteLine("Точка лежит на оси X.");
//     }
    
// else if((x > 0) && ( y > 0))
//     {
//         Console.WriteLine("Первая четверть.");
//     }

// else if((x < 0) && (y < 0))
//     {
//         Console.WriteLine("Третья четверть.");
//     }
// else if((x < 0) && (y > 0))
//     {
//         Console.WriteLine("Вторая четверть.");
//     }
// else if((x > 0) && (y < 0))
//     {
//         Console.WriteLine("Четрвёртая четверть.");
//     }


// РАССТОЯНИЕ МЕЖДУ ТОЧКАМИ

// Console.WriteLine("Введите координаты точек:");
// Console.Write("x1 = ");
// double x1 = double.Parse(Console.ReadLine());
// Console.Write("y1 = ");
// double y1 = double.Parse(Console.ReadLine());
// Console.Write("x2 = ");
// double x2 = double.Parse(Console.ReadLine());
// Console.Write("y2 = ");
// double y2 = double.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
// Console.Write($"Расстояние между точками -> {result:f2}");


// ТАБЛИЦА КВАДРАТОВ ЧИСЕЛ ОТ 1 ДО N

// Console.Write("Введи число: ");
// int n = int.Parse(Console.ReadLine());
// for (int a = 1; a <= n; a++)
// {
//     Console.Write($"{Math.Pow(a,2)}; ");
// }

