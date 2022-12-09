// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int SumElementsOddPosition(int[] massive)                       //Функция вычисления суммы элементов, стоящих на нечётных позициях.
{
    int sum = 0;
    for (int i = 0; i < massive.Length; i += 2)                 //Цикл с шагом 2 для суммирования только нечетных позиций
    {
        sum = sum + massive[i];                                 //Суммирование элементов массива
    }
    return sum;
}


Console.Clear();
int[] massive = new int[10];                                    //Здесь вначале мы объявили массив MASSIVE, который будет хранить данные типа int.
                                                                //Далее используя операцию new,
                                                                //мы выделили память для 10 элементов массива: new int[10].
Random random = new Random();
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = random.Next(-100, 100);
}

Console.WriteLine(string.Join(", ", massive));                  //Выводим массив в строку
Console.WriteLine();
Console.WriteLine("Summa nechetnih chisel: " + SumElementsOddPosition(massive));       //Выводим количество четных чисел в массиве