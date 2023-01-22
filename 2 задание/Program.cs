/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int GetNumber(string message)

{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

//метод для инициализации массива рандомными числами
int[,] InitArray(int rows, int columns, int leftBound, int rightBound)
{
    int[,] result = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {

            {
                result[i, j] = rnd.Next(leftBound, rightBound);
            }
          
        }
    return result;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {


            {
                Console.Write($"{array[i,j]} ");
            }
        }
            Console.WriteLine();
    }
    Console.WriteLine(); 

}

void getElement(int[,] array, int row, int column)
{
    if (row > array.GetLength(0) || row < 0 || column > array.GetLength(1) || column < 0)
    {
        Console.WriteLine("Элемента с указанной позицией нет");
    }
    else
    {
        Console.WriteLine("Элемент из указанной позиции - " + array[row-1, column-1]);
    }
}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int row = GetNumber("Введите строку искомого элемента");
int column = GetNumber("Введите столбец искомого элемента");



int[,] matrix = InitArray(rows, columns, leftBound, rightBound);
PrintArray(matrix);
getElement(matrix, row, column);


