/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int n)
{
    if (n > 0)
    {
        PrintNumbers(n -1); 
        Console.Write(n+ " ");
    }
}

int number = InputNum("Введите число: ");
PrintNumbers(number);

// вызываем функцию (например)f(5) положили ее в стек, дальше вызвали f(4) снова положили, затем f(3), f(2, f(1)
// как только условие n > 0 перестает выполняться начинаем вызывать: f(1) вызвалось, написали, дальше f(2) и т.д
// а если мы поменяем местами PrintNumbers(n -1);  и Console.Write(n+ " "); то печататься числа будут в порядке убывания.