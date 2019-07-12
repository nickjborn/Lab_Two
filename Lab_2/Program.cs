using System;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            bool repeatProgram = true;
            double length = 0;
            double width = 0;

            do
            {
                bool validLength = false;
                bool validWidth = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Let's measure a room!");
                    Console.WriteLine("What is the room's length?");
                    string inputLength = Console.ReadLine();
                    if (double.TryParse(inputLength, out length))
                    {
                        validLength = true;
                    }
                    else
                    {
                        validLength = false;
                    }
                } while (!validLength);

                do
                {
                    Console.WriteLine("What is the room's width?");
                    string inputWidth = Console.ReadLine();
                    if (double.TryParse(inputWidth, out width))
                    {
                        validWidth = true;
                    }
                    else
                    {
                        validWidth = false;
                    }

                } while (!validWidth);

                double area = width * length;
                double perimeter = (width * 2) + (length * 2);

                Console.WriteLine($"The area of the room is {area}");
                Console.WriteLine($"The perimeter of the room is {perimeter}");

                bool validRepeatInput = true;
                do
                {
                    Console.WriteLine("Would you like to measure another room? (y/n)");
                    string inputRepeat = Console.ReadLine();
                    if (inputRepeat == "y")
                    {
                        repeatProgram = true;
                        validRepeatInput = true;
                    }
                    else if (inputRepeat == "n")
                    {
                        repeatProgram = false;
                        validRepeatInput = true;
                    }
                    else
                    {
                        Console.WriteLine("I didn't catch that...");
                        validRepeatInput = false;
                    }
                } while (!validRepeatInput);

            } while (repeatProgram);



        }
    }
}
