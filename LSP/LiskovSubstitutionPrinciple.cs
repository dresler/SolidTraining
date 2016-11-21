using System;

namespace SolidTraining.LSP
{
    /// <summary>
    /// The “L” in SOLID is for Liskov Substitution Principle, 
    /// which states that subclases should be substitutable for the classes from which they were derived. 
    /// For example, if MySubclass is a subclass of MyClass, 
    /// you should be able to replace MyClass with MySubclass without bunging up the program.
    /// </summary>
    public class LiskovSubstitutionPrinciple
    {
        public static void Run()
        {
            Rectangle rectangle = new Square();
            rectangle.Height = 4;
            rectangle.Width = 5;
            var rectangleArea = AreaCalculator.CalculateRectangleArea(rectangle);

            Console.WriteLine($"Area of rectangle is {rectangleArea}, expected 20.");
        }
    }

    public class AreaCalculator
    {
        public static int CalculateRectangleArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
    }

    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    public class Square : Rectangle
    {
        private int _height;
        private int _width;

        public override int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}