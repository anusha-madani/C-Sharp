using System;

class Program
{
    static void Main()
    {
        //MAX NUMBER
        int[] numbers = { 5, 10, 15, 20, 25, 30 };
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max) ;
            max = numbers[i];
        }
        Console.WriteLine("MAXIMUM NUMBER: " + max);

        //MINI NUMBER
        int[] nums = { 5, 10, 15,20, 25, 30 };
        int min = nums[0];

        for (int i = 1; i < nums.Length; i++)
        { 
            if (nums[i] < min)
            min = nums[i];
        }
        Console.WriteLine("MINIMUM NUMBER: " + min);

        //CALCULATOR
        Console.WriteLine("Enter Your First Value: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter an Operator: ");
        String Operator = Console.ReadLine();
        Console.WriteLine("Enter Your Second Value: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (Operator == "+")
        {
            int ans01 = num1 + num2;
            Console.WriteLine("Answer: " + ans01);
        }
        else if (Operator == "-")
        {
            int ans02 = num1 - num2;
            Console.WriteLine("Answer: " + ans02);
        }
        else if (Operator == "*")
        {
            int ans03 = num1 * num2;
            Console.WriteLine("Answer: " + ans03);
        }
        else if (Operator == "/")
        {
            int ans04 = num1 / num2;
            Console.WriteLine("Answer: " + ans04);
        }
        else
        {
            Console.WriteLine("Error!! Please try again");
        }

        //RIGHT ANGLED TRIGANLE PATTERN
        for (int i = 1; i <= 5; i++)
        {
            for (int a = 1; a <= i; a++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }

        //HALF PYRAMID STAR PATTERN
        for (int i = 1; i <= 5; i++)
        {
            for (int a = 1; a <= i; a++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //AVERAGE NUMBER
        double[] num = { 5, 10, 15, 20, 25 };
        double sum = 0;

        for (int i = 0; i < num.Length; i++)
        {
            sum += numbers[i];
        }

        double average = sum / numbers.Length;
        Console.WriteLine($"Average = {average}");

    }
}
