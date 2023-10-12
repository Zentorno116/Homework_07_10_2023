using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Упражнение 6.1. Подсчёт гласных и согласных букв в документе.");
        string filePath = @"C:\Users\Тимур\OneDrive\Desktop\Текстовый документ.txt";

        try
        {
            string content = File.ReadAllText(filePath);

            int vowelCount = CountVowels(content);
            int consonantCount = CountConsonants(content);

            Console.WriteLine("Количество гласных букв: " + vowelCount);
            Console.WriteLine("Количество согласных букв: " + consonantCount);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        
        }


    }

    static int CountVowels(string text)
    {
        int vowelCount = 0;

        foreach (char c in text)
        {
            if (IsVowel(c))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }

    static int CountConsonants(string text)
    {
        int consonantCount = 0;

        foreach (char c in text)
        {
            if (IsConsonant(c))
            {
                consonantCount++;
            }
        }

        return consonantCount;
    }

    static bool IsVowel(char c)
    {
        switch (char.ToLower(c))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }

    static bool IsConsonant(char c)
    {
        if (char.IsLetter(c) && !IsVowel(c))
        {
            return true;
        }

        return false;
    }
}