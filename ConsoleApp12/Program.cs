using System;

namespace ConsoleApp12
{
 
    internal class Program
    {
        enum DayOfWeek
        {
            Saturday = 1,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        //static double Add(double x, double y)
        //{
        //    return x + y;
        //}

        //static double Subtract(double x, double y)
        //{
        //    return x - y;
        //}

        //static double Multiply(double x, double y)
        //{
        //    return x * y;
        //}

        //static double Divide(double x, double y)
        //{
        //    return x / y;
        //}
        static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = 3.14 * radius * radius;

            circumference = 2 * 3.14 * radius;
        }

        static void Main(string[] args)
        {
            #region Part 1: Enums . Q1 : Day of the Week

            //Console.Write("Enter a day number (1-7): ");

            //int number = int.Parse(Console.ReadLine());

            //DayOfWeek day = (DayOfWeek)number;

            //Console.WriteLine("Day: " + day);

            //switch (day)
            //{
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("It's the Weekend");
            //        break;

            //    default:
            //        Console.WriteLine("It's a Workday");
            //        break;
            //}
            #endregion

            #region Part 2: Arrays . Q1 : Array Statistics

            //Console.Write("Enter array size: ");

            //int size = int.Parse(Console.ReadLine());

            //int[] numbers = new int[size];

            //int sum = 0;
            //int max;
            //int min;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter element [{i}]: ");

            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //max = numbers[0];
            //min = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }

            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}

            //double average = (double)sum / size;

            //Console.WriteLine("\nSum = " + sum);

            //Console.WriteLine("Average = " + average);

            //Console.WriteLine("Max = " + max);

            //Console.WriteLine("Min = " + min);

            //Console.Write("Reverse = ");

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i]);

            //    if (i != 0)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            #endregion

            #region Part 2: Arrays . Q2 : Student Grades Matrix

            //int[,] grades = new int[3, 4];

            //double total = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"\nEnter grades for Student {i + 1}");

            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");

            //        grades[i, j] = int.Parse(Console.ReadLine());

            //        total += grades[i, j];
            //    }
            //}

            //Console.WriteLine("\n--- Students Average ---");

            //for (int i = 0; i < 3; i++)
            //{
            //    int sum = 0;

            //    for (int j = 0; j < 4; j++)
            //    {
            //        sum += grades[i, j];
            //    }

            //    double average = (double)sum / 4;

            //    Console.WriteLine($"Student {i + 1} Average = {average}");
            //}

            //double classAverage = total / 12;

            //Console.WriteLine($"\nClass Average = {classAverage}");
            #endregion

            #region Part 3: Functions  .  Q1 : Basic Calculator Functions
            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operation (+ , - , * , /): ");
            //char op = char.Parse(Console.ReadLine());

            //double result = 0;

            //switch (op)
            //{
            //    case '+':
            //        result = Add(num1, num2);
            //        break;

            //    case '-':
            //        result = Subtract(num1, num2);
            //        break;

            //    case '*':
            //        result = Multiply(num1, num2);
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = Divide(num1, num2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero");
            //            return;
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Operation");
            //        return;
            //}

            //Console.WriteLine("Result = " + result);

            #endregion

            #region Part 3: Functions  .   Q2 : Circle Calculator with out

            Console.Write("Enter radius: ");

            double radius = double.Parse(Console.ReadLine());

            double area;
            double circumference;

            CalculateCircle(radius, out area, out circumference);

            Console.WriteLine("Area = " + area);

            Console.WriteLine("Circumference = " + circumference);
            #endregion

        }


    }
    
}