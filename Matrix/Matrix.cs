using System;
namespace Matrix
{
    public class Matrix
    {
        public int[][] Mat;
        public Matrix(int range, int[] rows, int cols)
        {
            Mat = new int[rows[cols]];
            int plus = 0;
            for(int y=0;y<rows;y++)
            {
                for(int i = 0;i<=cols;i++)
                {
                    Mat[y][i] = range + plus;
                    plus++;
                }
            }

        }
        public Matrix(int[] rows)
        {
            Mat = new int[rows[rows]];
        }
        public void Print()
        {
            for(int i=0;i<Mat.Length;i++)
            {
                System.Console.WriteLine(Mat[i]);
            }
        }
    }
}