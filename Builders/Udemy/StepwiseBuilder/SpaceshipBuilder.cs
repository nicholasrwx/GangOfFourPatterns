public class SpaceShipBuilder
{
  private class Implement :
  ISpecifySpaceShipType,
  ISpecifyWarpSpeed,
  IBuildSpaceShip
  {
    public ISpecifyWarpSpeed OfType(SpaceShipType Type)
    {
      throw new NotImplementedException();
    }

    public IBuildSpaceShip WithWarpSpeed(int speed)
    {
      throw new NotImplementedException();
    }

    public SpaceShip Build()
    {
      throw new NotImplementedException();
    }
  }

  public static ISpecifySpaceShipType Create()
  {
    //Impl is cast to an ISpecifySpaceShipType
    return new Implement();
  }
}