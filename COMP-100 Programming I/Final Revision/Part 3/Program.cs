using System.ComponentModel;

namespace Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        static int CalculateDifference(int firstNumber, int secondNumber)
        {            
            int difference;
            if (firstNumber >= secondNumber)
            {
                difference = firstNumber - secondNumber;
            }
            else 
            {
                difference = secondNumber - firstNumber;
            }
            return difference;
        }
        static double CalculatePower(double current, double resistance)
        {
            double power = Math.Pow(current, 2) * resistance;
            return power;
        }
        static double CalculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99)
        {
            double fees = numberOfCourses * costPerCourse + 15.25;
            return fees;
        }
        static double CalculateCommission(double saleAmount)
        {
            double commission;

            if (saleAmount > 1000)
            {
                commission = (saleAmount - 1000) * 0.01;
            }
            else
            {
                commission = 0;
            }

            return commission; 
        }
        static double CalculateBurgerCost()
        {
            Console.Write("Enter the number of burgers you want to buy: ");
            int numberOfBurgers = Convert.ToInt32((Console.ReadLine()));
            double totalCost = numberOfBurgers * 1.39;
            return totalCost;
        }
        static double CalculateGravitationalAttraction(double mass1, double mass2, double distance)
        {
            double G = 6.673e-11;
            double force = G * mass1 * mass2 / (distance * distance);
            return force;
        }
        static double CalculateTriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            return fahrenheit;
        }
        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        static double ConvertCelsiusToKelvin(double celsius)
        {
            double kelvin = celsius + 273.15;
            return kelvin;
        }
        static double ConvertFahrenheitToKelvin(double fahrenheit)
        {
            double celsius = ConvertFahrenheitToCelsius(fahrenheit);
            double kelvin = ConvertCelsiusToKelvin(celsius);

            return kelvin;
        }
        static int Square(int number)
        {
            return number * number;
        }

        static int Cube(int number)
        {
            return number * number * number;
        }
        static void DisplayMenu()
        {
            Console.WriteLine("=============Xuan Tri Nguyen's Part 3========================");
            Console.WriteLine("|            1. Calculate Difference                        |");
            Console.WriteLine("|            2. CalculatePower                              |");
            Console.WriteLine("|            3. CalculateTuitionFee                         |");
            Console.WriteLine("|            4. CalculateCommission                         |");
            Console.WriteLine("|            5. GetBurgerCost                               |");
            Console.WriteLine("|            6. CalculateGravitationalForce                 |");
            Console.WriteLine("|            7. HeronFormula                                |");
            Console.WriteLine("|            8. ConvertCelsiusToFahrenheit                  |");
            Console.WriteLine("|            9. ConvertFahrenheitToCelsius                  |");
            Console.WriteLine("|            10. ConvertCelsiusToKelvin                     |");
            Console.WriteLine("|            11. ConvertFahrenheitToCelsius                 |");
            Console.WriteLine("|            12. Square of Cube                             |");
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
                        Console.WriteLine($"The difference between {10}  and {5} is {CalculateDifference(10, 5)}");
                        Console.WriteLine($"The difference between {20}  and {30} is {CalculateDifference(20, 30)}");
                        Console.WriteLine($"The difference between {100}  and {75} is {CalculateDifference(100, 75)}");
                        Console.WriteLine($"The difference between {8}  and {8} is {CalculateDifference(8, 8)}");
                        break;
                    case 2:
                        Console.WriteLine($"If current is {2.5}A and Resistance is {10}ohms then power will be {CalculatePower(2.5, 10)}W");
                        Console.WriteLine($"If current is {3.0}A and Resistance is {30}ohms then power will be {CalculatePower(3.0, 15)}W");
                        break;
                    case 3:
                        Console.WriteLine($"{3} courses @{499.99:C2} will cost a total of {(CalculateTuitionFee(3)):C2}");
                        Console.WriteLine($"{5} courses @{499.99:C2} will cost a total of {(CalculateTuitionFee(5)):C2}");
                        Console.WriteLine($"{2} courses @{599.99:C2} will cost a total of {(CalculateTuitionFee(2, 599.99)):C2}");
                        Console.WriteLine($"{7} courses @{499.99:C2} will cost a total of {(CalculateTuitionFee(7)):C2}");
                        break;
                    case 4:
                        Console.WriteLine($"A sale amount of {900:C2} will yield a commission of {(CalculateCommission(900)):C2}");
                        Console.WriteLine($"A sale amount of {1000:C2} will yield a commission of {(CalculateCommission(1000)):C2}");
                        Console.WriteLine($"A sale amount of {1001:C2} will yield a commission of {(CalculateCommission(1001)):C2}");
                        Console.WriteLine($"A sale amount of {200:C2} will yield a commission of {(CalculateCommission(200)):C2}");
                        break;
                    case 5:
                        double totalCost1 = CalculateBurgerCost();
                        double totalCost2 = CalculateBurgerCost();
                        Console.WriteLine($"Total cost for the first order: {totalCost1:C}");
                        Console.WriteLine($"Total cost for the second order: {totalCost2:C}");               
                        break;
                    case 6:
                        double massOfEarth = 5.972e24, massOfMoon = 7.348e22, distance = 3.844000e+008;
                        Console.WriteLine($"earth {massOfEarth}");
                        Console.WriteLine($"moon {massOfMoon}");
                        Console.WriteLine($"distance {distance}");
                        Console.WriteLine($"force {CalculateGravitationalAttraction(5.972e24, 7.348e22, 3.844000e+008)}");
                        break;
                    case 7:
                        double area = CalculateTriangleArea(5.83, 4.24, 8.00);
                        Console.WriteLine($"a:{5.83} b:{4.24} c:{8.00} area:{area:F2}");
                        break;
                    case 8:
                        Console.WriteLine($"c:{0.00} f:{(ConvertCelsiusToFahrenheit(0)):F2}");
                        Console.WriteLine($"c:{51.00} f:{(ConvertCelsiusToFahrenheit(51)):F2}");
                        Console.WriteLine($"c:{100.00} f:{(ConvertCelsiusToFahrenheit(100)):F2}");
                        break;
                    case 9:
                        Console.WriteLine($"F:{0.00} C:{(ConvertFahrenheitToCelsius(0)):F2}");
                        Console.WriteLine($"F:{51.00} C:{(ConvertFahrenheitToCelsius(123.8)):F2}");
                        Console.WriteLine($"F:{100.00} C:{(ConvertFahrenheitToCelsius(212)):F2}");
                        break;
                    case 10:
                        Console.WriteLine($"C:{0.00} K:{(ConvertCelsiusToKelvin(-196)):F2}");
                        Console.WriteLine($"C:{51.00} K:{(ConvertCelsiusToKelvin(0)):F2}");
                        Console.WriteLine($"C:{100.00} K:{(ConvertCelsiusToKelvin(100)):F2}");
                        break;
                    case 11:
                        Console.WriteLine($"F:{0.00} K:{(ConvertFahrenheitToKelvin(32)):F2}");
                        Console.WriteLine($"F:{51.00} K:{(ConvertFahrenheitToKelvin(68)):F2}");
                        Console.WriteLine($"F:{100.00} K:{(ConvertFahrenheitToKelvin(212)):F2}");                        
                        break;
                    case 12:
                        Console.Write("Enter a number: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Original number: {input}, after cubing the square: {Cube(Square(input))}");
                        break;                    
                }
            }
            while (choice != 0);
        }
    }
}
