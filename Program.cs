// // Задача №1. Напишите цикл,который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

// Console.WriteLine("введите число A: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("введите число B: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.Write($"Число A в степни числа B равна {GetNumber(A)}");

// //Метод
// int GetNumber (int limit)
// {
//     int number = A;
//     for (int i = 1;i < B;i++){
//         number = number * A;
//     }
//     return number;
// }

// Задача №2. Напигите прорамму, которая принимает на вход число и выдает сумму цифр в числе.

// Console.WriteLine("введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (a > 0)
// {
// int num = a % 10;
// a = a / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// // Задача №3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// int[] ArrAy = GetArrAy(8);
// Console.WriteLine($"[{String.Join(".",ArrAy)}]");

// int[] GetArrAy (int size)
// {
//     int[] ArrAy = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         ArrAy[i] = new Random().Next(25);
//     }
//     return ArrAy;
// }
