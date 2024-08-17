namespace Xuan_Tri_Nguyen___4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  x\t 3x^2\t -7x\t 2\t  y");
            Console.WriteLine(" ----\t ----\t ----\t----\t ----");
            for (double x = 0.0; x <= 2.0; x += 0.33)
            {
                Console.WriteLine($"{x,5:F2}\t{3 * x * x,5:F2}\t{-7 * x,5:F2}\t2.00\t{3 * x * x - 7 * x + 2,5:F2}");
            }
        }
    }
}
