// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

//определение длины числа(чтобы проверять паллидромы не только 5 чисел)
int GetWholeDigitCount(int x)
{
    int count = 1;
    while ((x /= 10) > 0) ++count;
    return count;
}

//вариант без массива более симпатичный по моему мнению. Сделал для любого числа.
string CheckPalindrome(int x)
{

    if (x < 10)
    {
        return "нет";
    }
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

// вариант с массивом 
string CheckPalindrome2(int x)
{
    if (x < 10)
    {
        return "нет";
    }
    else
    {
        int copyX = x;
        int DigitCount = GetWholeDigitCount(x);
        int[] nums1 = new int[DigitCount];
        int[] nums2 = new int[DigitCount];
        for (int i = 0; i < DigitCount; i++)
        {
            nums1[i] = copyX % 10;
            nums2[DigitCount - (i + 1)] = copyX % 10;
            copyX = copyX / 10;
        }
        if (nums1.SequenceEqual(nums2))
        {
            return "да";
        }
        else
        {
            return "нет";
        }
    }
}


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

//вариант 1
//string result = CheckPalindrome(num);

//вариант 2
string result = CheckPalindrome2(num);


Console.Write($"Число {num} является палиндромом?: {result}");



