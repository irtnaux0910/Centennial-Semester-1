using System.Data;
using System.Data.Common;

namespace Xuan_Tri_Nguyen___5B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            Console.Write("Number of rows: ");
            row= Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of columns: ");
            col = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i % 5 == 0|| j % 5 == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }                      
                }
                Console.WriteLine();
            }
        }
    }
}
