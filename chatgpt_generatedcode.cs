using System;

public class TriangleType {
    public static void Main() {
        Console.WriteLine("Enter the length of three sides of the triangle: ");

        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        if ((side1 + side2) > side3 && (side2 + side3) > side1 && (side3 + side1) > side2) {
            if (side1 == side2 && side2 == side3) {
                Console.WriteLine("Equilateral triangle");
            }
            else if (side1 == side2 || side2 == side3 || side3 == side1) {
                Console.WriteLine("Isosceles triangle");
            }
            else {
                Console.WriteLine("Scalene triangle");
            }
        }
        else {
            Console.WriteLine("These sides cannot form a triangle");
        }
    }
}
