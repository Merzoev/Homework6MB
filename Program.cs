// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// using System.Numerics;

// char[,] charArray = new char[,] {{'a','b'},{'c','d'}};

// string CreateStringFromCharArray(char[,] charArray)
// {
//     string result = "";
//     for (int i = 0; i < charArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < charArray.GetLength(1); j++)
//         {
//             result += charArray[i,j];
//         }
//     }
//     return result;
// }

// string s = "", symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
//             Random rnd = new Random()

// string [,] CreateCharMatrix(int rows, int columns, string a, string z)  // создание двухмерного массива
// {
//     string[,] matrix = new string [rows, columns];
//     string [,] s = new string [rows, columns];
//     string symb =""; 
//     s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//     Random rand = new();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next('s', 's'); 
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(string[,] matrix)        // вывод двухмерного массива
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine(CreateStringFromCharArray(charArray));
// Matrix<char> matrix = new Matrix<char>(3, 4, 'A', 'Z');

// // PrintMatrix(matrix);
// PrintMatrix(CreateCharMatrix(3, 4, "A", "Z"));





// CreateCharMatrix from random a to z import random

// characters = 'abcdefghijklmnopqrstuvwxyz'
// char_matrix = [random.choice(characters) for _ in range(10)]
// print(char_matrix)



//         int rows = 5;
//         int cols = 5;
//         char[,] matrix = GenerateRandomCharMatrix(rows, cols);

//         PrintMatrix(matrix);
    

    // static char[,] GenerateRandomCharMatrix(int rows, int cols)  // создание двухмерного массива
    
       
    // {
    //     char[,] matrix = new char[rows, cols];
    //     Random random = new Random();
    //     const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    //     // const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789

    //     for (int i = 0; i < rows; i++)
    //     {
    //         for (int j = 0; j < cols; j++)
    //         {
    //             matrix[i, j] = chars[random.Next(chars.Length)];
    //         }
    //     }

    //     return matrix;
    // }

//     static void PrintMatrix(char[,] matrix)  // вывод двухмерного массива
//     {
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }


// char[,] charArray = GenerateRandomCharMatrix ( 5,5);

// Console.WriteLine(CreateStringFromCharArray(charArray));


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
//  Сформируйте строку,в которой все заглавные буквы заменены на строчные.

// char[,] charArray = GenerateRandomCharMatrix ( 5,5);

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Исходная строка, содержащая латинские буквы в обоих регистрах
//         string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        
//         // Преобразование всех заглавных букв в строчные
//         string result = ToLowerCase(input);

//         // Вывод результата
//         Console.WriteLine("Исходная строка: " + input);
//         Console.WriteLine("Результирующая строка: " + result);
//     }

//     static string ToLowerCase(string input)
//     {
//         // Преобразуем строку в строчные буквы
//         return input.ToLower();
//     }
// }

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Исходная произвольная строка
//         string input = "A man a plan a canal Panama";

//         // Проверка, является ли строка палиндромом
//         bool isPalindrome = IsPalindrome(input);

//         // Вывод результата
//         Console.WriteLine($"Исходная строка: \"{input}\"");
//         Console.WriteLine($"Является ли палиндромом? {isPalindrome}");
//     }

//     static bool IsPalindrome(string input)
//     {
//         // Преобразуем строку к нижнему регистру и удаляем все пробелы
//         string cleanedInput = input.ToLower().Replace(" ", "");

//         // Получаем обратную версию строки
//         char[] charArray = cleanedInput.ToCharArray();
//         Array.Reverse(charArray);
//         string reversedInput = new string(charArray);

//         // Сравниваем исходную строку и её обратную версию
//         return cleanedInput == reversedInput;
//     }
// }