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

    public bool isTriangle()
    {
      if ((SideOne > (SideTwo + SideThree)) || (SideTwo > (SideOne + SideThree)) || (SideThree > (SideOne + SideTwo)))
      {
        return false;
      }
      return true;
    }

    public bool isIsosceles()
    {
      if ((SideOne == SideTwo) || (SideTwo == SideThree) || (SideThree == SideOne))
      {
        return true;
      }
      return false;
    }

    public bool isEquilateral()
    {
      if ((SideOne == SideTwo) && (SideOne == SideThree))
      {
        return true;
      }
      return false;
    }

  }
}
