// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int FindEvenNumbers(int[] massive)              //Функция поиска четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0)                //Проверка числа на четность
        {
            count = count + 1;                  //счетчик четных чисел
        }
    }
    return count;
}

Console.Clear();
int[] massive = new int[10];                    //Здесь вначале мы объявили массив MASSIVE, который будет хранить данные типа int.
                                                //Далее используя операцию new, мы выделили память для 4 элементов массива: new int[10].
Random random = new Random();
for (int i = 0; i < massive.Length; i++)        //Цикл заполнения массив
{
    massive[i] = random.Next(100, 1000);        //Заполняем массив случайными трехзначными числами
}

Console.WriteLine(string.Join(", ", massive));  //Выводим массив в строку
Console.WriteLine();
Console.WriteLine("Kolichestvo chetnih chisel: " + FindEvenNumbers(massive));       //Выводим количество четных чисел в массиве
