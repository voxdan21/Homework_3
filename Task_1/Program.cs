// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


string CheckPalindrome(int x)
{
    string InvertedNumber = "";
    int copyX = x;
    // делаем переворот числа.
    while (copyX > 0)
    {
        InvertedNumber = InvertedNumber + copyX % 10;
        copyX = copyX / 10;
    }
    int makeNumber = int.Parse(InvertedNumber);
    // сравниваем заданное число с перевернутым
    if (makeNumber == x)
    {
        return "да";
    }
    else
    {
        return "нет";
    }


}



Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
string result = CheckPalindrome(num);
Console.Write($"Число {num} является палиндромом?: {result}");