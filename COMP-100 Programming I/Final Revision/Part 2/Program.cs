namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        static void DisplayHorizontalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }
        static void CalculateAndDisplaySphereVolume(double radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * radius*radius*radius;
            Console.WriteLine($"A sphere of radius {radius:F2} will have a volume of {volume:F2}");
        }
        static void CalculateAndDisplaySellingPrice(double costPrice, string provinceCode)
        {            
            switch (provinceCode.ToUpper())
            {
                case "ON":
                    Console.WriteLine($"The tax on an item {costPrice:C2} in on will be {(costPrice * 1.13):C2}");             
                    break;
                case "QC":
                    Console.WriteLine($"The tax on an item {costPrice:C2} in on will be {(costPrice * 1.17):C2}");
                    break;
                default:
                    Console.WriteLine($"The tax on an item {costPrice:C2} in on will be {0:C2}");
                    break;
            }
        }
        static void DisplayConversionTable(double startCelsius)
        {            
            for (int i = 0; i < 10; i++)
            {
                double celsius = startCelsius + i;
                double fahrenheit = (9.0 / 5.0) * celsius + 32;

                Console.WriteLine($"{celsius:F1} {fahrenheit:F1}");
            }
            Console.WriteLine(); 
        }
        static void DisplayKilometerToMilesTable(double startingKm, double increment, int numberOfLines)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                double km = startingKm + i * increment;
                double miles = km * 0.621371;
                Console.WriteLine($"{km:F2} {miles:F2}");
            }
        }
        static void DisplaySineTable(double startValue, double increment, int numRows)
        {            
            for (int i = 0; i < numRows; i++)
            {
                double angle = startValue + i * increment;
                double sineValue = Math.Sin(angle);
                Console.WriteLine($"{angle:F2} {sineValue:F4}");
            }
        }
        static void ConvertHeightToMetersAndCentimeters(int heightInCentimeters)
        {
            Console.WriteLine($"{heightInCentimeters}cm {heightInCentimeters / 100}m {heightInCentimeters % 100}cm");
        }
        static void DisplayMenu()
        {
            Console.WriteLine("=============Xuan Tri Nguyen's Part 2========================");
            Console.WriteLine("|            1. Display Horizontal Stars                    |");
            Console.WriteLine("|            2. Display Vertical Stars                      |");
            Console.WriteLine("|            3. Calculate and Display Volume                |");
            Console.WriteLine("|            4. Calculate and Display Tax                   |");
            Console.WriteLine("|            5. Celsius Fahrenheit Table                    |");
            Console.WriteLine("|            6. Km To Miles Table                           |");
            Console.WriteLine("|            7. Display Sine Table                          |");
            Console.WriteLine("|            8. Height Conversion                           |");
            Console.WriteLine("|            0. End program                                 |");
            Console.WriteLine("|                                                           |");
            Console.WriteLine("=============================================================");
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
                        DisplayHorizontalStars(0);
                        DisplayHorizontalStars(5);
                        DisplayHorizontalStars(10);
                        break;
                    case 2:
                        DisplayVerticalStars(0);
                        DisplayVerticalStars(5);
                        DisplayVerticalStars(10);
                        break;
                    case 3:
                        CalculateAndDisplaySphereVolume(1);
                        CalculateAndDisplaySphereVolume(2);
                        CalculateAndDisplaySphereVolume(10);
                        break;
                    case 4:
                        Console.Write("Enter the price of the item: ");
                        double costPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the province the item was bought: ");
                        string provinceCode = Convert.ToString(Console.ReadLine());
                        CalculateAndDisplaySellingPrice(costPrice, provinceCode);
                        break;
                    case 5:
                        DisplayConversionTable(0);
                        DisplayConversionTable(10);
                        break;
                    case 6:
                        DisplayKilometerToMilesTable(0, 1, 10);  
                        DisplayKilometerToMilesTable(10, 2, 5);  
                        DisplayKilometerToMilesTable(100, 5, 3);
                        break;
                    case 7:
                        DisplaySineTable(0.5, 0.03, 10); 
                        DisplaySineTable(1, 0.1, 5);
                        break;
                    case 8:
                        ConvertHeightToMetersAndCentimeters(90);
                        ConvertHeightToMetersAndCentimeters(120);
                        ConvertHeightToMetersAndCentimeters(275);
                        break;
                }
            }
            while (choice != 0);
        }            
    }
}
