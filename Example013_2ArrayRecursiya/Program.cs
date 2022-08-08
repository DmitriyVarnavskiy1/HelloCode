/*
string[,] table = new string[2, 5];
// String.Empty
// table[0,0]   table[0,1]  table[0,2]  table[0,3] table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,3] table[1,4]

table[1, 2]= "Слово";

for (int stroki = 0; stroki < 2; stroki++)
{
    for (int stolbci = 0; stolbci < 5; stolbci++)
    {
        Console.WriteLine($"{table[stroki, stolbci]}--");
    }
}
*/

int[,] matrix= new int[3,4];

PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int [,] matrix) //метод заполняющий массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(1,11);// от 1 до 10 интервал
        }
    }
}

