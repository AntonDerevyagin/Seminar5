// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите длину массива");
int Long = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [Long];
int count = 0;
FillArrayRandomNumbers(numbers);


for (int i = 0; i < numbers.Length; i = i +2)
{
    count = count + numbers[i];
}
Console.WriteLine($"Сумма цифр не нечетных позициях = {count}");



void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,20);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}