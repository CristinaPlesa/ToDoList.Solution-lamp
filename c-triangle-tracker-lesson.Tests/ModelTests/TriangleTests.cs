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
  }
}