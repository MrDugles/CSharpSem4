// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetAnsw(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
        result = result * numA;
    return result;
}

int SetVal(string name)
{
    Console.Write($"Введите число {name}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void GetResult(int numA, int numB)
{
    Console.WriteLine($"{numA}, {numB} -> {GetAnsw(numA, numB)}");
}

int numA = SetVal("A");
int numB = SetVal("B");
GetResult(numA, numB);