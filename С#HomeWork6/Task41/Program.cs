// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] createArray()
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] Result = new int [size];
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите {i+1} элемент массива: ");
        Result[i] = int.Parse(Console.ReadLine());
    }
    return Result;
}

int greatThenNull(int[] array)
{
    int Result = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            Result++;
        }
    }
    return Result;
}


int[] arr = createArray();
System.Console.WriteLine($"Массив: {String.Join(", ", arr)}");
System.Console.WriteLine($"Элементов массива больше чем 0: {greatThenNull(arr)}");