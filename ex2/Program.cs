/* Задайте значения M и N. 
апишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message, int number)
{

    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1 && result>=number)
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

int GetSum(int firstnumber, int secondnumber)
{
    if (secondnumber == firstnumber) 
    {
        return firstnumber;
    }
    else
    {
    return secondnumber + GetSum(firstnumber, secondnumber - 1);
    }
}
int firstnumber = GetNumber("Введите первое число:", 0);
int secondnumber = GetNumber("Введите второе число:", firstnumber);
int sum = GetSum(firstnumber, secondnumber);
Console.WriteLine($"Сумма чисел от {firstnumber} до {secondnumber} равна {sum}");

