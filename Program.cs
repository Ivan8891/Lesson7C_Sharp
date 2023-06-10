int EnterNumber (string message)
{
	Console.WriteLine(message);
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}
	
double[,] FillDoubleMatrix (int lengthI, int lengthJ, int min, int max)
{
	double [,] array = new double [lengthI, lengthJ];
	Random rand = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{	
			array [i, j] = rand.Next(min, max) + rand.NextDouble();
			array [i, j] = Math.Round(array[i, j], 1);
		}
	}
	return array;
}
	
int[,] FillMatrix (int lengthI, int lengthJ, int min, int max)
{
	int [,] array = new int [lengthI, lengthJ];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{	
			array [i, j] = new Random().Next(min, max);
		}
	}
	return array;
}	

void ValuePosition (int [,] array, int i, int j)
{
	int number = 0;
	if ( i < array.GetLength(0) && j < array.GetLength(1))
	{
		number = array[i, j];
		Console.WriteLine($"На позиции [{i}:{j}] сохранено значение: {number}.");
	}
	else Console.WriteLine($"В данном массиве позиции [{i}:{j}] несуществует.");
}

void PrintMatrix( int[,] array)
{
	for ( int i = 0; i < array.GetLength(0); i++)
	{
		for ( int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + "  ");
		}
		Console.WriteLine();
	}
}	
	
void PrintMatrixDouble( double[,] array)
{
	for ( int i = 0; i < array.GetLength(0); i++)
	{
		for ( int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}
		
void AverageValue(int [,] array)
{
	double average = 0;
	double sum = 0;		
	for (int i = 0; i < array.GetLength(0); i++)
	{
		average = 0;
		sum = 0;
		for ( int j = 0; j < array.GetLength(1); j++)
		{
			sum += array[j, i];
		}
		average = sum / array.GetLength(1);
		average = Math.Round(average, 1);
		Console.Write($"{average}  ");
	}
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Задача 47");
double[,] array = FillDoubleMatrix( EnterNumber ("Введите количество строк: "),
									EnterNumber ("Введите количество столбцов: "),
									EnterNumber ("Введите минимальное значение: "),
									EnterNumber ("Введите максимальное значение: "));
PrintMatrixDouble(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Задача 50");
int[,] matrix = FillMatrix( EnterNumber ("Введите количество строк: "),
							EnterNumber ("Введите количество столбцов: "),
							EnterNumber ("Введите минимальное значение: "),
							EnterNumber ("Введите максимальное значение: "));
PrintMatrix(matrix);
ValuePosition(matrix, EnterNumber("Введите индекс строки: "),
					  EnterNumber("Введите индекс столбеца: "));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.			  
// Console.WriteLine("Задача 52");
Console.WriteLine("Задача 52");
int[,] matrix1 = FillMatrix(EnterNumber ("Введите количество строк: "),
							EnterNumber ("Введите количество столбцов: "),
							EnterNumber ("Введите минимальное значение: "),
							EnterNumber ("Введите максимальное значение: "));
PrintMatrix(matrix1);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
AverageValue(matrix1);
