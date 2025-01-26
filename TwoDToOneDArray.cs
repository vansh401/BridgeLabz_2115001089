using System;

class TwoDToOneDArray
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Enter the elements of the 2D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element [" + i + "," + j + "]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[] array = new int[rows * columns];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }

        Console.WriteLine("The elements of the 1D array are:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
