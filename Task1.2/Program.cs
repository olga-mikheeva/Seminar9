/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

string PrintNumbers(int n, int start)
{
    if (start == n) // у нас есть базовое условие и когда наше start-овое значение станет равным числу n, мы возвращаем наше число переведенное в строку
        return n.ToString(); // метод перевода числа в строку
    return start + " " + PrintNumbers(n, start + 1); // пока этого не произойдет мы возвращаем start-овое значение + будущую строку которая у нас будет в вызовах PrentNumbers
}

int number = InputNum("Введите число: ");
Console.WriteLine(PrintNumbers(number, 1));