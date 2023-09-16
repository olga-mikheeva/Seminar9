/*Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int ReturnSumNumberHimDigits(int number)
{
    if(number == 0) return 0;
    return ReturnSumNumberHimDigits(number / 10) + (number % 10);    
}

int number = InputNum("Введите число: ");
int sum = ReturnSumNumberHimDigits(number);
Console.WriteLine(sum);