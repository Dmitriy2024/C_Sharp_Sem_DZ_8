/*
void ChangeRows(int[,] matr)
{
    int lastRowIndex = matr.GetLength(0) - 1;

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[0, i];
        matr[0, i] = matr[lastRowIndex, i];   
        matr[lastRowIndex, i] = temp; 
    }
}
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов
int sumColumn = 0; 
int row = 3;
int column = 4;
int StringSmallestSum = 0;
int StringMinSunElements = 0;
int NumberString = 0;

int[,] resArray = GetMatrix(row, column); 
PrintMatrix(resArray);
FinSallestSum(resArray);


int[,] GetMatrix(int m, int n)
{
int[,] matrix = new int[row, column];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1); j++)
   {
        matrix[i,j] = matrix[i,j] = new Random().Next(0, 100 + 1);
    }
}
        return matrix;

}
void PrintMatrix(int[,] array)
{
 for(int i = 0; i < array.GetLength(0); i++)
  
   {
      for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i, j] + "\t");
       }
       Console.WriteLine();
   }
}

void FinSallestSum(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    sumColumn = 0;
      for(int j = 0; j < array.GetLength(1); j++)
      {
       sumColumn = (sumColumn + array[i,j]);
      }   
   StringSmallestSum = sumColumn;
        if(i>0)
        {
          if(StringMinSunElements > StringSmallestSum)
           {
            StringMinSunElements = StringSmallestSum;
            NumberString = i;
           }
        }  
       else
        {
            StringMinSunElements = StringSmallestSum;
        }
    
     }
}  
    Console.Write("Cтрока с наименьшей суммой элементов =" +  (NumberString + 1));
