using System;
using System.Collections;
using System.Collections.Generic;

namespace Figure
{
    class Program
    {
        private const int V = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("\t***Figura***");
            ArrayList shape = new ArrayList();
            while (true)
            {
                Console.WriteLine("1. Add shape");
                Console.WriteLine("2. View shapes");
                Console.WriteLine("3. Remove shape");
                Console.WriteLine("4. Exit");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: // Add shape
                        Console.Clear();                        
                        while (true)
                        {

                            Console.WriteLine("1. Add Circle");
                            Console.WriteLine("2. Add Rectangle");
                            Console.WriteLine("3. Exit");

                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1: // add circle 

                                    Console.Clear();
                                    Console.Write("Enter radius circle: ");
                                    double radius = Convert.ToDouble(Console.ReadLine());
                                    shape.Add(new Circle(radius));
                                    continue;

                                case 2: // add rectangle
                                    Console.Clear();
                                    Console.Write("Enter width rectangle: ");
                                    double width = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Enter height rectangle: ");
                                    double height = Convert.ToDouble(Console.ReadLine());
                                    shape.Add(new Rectangle(width, height));
                                    continue;

                                case 3: // exit
                                    break;


                                default: // error
                                    Error(1, 3);
                                    continue;
                            }
                        }
                                            
                    case 2: // View shapes
                        {
                            Console.Clear();
                            int i = 1;
                            foreach (Shape s in shape)
                            {
                                Console.WriteLine($"Circle {i} area: {s.Area()} lenght: {s.Perimeter()}");
                                i++;
                            }
                            break;
                        }

                    case 3: // Remove shapes
                        {
                            Console.Clear();


                            int i = 1;
                            foreach (Shape s in shape)
                            {
                                Console.WriteLine($"Circle {i} area: {s.Area()} lenght: {s.Perimeter()}");
                                i++;
                            }
                            Console.WriteLine("0. Exit");
                            Console.WriteLine("Enter number shape what you want delete or 0 for exit : ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            if (number == 0)
                            {
                                continue;
                            }
                            shape.RemoveAt(number - 1);

                            break;
                        }

                    case 4: // Exit
                        return;                        

                    default: // Error                       
                            Error(1, 4);
                            continue;                         
                }
            }

            void Error(int from, int to)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"\a Error: enter number form {from} to {to}");
                Console.ResetColor();
            }
        }
    }
}
