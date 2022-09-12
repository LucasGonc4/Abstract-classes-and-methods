using System;

namespace Course.Entities.Enum
{
    class Rectangle : Shape
    {
        public Color Color { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
       

        public override double Area()
        {
            return Width * Height;
        }
    }
}
