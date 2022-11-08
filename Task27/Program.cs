// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigitsNumber(int a)
{
    int sum = 0;
    int b = 0;
    while (a >= 10)
    {
        b = a % 10;                  // Определяем последнюю цифру заданного числа  152 -> 2
        a = a / 10;                  // Отсекаем последнюю цифру числа 152 -> 15
        sum = sum + b;               // Суммируем последние цифры чисел 0 + 2 =2
    }
    sum = sum + a;                   // Когда значение "a" станет меньше 10, суммируем его с вышеуказанным значением "sum"
    return sum;

}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumDigitsNumber(num);
Console.WriteLine($"Summ digits number {num} is {result}");
