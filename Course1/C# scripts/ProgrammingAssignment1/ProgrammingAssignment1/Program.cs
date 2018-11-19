

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome! This coursera assignment will calculate distance between two points and angle between them");
            Console.Write("Enter first x value: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("Enter first y value: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.Write("Enter second x value: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Enter second y value: ");
            float point2Y = float.Parse(Console.ReadLine());

            double deltaX = point2X - point1X;
            double deltaY = point2Y - point1Y;
            double distance = Math.Pow(Math.Pow(deltaX, 2.0) + Math.Pow(deltaY, 2.0), 0.5);
            double angleInRadians = Math.Atan2(deltaY, deltaX);
            double angleInDegrees = angleInRadians * (180 / Math.PI);


            Console.WriteLine("The distance is " + distance);
            Console.WriteLine("The angle is " + (angleInDegrees));
        }
    }
}

/*
namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome - this application will calculate the " +
            "distance between two points and the angle between " +
            "those points");

            Console.Write("Enter first point's x value: ");
            float pointX1 = float.Parse(Console.ReadLine());

            Console.Write("Enter first point's y value: ");
            float pointY1 = float.Parse(Console.ReadLine());

            Console.Write("Enter second point's x value: ");
            float pointX2 = float.Parse(Console.ReadLine());

            Console.Write("Enter second point's y value: ");
            float pointY2 = float.Parse(Console.ReadLine());

            Console.WriteLine("OK the points are: ({0}, {1}) and ({2},{3})",
            pointX1, pointY1, pointX2, pointY2);

            float deltaX = pointX2 - pointX1;
            float deltaY = pointY2 - pointY1;

            float slope = (pointY2 - pointY1) / (pointX2 - pointX1);

            Console.WriteLine("Delta/slope is: {0}", slope);

            float distance = (float)Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            Console.WriteLine("Distance is: {0}", distance);

            float radians = (float)Math.Atan2(deltaY, deltaX);
            float angle = (float)(radians * (180 / Math.PI));

            Console.WriteLine("Angle is: {0}", angle);

        }
    }
} 
*/

/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
class Program
{
static void Main(string[] args)
{

//UserName
Console.Write("Enter your name: ");
string userName = Console.ReadLine();

//Welcoming Massage
Console.WriteLine("Welcome " + userName + " this is an application to calculate the distance between two points and the angle between those points.");
Console.WriteLine();

//Get the first value of x from the user
Console.Write("Enter the first X value: " );
float point1X = float.Parse(Console.ReadLine());

//Get the first value of y from the user

Console.Write("Enter the first Y value: ");
float point1Y = float.Parse(Console.ReadLine());

//Get the second value of x from the user

Console.Write("Enter the second X value: ");
float point2X = float.Parse(Console.ReadLine());

//Get the second value of y from the user

Console.Write("Enter the second Y value: ");
float point2Y = float.Parse(Console.ReadLine());

//Declareing delta X and delta Y and Calculating them
float deltaX, deltaY;
deltaX = point2X - point1X;
deltaY = point2Y - point1Y;

//Calculating the distance between the two points using the Pythagorean Theorem
float hypotenuse = deltaX * deltaX + deltaY * deltaY;

//Calculating the angle using Atan2 (Link Used : https://docs.microsoft.com/en-us/dotnet/api/system.math.atan2?view=netframework-4.7.2)
float radians = (float)Math.Atan2(deltaY, deltaX);
double angle = radians * (180 / Math.PI);

//Printing out the distance between two points and the angle (in degrees) between the two points.
Console.WriteLine("Distance between the two points: " + (float)Math.Sqrt(hypotenuse) + "."); //(Link Used :https://www.quora.com/How-do-I-calculate-the-square-root-of-a-number-in-C-using-system-math)
Console.WriteLine("Angle between the two points: " + (float)angle + " degrees.");
Console.WriteLine();
}
}
}

   /*
    * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
class Program
{

/// <summary>
/// Calculate the distance between two points.
/// </summary>
/// <param name="args">command-line args</param>
/// 

const double Rad2Deg = 180.0 / Math.PI;
const double Deg2Rad = Math.PI / 180.0;

static void Main(string[] args)
{
// Variable to store Point 1 coordinates
double pointX_1 = 0;
double pointY_1 = 0;
/// Variable to store Point 2 coordinates 
double pointX_2 = 0;
double pointY_2 = 0;

double deltaX = 0;
double deltaY = 0;
double temp_DeltaX;
double temp_DeltaY;
double distance;
double angle;

Console.WriteLine("Program will calculate the distance between the two points and angle between them. Input the coordinates of Point 1 and Point 2:");
Console.WriteLine();

Console.Write("Point 1 X : ");
pointX_1 = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Point 1 Y : ");
pointY_1 = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Point 2 X : ");
pointX_2 = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Point 2 Y : ");
pointY_2 = double.Parse(Console.ReadLine());
Console.WriteLine();

deltaX = pointX_2 - pointX_1;
deltaY = pointY_2 - pointY_1;

// Taking square of delta values using Pow method of Math class
temp_DeltaX = Math.Pow(deltaX, 2);
temp_DeltaY = Math.Pow(deltaY, 2);

// Taking square root using Sqrt method of Math class 

distance = Math.Sqrt(temp_DeltaX + temp_DeltaY);
angle = Math.Atan2(pointY_2 - pointY_1, pointX_2 - pointX_1) * Rad2Deg;



Console.WriteLine("With those inputs, the expected outputs are:");
Console.WriteLine();

Console.WriteLine("Distance between points: : {0}", distance);
Console.WriteLine();

Console.WriteLine("Angle between points: {0} degrees", angle);
Console.WriteLine();

//Console.WriteLine("deltaY: {0}", deltaY);
Console.ReadKey();
}
}
}
*/
