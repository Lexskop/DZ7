/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(data);
    Console.ResetColor();
}

int randomNum(int min, int max)
{
    int num = new Random().Next(min, max);
    return num;
}

void printResultMatrix(int rows, int columns)
{
    printColorData($"Получили случайный двухмерный массив размером [{rows}, {columns}], -> ");
    int[,] table = new int[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j] = randomNum(-10, 10)}\t");
        }
        Console.WriteLine("");
    }
    printResult(table);
}

void printResult(int[,] currentTable)
{
    double sum = 0;
    double calc = 0;
    for (int i = 0; i < currentTable.GetLength(1); i++)
    {
        for (int j = 0; j < currentTable.GetLength(0); j++)
        {
            sum = sum + currentTable[j, i];
        }        
        calc = sum / currentTable.GetLength(0);
        Console.WriteLine($"Среднее арифметическое в {i + 1} столбце ->  {calc:N2}");
        sum = 0;
    }
    userAnotherTry();
}

void userAnotherTry()
{
    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    string? userChoice = Console.ReadLine();
    while (userChoice?.ToLower() != "y" && userChoice?.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
    if (userChoice == "y")
    {
        userData();
    }
    else
    {
        Console.WriteLine("Bye!");
    }
}

void userData()
{
    int userRows = randomNum(2, 5);
    int userColumns = randomNum(2, 5);
    printResultMatrix(userRows, userColumns);
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
userData();