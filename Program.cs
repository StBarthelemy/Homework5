﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomNumbers_(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandomNumbers_(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных.");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




Console.WriteLine($"Введи длину массива: ");
int ElementNumbers = Convert.ToInt32(Console.ReadLine()); 
int randomNumber =  RandomNumbers(ElementNumbers, 1, 10);
Console.WriteLine($"  Сумма элементов, стоящих на нечётных позициях: {randomNumber}");



int RandomNumbers(int ElementNumbers, int min, int max)
  {
  int[] randomNumber = new int[ElementNumbers];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(min, max);

      Console.Write(randomNumber[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
  return sumElements;
  }




// Задача 38: Задайте с клавиатуры массив ыещественных (double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] => 76

Console.WriteLine("Введите размер массива  ");
int size_ = Convert.ToInt32(Console.ReadLine());
double[] numbers_ = new double[size_];
FillArrayRandomNumbers(numbers_);
Console.WriteLine("массив: ");
PrintArray(numbers_);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int b = 0; b < numbers_.Length; b++)
{
    if (numbers_[b] > max)
        {
            max = numbers_[b];
        }
    if (numbers_[b] < min)
        {
            min = numbers_[b];
        }
}

Console.WriteLine($"всего {numbers_.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers_.Length; i++)
        {
            numbers_[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers_)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers_.Length; i++)
        {
            Console.Write(numbers_[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
//1 и 2 задача работает вот 3 нет(
