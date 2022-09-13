using System;
using System.Globalization;

namespace Course.Entities.Enum
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }


        public abstract double Area();
                
    }
}
