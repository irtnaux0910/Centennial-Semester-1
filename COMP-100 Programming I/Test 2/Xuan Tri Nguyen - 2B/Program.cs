namespace Xuan_Tri_Nguyen___2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endGram, startGram;
            Console.Write("Enter the start gram value: ");
            startGram = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end gram value: ");
            endGram = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grams\tOunces");            
            while (startGram >= endGram)
            {
                double ounces = startGram * 0.035;
                Console.WriteLine($"{startGram}\t{ounces:F3}");
                startGram -= 10;
            }
        }
    }
}
