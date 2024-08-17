namespace Xuan_Tri_Nguyen___3B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue;
            Console.Write("Enter the start value: ");
            startValue = Convert.ToInt32(Console.ReadLine());            
            for (int i = startValue; i >= 0; i -= 7)
            {                
                Console.Write(i + " ");                
                if (i <=7)
                {
                    Console.WriteLine($"\nIt will take {startValue/7+1} decrements will reach {i - 7}");
                }
            }            
        }
    }
}
