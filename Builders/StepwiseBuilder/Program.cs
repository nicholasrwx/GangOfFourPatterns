var spaceShip = SpaceShipBuilder.Create() // ISpecifySpaceShipType
.OfType(SpaceShipType.BattleShip)         // ISpecifyWarpSpeed 
.WithWarpSpeed(22)                        // IBuildSpaceShip
.Build();                                 // SpaceShip

Console.WriteLine(
String.Concat(
  $"SpaceShip: {spaceShip.Type}",
  "\n",
  $"Speed: {spaceShip.WarpSpeed}"));
