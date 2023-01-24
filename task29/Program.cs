// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void GetNum(int number)
{
    int[] array = new int[number];
    foreach (int i in array)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]} ");
    }
}

int SetVal()
{
    Console.Write("Задайте размерность массива: ");
    return int.Parse(Console.ReadLine());
}

int num = SetVal();
GetNum(num);
