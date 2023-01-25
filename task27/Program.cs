// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumm(string inBox)
{
    int num = int.Parse(inBox);
    int result = 0;
    for (int i = 0; i < inBox.Length; i++)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

string SetVal()
{
    Console.Write("Введите число: ");
    return Console.ReadLine();
}

void GetResult(string box)
{
    Console.WriteLine($"{box} -> {GetSumm(box)}");
}

string box = SetVal();
GetResult(box);
