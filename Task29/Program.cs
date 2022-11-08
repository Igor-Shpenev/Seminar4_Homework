// Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

int[] Massive(int a)
{
    int[] arr = new int[a];
    for (int i = 0; i < a; i++)
    {
        arr[i] = new Random().Next(0, 100);       // Заполняем массив рандомными цифрами от 1 до 99
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");              // Выводим на экран элементы массива
    }
    Console.Write("\b\b]");
}

Console.Write("Enter the length of the array: ");  // Запрашиваем у пользователя длинну массива
int lenght = Convert.ToInt32(Console.ReadLine());
PrintArray(Massive(lenght));