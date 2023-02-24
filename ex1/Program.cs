/* Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber()
{

    int result = 0;
    while (true)
    {
        Console.WriteLine("Введите целое положительное число:");
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
    return result;
}

void WriteNumbers(int number)
{
    if (number == 1)
    {
        Console.Write("1");
    }
    else
    {
    Console.Write($"{number}  ");
    WriteNumbers(number - 1);
    }
}

int number = GetNumber();
WriteNumbers(number);

