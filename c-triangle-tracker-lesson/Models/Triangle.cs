namespace Triangle.Models
{
  public class TriangleModel
  {
    public int SideOne { get; set; }
    public int SideTwo { get; set; }
    public int SideThree { get; set; }

    public TriangleModel(int sideA, int sideB, int sideC)
    {
      SideOne = sideA;
      SideTwo = sideB;
      SideThree = sideC;
    }

  }
}
