/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
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
    printResult(table, 0);
}

void printResult(int[,] currentTable, int userNumber)
{
    Console.WriteLine("Введите позицию элемента:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < currentTable.GetLength(0); i++)
    {
        for (int j = 0; j < currentTable.GetLength(1); j++)
        {
            count++;
            if (count == userNumber)
            {
                Console.WriteLine($"Ваш элемент -> {userNumber}. Значение -> {currentTable[i, j]}");
                break;
            }
        }
    }
    if (count < userNumber)
    {
        Console.WriteLine($"Ваш элемент -> {userNumber}. Такой элемент отсуствует");
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