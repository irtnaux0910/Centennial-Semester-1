namespace Part_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
        static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;
        }
        static void CalculateSumAndDifference(int num1, int num2, out int sum, out int difference)
        {
            sum = num1 + num2;
            difference = num1 - num2;
        }
        static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            double radians = degrees * Math.PI / 180;
            sine = Math.Sin(radians);
            cosine = Math.Cos(radians);
            tangent = Math.Tan(radians);
        }
        static void CalculateTrigValues(double angle, ref double sine, ref double cosine)
        {
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
        }
        static void DisplayMenu()
        {
            Console.WriteLine("=============Xuan Tri Nguyen's Part 1============================");
            Console.WriteLine("|            1. DoubleIt                                        |");
            Console.WriteLine("|            2. CubeIt                                          |");
            Console.WriteLine("|            3. CalculateTuitionFee                             |");
            Console.WriteLine("|            4. Sum and Difference                              |");
            Console.WriteLine("|            5. CalculateTrigValues                             |");
            Console.WriteLine("|            6. SineCosine                                      |");
            Console.WriteLine("|            7. Quadratic                                       |");
            Console.WriteLine("|            0. End program                                     |");
            Console.WriteLine("|                                                               |");
            Console.WriteLine("=================================================================");
            Console.Write("Enter the number of your choice -> ");
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
                    case 2:
                        int num1 = 5;
                        int num2 = 10;
                        CubeIt(num1, ref num2);
                        Console.WriteLine($"Before method call: {num1} after method call: {num2}");
                        num1 = 7;
                        CubeIt(num1, ref num2);
                        Console.WriteLine($"Before method call: {num1} after method call: {num2}");
                        static void CubeIt(int x, ref int cube)
                        {
                            cube = x * x * x;
                        }
                        break;
                    case 3:
                        double fees = 0;
                        CalculateTuitionFee(3, 500.00, ref fees);
                        Console.WriteLine($"{3} courses @{500:C2} will cost {fees:C2}");
                        CalculateTuitionFee(5, 600.00, ref fees);
                        Console.WriteLine($"{3} courses @{500:C2} will cost {fees:C2}");
                        CalculateTuitionFee(7, 750.00, ref fees);
                        Console.WriteLine($"{7} courses @{750:C2} will cost {fees:C2}");
                        CalculateTuitionFee(2, 400.00, ref fees);
                        Console.WriteLine($"{2} courses @{500:C2} will cost {fees:C2}");
                        break;
                    case 4:
                        num1 = 10;
                        num2 = 5;
                        int result1, result2;
                        CalculateSumAndDifference(num1, num2, out result1, out result2);
                        Console.WriteLine($"a:{num1}, b:{num2},  sum:{result1}, diff:{result2}");
                        num1 = 20;
                        num2 = 8;
                        CalculateSumAndDifference(num1, num2, out result1, out result2);
                        Console.WriteLine($"a:{num1}, b:{num2},  sum:{result1}, diff:{result2}");
                        num1 = 15;
                        num2 = 12;
                        CalculateSumAndDifference(num1, num2, out result1, out result2);
                        Console.WriteLine($"a:{num1}, b:{num2},  sum:{result1}, diff:{result2}");
                        break;                    
                    case 5:
                        double sine, cosine, tangent;
                        Console.WriteLine("Degrees\tSine\tCosine\tTangent");
                        for (int degrees = 0; degrees <= 95; degrees += 5)
                        {                            
                            CalculateTrigValues(degrees, out sine, out cosine, out tangent);
                            Console.WriteLine($"{degrees}\t{sine:F4}\t{cosine:F4}\t{tangent:F4}");
                        }
                        break;

                    case 6:
                        sine = 0;
                        cosine = 0;
                        Console.WriteLine("Angle\tSine\tCosine");
                        for (double angle = 0.50; angle <= 0.59; angle += 0.01)
                        {                            
                            CalculateTrigValues(angle, ref sine, ref cosine);
                            Console.WriteLine($"{angle,5:F2}{sine,9:F4}{cosine,9:F4}");
                        }
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
