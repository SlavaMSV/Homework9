/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
A(m, n) = n + 1 при m=0
A(m, n) = A(m-1, 1) при m>0, n=0
A(m, n) = A(m-1, A(m, n-1)) при m>0, n>0
*/

int GetNumber(string message)
{

    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
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

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    if (n > 0 && m > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return Akkerman(m, n);
}

int m = GetNumber("Введите аргумент m:");
int n = GetNumber("Введите аргумент n:");
int akkerman = Akkerman(m, n);
Console.WriteLine($"Значение функции Аккермана: {akkerman}");
