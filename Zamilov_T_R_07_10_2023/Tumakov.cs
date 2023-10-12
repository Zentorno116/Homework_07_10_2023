using System;
using System.IO;

class Tumakov
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
    Console.ReadKey();
    Console.Clear();
        
        
     Console.WriteLine("Упражнение 6.2. Сложение матриц. ");
            int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int[,] matrix2 = {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };

            int[,] result = MultiplyMatrices(matrix1, matrix2);

            PrintMatrix(result);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new ArgumentException("Невозможно выполнить умножение матриц: количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
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



