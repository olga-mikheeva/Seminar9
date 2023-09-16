/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/


int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

bool SwapNum(int num1, int num2)
{
    return(num2 > num1);
}

void PrintNumbers(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write(num1);
        return; 
    }
    if(SwapNum(num1, num2))
    {
        Console.Write(num1 + " ");
        PrintNumbers(++num1, num2); // ++num1 префиксный инкремент это когда сначала изменяется переменная, а потом она уже используется как аргумент  
    }
    else
    {
        Console.Write(num2 + " ");
        PrintNumbers(num1, ++num2);
    }

}

int firstNum= InputNum("Введите первое число: ");
int secondNum= InputNum("Введите второе число: ");
PrintNumbers(firstNum, secondNum);

// логика такая, какое бы число не было больше (т.е. ввели 2, 5 или 5, 2) мы в любом случае переворачиваем и выводим числа от меньшего к большему

// чтобы числа шли от большего к меньшему в случае когда ввели (5, 2) пропишем другую логику:

/*
void PrintNumbers(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write(num1);
        return; 
    }
    if(SwapNum(num1, num2))
    {
        Console.Write(num1 + " ");
        PrintNumbers(++num1, num2); // ++num1 префиксный инкремент это когда сначала изменяется переменная, а потом она уже используется как аргумент  
    }
    else
    {
        Console.Write(num1 + " ");
        PrintNumbers(--num1, num2);   
    }
}
*/