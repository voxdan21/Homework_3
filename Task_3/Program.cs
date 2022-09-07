// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string GetTripleTable(int n)
{
    string tripleString = "";
    for (int i = 1; i <= n; i++)
    {
        if (i == n)
        {
            tripleString = tripleString + $"{Math.Pow(i, 3)}";
        }
        else
        {
            tripleString = tripleString + $"{Math.Pow(i, 3)}, ";
        }
    }
    return tripleString;

}


Console.Write("Input number: ");
int x = int.Parse(Console.ReadLine());
Console.Write($"Таблица кубов от 1 до {x} = {GetTripleTable(x)}");