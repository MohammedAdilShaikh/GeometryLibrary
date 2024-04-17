using System;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        // Lengths of the sides of the triangle
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

        // Constructor to initialize the lengths of the sides
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        // Method to calculate the area of the triangle using Heron's formula
        public double CalculateArea()
        {
            // Calculate the semi-perimeter
            double semiPerimeter = (side1 + side2 + side3) / 2;

            // Calculate the area using Heron's formula
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            return area;
        }

        // Method to calculate the perimeter of the triangle
        public double CalculatePerimeter()
        {
            // Calculate the perimeter
            double perimeter = side1 + side2 + side3;
            return perimeter;
        }
    }
}
