// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// [”hello”, “2”, “world”, “:-)”] →[”2”, “:-)”]

// Функция вывода массива в консоль.

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

// Функция, выделяющая строки нужной длины.

// Ввод данных пользователем и вызов функций.
Console.WriteLine("Сколько элементов Вы хотите ввести?");
int lengthArray1 = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[lengthArray1];
Console.WriteLine("Введите элементы массива через пробел: ");
for (int i = 0; i < lengthArray1; i++)
{
    array1[i] = Console.ReadLine();
}

PrintArray(array1);