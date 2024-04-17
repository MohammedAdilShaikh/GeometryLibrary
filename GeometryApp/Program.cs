using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeometryLibrary;

class Program
{
    static async Task Main(string[] args)
    {
        // Setup configuration and dependency injection
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true" },
            { "FeatureManagement:Rectangle", "false" },
            { "FeatureManagement:Triangle", "true" }
        };

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(featureManagement)
            .Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        // Get the IFeatureManager service
        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        // Check if Square feature is enabled
        if (await featureManager.IsEnabledAsync("Square"))
        {
            // Provide access to Square
            var square = new Square(5); // Assuming 5 is the side length
            Console.WriteLine($"Square area: {square.CalculateArea()}");
            Console.WriteLine($"Square perimeter: {square.CalculatePerimeter()}");
        }

        // Check if Rectangle feature is enabled
        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            // Provide access to Rectangle
            var rectangle = new Rectangle(4, 6); // Assuming 4 is the length and 6 is the width
            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Rectangle perimeter: {rectangle.CalculatePerimeter()}");
        }

        // Check if Triangle feature is enabled
        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            // Provide access to Triangle
            var triangle = new Triangle(3, 4, 5); // Assuming sides are 3, 4, and 5
            Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");
            Console.WriteLine($"Triangle perimeter: {triangle.CalculatePerimeter()}");
        }

        // Check if Square feature is enabled
        if (await featureManager.IsEnabledAsync("Square"))
        {
            // Provide access to Square
            Console.WriteLine("Enter the side length of the square:");
            string sideLengthInput = Console.ReadLine();
            double sideLength = double.Parse(sideLengthInput);

            var square = new Square(sideLength);
            Console.WriteLine($"Square area: {square.CalculateArea()}");
            Console.WriteLine($"Square perimeter: {square.CalculatePerimeter()}");
        }

        // Check if Rectangle feature is enabled
        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            // Provide access to Rectangle
            Console.WriteLine("Enter the length of the rectangle:");
            string lengthInput = Console.ReadLine();
            double length = double.Parse(lengthInput);

            Console.WriteLine("Enter the width of the rectangle:");
            string widthInput = Console.ReadLine();
            double width = double.Parse(widthInput);

            var rectangle = new Rectangle(length, width);
            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Rectangle perimeter: {rectangle.CalculatePerimeter()}");
        }

        // Check if Triangle feature is enabled
        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            // Provide access to Triangle
            Console.WriteLine("Enter the lengths of the three sides of the triangle (comma-separated):");
            string sidesInput = Console.ReadLine();
            string[] sides = sidesInput.Split(',');
            double side1 = double.Parse(sides[0]);
            double side2 = double.Parse(sides[1]);
            double side3 = double.Parse(sides[2]);

            var triangle = new Triangle(side1, side2, side3);
            Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");
            Console.WriteLine($"Triangle perimeter: {triangle.CalculatePerimeter()}");
        }

    }
}
