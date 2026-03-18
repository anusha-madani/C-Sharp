using System;

class Program
{
    static void Main()
    {
        //EVEN/ODD NUMBER
        Console.Write("ENTER YOUR NUMBER:  ");
        int nums = Convert.ToInt32(Console.ReadLine());
        if (nums % 2 == 0)
        {
            Console.WriteLine("this number is even");
        }
        else
        {
            Console.WriteLine("this number is odd");
        }

        //PRIME NUMBER
        Console.Write("ENTER YOUR NUMBER TO CHECK ITS PRIME NUM OR NOT:  ");
        int primenum = Convert.ToInt32(Console.ReadLine());
        int counter = 0;

        for (int i = 1; i < primenum; i++)
        {
            if (primenum % i == 0)
            {
                counter++;
            }
        }
        if (counter == 0)
        {

            Console.WriteLine("this is a prime number");
        }
        else
        {
            Console.WriteLine("this is not a prime number");

        }

        //LEAP YEAR
        Console.Write("ENTER YOUR YEAR TO CHECK ITS LEAP YEAR OR NOT:  ");
        int year = Convert.ToInt32(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("its a leap year");
        }
        else
        { 
          Console.WriteLine("its not a leap year");
        }

        //FACTORIAL NUMBER
        Console.Write("ENTER NUMBER OF FACTORIAL:  ");
        int number = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }
         Console.WriteLine("factorial of " + number + " is " + factorial);

        //SUM 
        Console.Write("ENTER YOUR FIRST NUMBER:  ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("ENTER YOUR SECOND NUMBER:  ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);

        //MARKSHEET
        Console.Write("ENTER YOUR NAME:  ");
        String name = Console.ReadLine();

        Console.Write("Enter your English marks: ");
        int subject1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your Maths marks: ");
        int subject2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your Urdu marks: ");
        int subject3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your phy marks: ");
        int subject4 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your chem marks: ");
        int subject5 = Convert.ToInt32(Console.ReadLine());

        int  Total = subject1 + subject2 + subject3 + subject4 + subject5;
        double per = (Total* 100.0) / 500.0;


        if (per >= 80)
        {
            Console.WriteLine("GRADE A+");
        }
        else if (per >= 70)
        {
            Console.WriteLine("GRADE A");
        }
        else if (per >= 60)
        {
            Console.WriteLine("GRADE B");
        }
        else if (per >= 50)
        {
            Console.WriteLine("GRADE C");
        }
        else
        {
            Console.WriteLine("GRADE FAIL");
        }
        
        Console.WriteLine("STUDENT NAME: " + name);
        Console.WriteLine("TOTAL MARKS: " + Total);
        Console.WriteLine("PERCANTAGE: " + per + "%");

    }

}


