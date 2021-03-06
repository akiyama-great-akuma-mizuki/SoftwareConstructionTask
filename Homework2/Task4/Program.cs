using System;
using System.Collections;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[,] Matrix = input();
                Console.WriteLine("判断是否Toplitz矩阵");
                Console.WriteLine(isToplitz(Matrix));
            }
            catch (Exception e)
            {
                Console.WriteLine("输入错误");
                Console.WriteLine(e.Message);
            }

        }
        static int[,] input()
        {
            
            Console.WriteLine("输入矩阵的行数、列数,用空格隔开");
            string input = Console.ReadLine();
            string[] strs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int row = Convert.ToInt32(strs[0]);
            int col = Convert.ToInt32(strs[1]);
            int[,] Matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("输入矩阵第" + (i+1) + "行");
                input = Console.ReadLine();
                strs = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < row; j++)
                {
                    Matrix[i, j] = Convert.ToInt32(strs[j]);
                }
            }
            return Matrix;

        }
        static bool isToplitz(int[,] Matrix)
        {
            bool judge = true;
            int row = Matrix.GetLength(0);
            int col = Matrix.GetLength(1);
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if (Matrix[i, j] != Matrix[i + 1, j + 1])
                    {
                        judge = false;
                        break;
                    }
                }
                
            }
            return judge;
        }
    }
}
