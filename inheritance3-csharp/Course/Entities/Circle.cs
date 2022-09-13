using System;
using System.Globalization;

namespace Course.Entities.Enum
{
    class Circle : Shape
    {

        public Color Color { get; set; }
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {            
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
