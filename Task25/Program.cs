// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

int NumberPower(int num1, int num2)
{
    int sum = 1;
    for (int i = 1; i <= num2; i++)

        sum = sum * num1;
    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the degree of the number: ");
int degree = Convert.ToInt32(Console.ReadLine());

int result = NumberPower(number, degree);
Console.WriteLine($"The number {number} to the power of {degree} is {result}");





