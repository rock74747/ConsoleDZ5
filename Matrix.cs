using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDZ5
{
    public class Matrix
    {


        int[,] matrix;

        public Matrix(int size, int size1)
        {
            
            matrix = new int[size, size1];
        }

        public int this[int size, int size1] //  Индексатор матрицы
        {
            get
            {
                    return matrix[size, size1];
            }
            set { matrix[size, size1] = value;  }
        }

        public static Matrix operator +(Matrix v1, Matrix v2) // Сложение
        {
            Matrix result = new Matrix(v1.matrix.GetLength(0), v1.matrix.GetLength(1));
            for (int i = 0; i < v1.matrix.GetLength(0); ++i)
                for (int j = 0; j < v1.matrix.GetLength(1); ++j)
                    result.matrix[i, j] = v1.matrix[i, j] + v2.matrix[i, j];
            return result;
        }

        public static Matrix operator *(Matrix v1, Matrix v2)    // Умножение
        {
            Matrix result = new Matrix(v1.matrix.GetLength(0), v1.matrix.GetLength(1));
            for (int i = 0; i < v1.matrix.GetLength(0); ++i)
                for (int j = 0; j < v1.matrix.GetLength(1); ++j)
                    result.matrix[i, j] = v1.matrix[i, j] * v2.matrix[i, j];
            return result;
        }

        public static Matrix operator -(Matrix v1, Matrix v2) // Вычитание
        {
            Matrix result = new Matrix(v1.matrix.GetLength(0), v1.matrix.GetLength(1));
            for (int i = 0; i < v1.matrix.GetLength(0); ++i)
                for (int j = 0; j < v1.matrix.GetLength(1); ++j)
                    result.matrix[i, j] = v1.matrix[i, j] - v2.matrix[i, j];
            return result;
        }


        public static Matrix operator *(Matrix v1, int chislo)    // Умножение на число
        {
            Matrix result = new Matrix(v1.matrix.GetLength(0), v1.matrix.GetLength(1));
            for (int i = 0; i < v1.matrix.GetLength(0); ++i)
                for (int j = 0; j < v1.matrix.GetLength(1); ++j)
                    result.matrix[i, j] = v1.matrix[i, j] * chislo;
            return result;
        }


        public void Print() 
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

    }
}

