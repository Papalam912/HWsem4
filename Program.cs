Console.Clear();

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("введите число: ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("введите степень: ");
// int B = int.Parse(Console.ReadLine());

// Console.WriteLine($"{A} в степени {B} = {Math.Pow(A,B)}");

// int Pow(int num, int rank)
// {
//     if (rank == 0) return 1;

//     int result = num;
//     for (int i = 2; i <= rank; i++)
//     {
//     result *= num;
// }
// return result;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"сумма цифр = {GetSumNums(num)}");

// int GetSumNums (int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] array = GetRandomArray(8,0,10);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }