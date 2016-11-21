using System;

namespace SolidTraining.OCP
{
    /// <summary>
    /// The “O” in SOLID is for Open-Closed Principle, 
    /// which states that software entities – such as classes, modules, functions and so on – 
    /// should be open for extension but closed for modification. 
    /// The idea is that it’s often better to make changes to things like classes 
    /// by adding to or building on top of them (using mechanisms like subclassing or polymorphism) 
    /// rather than modifying their code.
    /// </summary>
    public class OpenClosedPrinciple
    {
        public static void Run()
        {
            var shapes = new object[]
            {
                new Rectangle() {Height = 3, Width = 4},
                new Circle() {Radius = 4},
                new Triangle() {Base = 2, Height = 3}
            };

            var totalArea = 0m;

            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    totalArea += CalculateRectangleArea(shape as Rectangle);
                }
                if (shape is Circle)
                {
                    totalArea += CalculateCircleArea(shape as Circle);
                }
                if (shape is Triangle)
                {
                    totalArea += CalculateTriangleArea(shape as Triangle);
                }
            }

            Console.WriteLine($"Total area of all shapes is {totalArea}.");
        }

        public static decimal CalculateRectangleArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static decimal CalculateCircleArea(Circle circle)
        {
            return circle.Radius * circle.Radius * (decimal)Math.PI;
        }

        public static decimal CalculateTriangleArea(Triangle triangle)
        {
            return 0.5m * triangle.Base * triangle.Height;
        }
    }

    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Circle
    {
        public int Radius { get; set; }
    }

    public class Triangle
    {
        public int Base { get; set; }
        public int Height { get; set; }
    }
}