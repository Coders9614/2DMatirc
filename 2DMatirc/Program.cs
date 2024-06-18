using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DMatirc
{
    internal class Program
    {
        public static void Rotate(int[][] matrix)
        {
            if(matrix == null) return;//edge case matrix is return nothing; 

            int n = matrix.Length;

            // Transpose the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // Reverse each row
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - 1 - j];
                    matrix[i][n - 1 - j] = temp;
                }
            }
        }

        public static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            int[][] matrix1 = new int[][]
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
            };

            Console.WriteLine("Original matrix:");
            PrintMatrix(matrix1);

            Rotate(matrix1);

            Console.WriteLine("Rotated matrix:");
            PrintMatrix(matrix1);

            int[][] matrix2 = new int[][]
            {
            new int[] { 5, 1, 9, 11 },
            new int[] { 2, 4, 8, 10 },
            new int[] { 13, 3, 6, 7 },
            new int[] { 15, 14, 12, 16 }
            };

            Console.WriteLine("Original matrix:");
            PrintMatrix(matrix2);

            Rotate(matrix2);

            Console.WriteLine("Rotated matrix:");
            PrintMatrix(matrix2);
            Console.ReadKey();
        }
    }
}
