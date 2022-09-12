using System;
using Course.Entities.Enum;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data");

                Console.Write("Rectangle or circle (r/c)?: ");
                char character = char.Parse(Console.ReadLine());

                Console.Write("Color (Black, Blue or Red)?: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (character == 'r')
                {
                    
                    Console.Write("Width?: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height?: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Rectangle rectangle = new Rectangle(width, height, color);

                    list.Add(rectangle);
                }

                else if(character == 'c')
                {

                    Console.WriteLine("Radius?: ");

                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Circle circle = new Circle(color, radius);

                    list.Add(circle);
                }

                else
                {
                    Console.WriteLine("This shape not exists in options!!");
                }

            }

            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape obj in list)
            {
                Console.WriteLine(obj.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
