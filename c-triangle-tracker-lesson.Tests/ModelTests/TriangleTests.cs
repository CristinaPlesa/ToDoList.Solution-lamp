using Microsoft.VisualStudio.TestTools.UnitTesting;
using cTriangleTrackerLesson;
using Triangle.Models;

namespace cTriangleTrackerLesson.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_LengthsCreateTriangleObject_Value()
    {
      TriangleModel testTriangle = new TriangleModel(2, 4, 5);
      Assert.AreEqual(2, testTriangle.SideOne);
      Assert.AreEqual(4, testTriangle.SideTwo);
      Assert.AreEqual(5, testTriangle.SideThree);
    }

    [TestMethod]

    public void isTriangle_NotTriangle_False()
    {
      TriangleModel testTriangle = new TriangleModel(3, 9, 22);
      Assert.AreEqual(false, testTriangle.isTriangle());
    }

    [TestMethod]

    public void isTriangle_Triangle_True()
    {
      TriangleModel testTriangle = new TriangleModel(3, 3, 3);
      Assert.AreEqual(true, testTriangle.isTriangle());
    }

    [TestMethod]

    public void isIsosceles_IsoscelesTriangle_True()
    {
      TriangleModel testTriangle = new TriangleModel(5, 5, 7);
      Assert.AreEqual(true, testTriangle.isIsosceles());
    }

    [TestMethod]

    public void isIsosceles_IsoscelesTriangle_False()
    {
      TriangleModel testTriangle = new TriangleModel(5, 6, 7);
      Assert.AreEqual(false, testTriangle.isIsosceles());
    }

    [TestMethod]
    public void isEquilateral_EquilateralTriangle_True()
    {
      TriangleModel testTriangle = new TriangleModel(5, 5, 5);
      Assert.AreEqual(true, testTriangle.isEquilateral());
    }
  }
}

// We call our test method IsLeapYear_NumberDivisibleByFour_True because IsLeapYear() will be our method's name.
// NumberDivisibleByFour is the behavior this first test will test.
// True is the expected return value.