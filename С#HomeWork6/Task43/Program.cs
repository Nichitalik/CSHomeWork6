// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("введите b1: ");
int b1 = int.Parse(Console.ReadLine());
System.Console.Write("введите k1: ");
int k1 = int.Parse(Console.ReadLine());
System.Console.Write("введите b2: ");
int b2 = int.Parse(Console.ReadLine());
System.Console.Write("введите k2: ");
int k2 = int.Parse(Console.ReadLine());
if (k1 == k2 || b1 == b2) System.Console.WriteLine("Нет точек песечения");
else System.Console.WriteLine($"Координаты точки пересечеия: ({string.Join("; ", intersectionPoint())})");

float[] intersectionPoint()
{
    float b = b2 - b1;
    float k = k1 - k2;
    float x = b / k;
    float y = k1 * x + b1;
    float[] result = new float [2] {x, y};
    return result;
}
