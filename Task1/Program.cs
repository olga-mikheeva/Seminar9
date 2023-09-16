/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int n, int count) // в void можем прописать return без значения
{
    if (count < n)
    {
        count++;
        Console.Write(count+ " ");
        PrintNumbers(n, count); // и снова вызывается функция, внутри т.к. вызов функции должен быть под условием
    }
    
}

int number = InputNum("Введите число: ");
PrintNumbers(number, 0);

