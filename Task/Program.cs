// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// [”hello”, “2”, “world”, “:-)”] →[”2”, “:-)”]

// Функция вывода массива в консоль.

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

// Функция, выделяющая строки нужной длины.
string[] SelectByLength(int lengthToFind, string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthToFind)
        {

            count++;
        }
    }
    if (count == 0)
    {
        string[] arrayRes = new string[] { "Error" };
        return arrayRes;
    }
    else
    {
        string[] arrayRes = new string[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= lengthToFind)
            {
                arrayRes[count] = array[i];
                count++;
            }
        }
        return arrayRes;
    }

}

// Ввод данных пользователем и вызов функций.

Console.WriteLine("Введите элементы массива через пробел: ");
string[] array1 = Console.ReadLine()!.Split(" ");

string[] array2 = SelectByLength(3, array1);

PrintArray(array1);
Console.Write(" -> ");
PrintArray(array2);
Console.WriteLine();