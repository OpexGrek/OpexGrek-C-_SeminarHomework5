// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int MaxMin(int[] massive)                                   //Функция поиска min и max значения массива и разницы между ними
{
    int dif = 0;
    int min = massive[0];
    int max = min;

    for (int i = 1; i < massive.Length; i++)
    {
        if (massive[i] > max)
            max = massive[i];
        if (massive[i] < min)
            min = massive[i];
    }
    Console.WriteLine("min= " + min);
    Console.WriteLine("max= " + max);
    return dif = max - min;
}


Console.Clear();
Console.WriteLine("Input array length");
int len = Convert.ToInt32(Console.ReadLine());                          //Ввели длину массива
Console.WriteLine("Input array");
int[] massive = new int[len];                                           //Создали массив, длина которого = Len
for (int i = 0; i < len; i++)
{
    massive[i] = Convert.ToInt32(Console.ReadLine());                   //Заполняем массив произвольными числами
}

Console.WriteLine(string.Join(", ", massive));                          //Выводим массив в строку
Console.WriteLine();
Console.WriteLine("Raznitsa: " + MaxMin(massive));                      //Выводим значение разницы между максимальным
                                                                        //и минимальным элементов массива
