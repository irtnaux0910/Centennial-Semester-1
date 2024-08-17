using System.Reflection.Emit;

namespace Part_5
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            ShowMenu();
        }
        static void DisplayIntArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number,3} ");
            }
        }
        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            Random generator = new Random();
            int[] result = new int[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                result[i] = generator.Next(largestValue);
            }

            return result;
        }
        static int[] CountEvenOdd(int[] array)
        {
            int[] result = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    result[0]++;
                }
                else
                {
                    result[1]++;
                }
            }
            return result;
        } 
        static int[] CalculateDigitFrequencies(int[] array)
        {
            int[] result = new int[10]; 
            foreach (int num in array)
            {
                result[num]++; 
            }
            return result;
        }
        static int[] CalculateLastDigitFrequencies(int[] array)
        {
            int[] result = new int[10]; 

            foreach (int num in array)
            {
                int lastDigit = num % 10;
                result[lastDigit]++; 
            }

            return result;
        }
        static int[] CalculateNumberFrequencies(int[] array)
        {
            int[] result = new int[10];

            foreach (int num in array)
            {
                int group = num / 10; 
                result[group]++; 
            }                         

            return result;
        }
        static void DisplayMenu()
        {
            Console.WriteLine("=============Xuan Tri Nguyen's Part 5============================");
            Console.WriteLine("|            1. DisplayIntArray                                 |");
            Console.WriteLine("|            2. Generate Random Array                           |");
            Console.WriteLine("|            3. Count Evens and Odds                            |");
            Console.WriteLine("|            4. Calculate Digit Frequencies                     |");
            Console.WriteLine("|            5. Calculate Last Digit Frequencies                |");
            Console.WriteLine("|            6. Calculate Bucket Number Frequencies             |");
            Console.WriteLine("|            7. LetterFrequency                                 |");
            Console.WriteLine("|            8. Binary String                                   |");
            Console.WriteLine("|            9. Mortgage Calculation                            |");
            Console.WriteLine("|            10. Calculate Fibonacci                            |");
            Console.WriteLine("|            11. Calculate Factorial                            |");
            Console.WriteLine("|            12. Calculate Pie                                  |");
            Console.WriteLine("|            0. End program                                     |");
            Console.WriteLine("|                                                               |");
            Console.WriteLine("=================================================================");
            Console.Write("Enter the number of your choice ->");
        }
        static void ShowMenu()
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int[] numbers = { 5, 12,  8,  5,  7,  3,  5,  6,  9, 10, 16,  8, 11, 34,  9, 50, 12, 14, 45 };
                        DisplayIntArray(numbers);
                        break;
                    case 2:
                        int[] array1 = GenerateRandomIntArray(15, 10);
                        DisplayIntArray(array1);
                        int[] array2 = GenerateRandomIntArray(25, 10);
                        DisplayIntArray(array2);
                        int[] array3 = GenerateRandomIntArray(30, 100);
                        DisplayIntArray(array3);
                        break;
                    case 3:
                        int[] array4 = GenerateRandomIntArray(10, 50);                        
                        Console.Write("List: ");                        
                        DisplayIntArray(array4);
                        Console.Write("\nNumber of odd and even:");
                        DisplayIntArray(CountEvenOdd(array4));
                        Console.WriteLine("");
                        break;
                    case 4:
                        int[] array5 = GenerateRandomIntArray(50, 50);                        
                        DisplayIntArray(array5);
                        int[] frequencies = CalculateDigitFrequencies(array5);                        
                        DisplayIntArray(frequencies);
                        break;
                    case 5:
                        int[] array6 = GenerateRandomIntArray(50, 50);
                        DisplayIntArray(array6);
                        int[] lastDigitFrequencies = CalculateLastDigitFrequencies(array6);
                        break;
                    case 6:
                        int[] array7 = GenerateRandomIntArray(50, 50);
                        DisplayIntArray(array7);
                        DisplayIntArray(array7);
                        int[] CalculateNumberFrequencies = CalculateLastDigitFrequencies(array7);
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
