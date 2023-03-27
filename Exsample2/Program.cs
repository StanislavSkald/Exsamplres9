// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int Number(string input)
{
  Console.Write(input);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int [,] GetRandomMatrix (int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
       {
        matrix[i, j] = Random.Shared.Next(1, 11);
       }
    }   
    return matrix;
}

void printMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write (matrix[i, j] + "  ");
        }
    Console.WriteLine();
    
    }
}


Console.WriteLine($"Введите размер массива m x n:");
int m = Number ("Введите m: ");
int n = Number ("Введите n: ");
int [,] myMatrix = GetRandomMatrix (m, n);
printMatrix (myMatrix);

int min = 0;
int sum = SumElem(myMatrix, 0);
for (int i = 1; i < myMatrix.GetLength(0); i++)
{
  int temp = SumElem(myMatrix, i);
  if (sum > temp)
  {
    sum = temp;
    min = i;
  }
}

Console.WriteLine($"{min+1} - строкa с наименьшей суммой ({sum}) элементов ");


int SumElem(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
