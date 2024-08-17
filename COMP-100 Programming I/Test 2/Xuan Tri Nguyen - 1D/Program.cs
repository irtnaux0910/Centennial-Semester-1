using System.Diagnostics.Metrics;

namespace Xuan_Tri_Ngueyn___1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mult, value;
            Console.Write("Enter the multiple: ");
            mult = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter start value: ");
            value = Convert.ToInt32(Console.ReadLine());                  
            do
            {                
                if (value % mult == 0)
                {
                    Console.Write(value + " ");
                }
                value--;
            } while (value >= 1);
        }
    }
}
