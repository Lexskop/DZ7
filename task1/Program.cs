/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(data);
    Console.ResetColor();
}

double randomNum(int min, int max)
{
    int num1 = new Random().Next(min, max);
    double num2 = new Random().NextDouble();
    double sum = num1 + num2;
    return sum;
}

void printResult(int rows, int columns)
{
    printColorData($"Получаем двухмерный массив размером [{rows}, {columns}], заполненный вещественными числами -> ");
    double[,] table = new double[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j] = randomNum(-10, 10):N1}\t");
        }
        Console.WriteLine("");
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
    Console.WriteLine("Введите число строк");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    printResult(userRows, userColumns);
}

Console.Clear();
Console.WriteLine("Приветствую! Вы задаёте двумерный массив размером mxn, а программа заполняет его случайными вещественными числами");
userData();