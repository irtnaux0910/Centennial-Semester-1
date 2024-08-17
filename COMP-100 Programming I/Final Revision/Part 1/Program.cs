namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        static void DisplayPersonalInfo()
        {
            Console.WriteLine("Xuan Tri Nguyen");
            Console.WriteLine("School of Engineering Technology and Applied Science");
            Console.WriteLine("Post-secondary program");
            Console.WriteLine("Programming");
        }
        static void CalculateTuition()
        {
            int numChoice;
            double cost;
            Console.Write("How many courses are you taking? ");
            numChoice = Convert.ToInt32(Console.ReadLine());
            cost = numChoice * 569.99;
            Console.Write($"The cost of {numChoice} courses is {cost:C2}");
        }
        static void CalculateAreaOfCircle()
        {
            double radius, area;
            Console.Write("Enter the radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = radius * radius * Math.PI;
            Console.Write($"If the radius is {radius} the area will be {area}");
        }
        static void CalculateAreaOfTriangle()
        {
            double height, area, side;
            Console.Write("Height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Base: ");
            side = Convert.ToDouble(Console.ReadLine());
            area = (height * side) / 2;
            Console.Write($"The area will be {area}");
        }
        static void CalculateSaleCommission()
        {
            double commission, sales;
            Console.Write("What is your sales amount? ");
            sales = Convert.ToDouble(Console.ReadLine());
            if (sales > 1000)
            {
                commission = 0.25 * sales;
                Console.Write($"The commission on {sales:C2} is {commission}");
            }
            else
            {
                Console.Write($"The commission on {sales:C2} is {0:C2}");
            }
        }
        static void DisplaySineTable()
        {
            double start, incre;
            Console.Write("Starting value (rad): ");
            start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Increment value (rad): ");
            incre = Convert.ToDouble(Console.ReadLine());
            for (double i = 0; i < 10; i++)
            {
                Console.WriteLine($"{start:F2} {(Math.Sin(start)):F3}");
                start += incre;
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("=============Xuan Tri Nguyen's Part 1============================");
            Console.WriteLine("|            1. Display Personal Information                    |");
            Console.WriteLine("|            2. Calculate Tuition                               |");
            Console.WriteLine("|            3. Calculate Area Of A Circle                      |");
            Console.WriteLine("|            4. Calculate The Area Of A Triangle                |");
            Console.WriteLine("|            5. Calculate Sales Commission                      |");
            Console.WriteLine("|            6. Display Sine Table                              |");
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
                        DisplayPersonalInfo();
                        break;
                    case 2:
                        CalculateTuition();
                        break;
                    case 3:
                        CalculateAreaOfCircle();
                        break;
                    case 4:
                        CalculateAreaOfTriangle();
                        break;
                    case 5:
                        CalculateSaleCommission();
                        
                        break;
                    case 6:
                        DisplaySineTable();
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
