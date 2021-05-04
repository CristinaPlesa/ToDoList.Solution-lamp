//frontend logic
using System;
using System.Collections.Generic;
using Triangle.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      // Triangle testOne = new Triangle(2, 4, 5);

      Console.WriteLine("Enter a number for the length of first side:");
      string stringFirstLength = Console.ReadLine();
      int firstLength = int.Parse(stringFirstLength);
    }
  }
}