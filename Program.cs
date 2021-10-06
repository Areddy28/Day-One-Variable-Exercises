using System;

namespace DayOneExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise #1:

            Console.Write("Enter a text: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            // Exercise #2: 

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + 1);

            // Exercise #3: 

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num2 + 0.5);

            // Exercise #4: 

            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num4 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine(num3 + num4);


            // Exercise #5: 

            Console.Write("Enter a number: ");
            double num5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num5 * num6); 

            

            
        }
    }
}
