// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число (основание степени): ");
int numberBase = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (показатель степени): ");
int numberExponent = Convert.ToInt32(Console.ReadLine());

if (numberExponent > 0)
{
    int degree = DegreeNumber(numberBase, numberExponent);
    if (degree > 0) Console.WriteLine($"Число {numberBase} в степени {numberExponent} -> {degree}");
    else Console.WriteLine("Переполнение типа переменной");
}
else Console.WriteLine("Задан некорректный показатель степени");


int DegreeNumber(int num, int exp)
{
    int res = num;
    for (int i = 1; i < exp; i++)
    {
        try
        {
            checked
            { res = res * num; }
        }
        catch (Exception)
        {
            res = -1;
            break;
        }

    }
    return res;
}