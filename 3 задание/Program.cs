/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

// Метод печати матрицы
void PrintTwoDimensionalArray(int [,] array)
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

//Метод нахождения среднего арифмитического столбцов
void getAverage(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i,j];
        }
        average = average / array.GetLength(0);
        int count = j+1;
        Console.WriteLine($"Среднее арифмитическое {count} стольбца = {average}");
        average = 0;
    }
}


int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");

int[,] matrix = InitArray(rows, columns, leftBound, rightBound);
PrintTwoDimensionalArray(matrix);
getAverage(matrix);



