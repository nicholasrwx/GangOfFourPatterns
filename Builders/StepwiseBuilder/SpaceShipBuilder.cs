public class SpaceShipBuilder
{
  private class Implement :
  ISpecifySpaceShipType,
  ISpecifyWarpSpeed,
  IBuildSpaceShip
  {
    public SpaceShip spaceShip = new SpaceShip();

    public ISpecifyWarpSpeed OfType(SpaceShipType type)
    {
      spaceShip.Type = type;
      return this;
    }

    public IBuildSpaceShip WithWarpSpeed(int speed)
    {
      switch (spaceShip.Type)
      {
        case SpaceShipType.BattleShip when speed < 20 || speed > 25:
        case SpaceShipType.GalacticCruiser when speed < 15 || speed > 19:
          throw new ArgumentException($"Warp speed is not valid for: {spaceShip.Type}");
      }

      spaceShip.WarpSpeed = speed;
      return this;
    }

    public SpaceShip Build()
    {
      return spaceShip;
    }
  }

  public static ISpecifySpaceShipType Create()
  {
    //Impl is cast to an ISpecifySpaceShipType
    return new Implement();
  }
}