// Задача 19 HARD - необязательная
// Напишите программу, которая принимает на вход число любой размерности и проверяет, 
// является ли оно палиндромом.
void Palindrome(int number)
{
    int number1 = number;
    int result = 0;

    while (number1 > 0)
    {
        result *= 10;
        result += number1 % 10;
        number1 /= 10;
    }
    if (number == result)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом.");
    }
}
Console.Write("Введе число: ");
Palindrome(Int32.Parse(Console.ReadLine()));
