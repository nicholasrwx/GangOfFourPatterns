var alien = new AlienBuilder()
  .Called("Gray Alien")
  .WorksAs("Scientist")
  .Build();

Console.WriteLine(
  string.Concat(
    $"Name: {alien.Name}",
    "\n",
    $"Position: {alien.Position}"));