// Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
/*
Console.Write("Your num: ");
string num = Console.ReadLine();

int len = num.Length;
if (len == 5)
{
    bool Palindrom = true;
    for (int i = 0; i < len / 2; i++)
    {
        if (num[i] != num[(len - 1) - i])
        {
            Palindrom = false;
            break;
        }
    }
    Console.Write($"{num} -> {(Palindrom ? "Yes" : "No")}");
}
else
    Console.Write("Error"); 
*/

// Task 19 решение с помощью функции и цикла, и для всех чисел // не без помощи интернета (GPT)
/*
void Palindrom(int num)
{
    string numStr = num.ToString();
    int len = numStr.Length;

    for (int i = 0; i < len / 2; i++)
    {
        if (numStr[i] != numStr[len - 1 - i])
        {
            Console.WriteLine($"{numStr} -> No");
            return;
        }
    }
    Console.WriteLine($"{numStr} -> Yes");
}
Console.Write("your num: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);
*/

// Task 19 решение с сокращенным вариантом, то есть сокращение кода 
/*
bool Palindrom(int num)
{
    string numStr = num.ToString();
    int len = numStr.Length;

    for (int i = 0; i < len / 2; i++)
    {
        if (numStr[i] != numStr[len - 1 - i])
            return false;
    }
    return true;
}
Console.Write("your num: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num} -> {(Palindrom(num) ? "Yes" : "No")}");
*/

// Task 21 Сокращенный вариант
// A (3,6,8); B (2,1,-7), -> 15.84
/*
double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
}
string[] list = { "X1", "Y1", "Z1", "x2", "Y2", "Z2" };
double[] val = new double[6];

for (int i = 0; i < list.Length; i++)
{
    Console.Write($"{list[i]} = ");
    val[i] = Convert.ToInt32(Console.ReadLine()); // or ToDouble()
}

double distanse = Math.Round(GetDistance(val[0], val[1], val[2], val[3], val[4], val[5]), 2);
Console.WriteLine($"A ({val[0]},{val[1]},{val[2]}); B ({val[3]},{val[4]},{val[5]}) -> {distanse}");
*/
// Task 23 Сокращенный вариант
/*
void GetCub(int N)
{
    Console.Write($"{N} -> ");

    for (int i = 1; i < N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
    Console.Write($"{Math.Pow(N, 3)}");
}
Console.Write("Your N: ");
int N = Convert.ToInt32(Console.ReadLine());

GetCub(N);
*/
