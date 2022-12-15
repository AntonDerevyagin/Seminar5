// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] number = new int [123];
int count = 0;
FillArrayRandomNumbers(number);


for (int i = 0; i < number.Length; i++)
{
    if (number[i] > 10 && number[i] < 100)
    {
        count++;
    }
    
}
Console.WriteLine($"Количество элементов в диапозоне от 10 до 99 = {count}");


void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,150);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}