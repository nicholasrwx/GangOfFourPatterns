var alien = new AlienBuilder()
  .Called("Gray Alien")
  .WorksAs("Scientist")
  .Build();

var functionalAlien = new FluentAlienBuilder()
    .Called("Functional Alien")
    .WorksAs("Physician")
    .Build();

Console.WriteLine(
  string.Concat(
    $"Name: {alien.Name}",
    "\n",
    $"Position: {alien.Position}"));

Console.WriteLine(
  string.Concat(
    $"Name: {functionalAlien.Name}",
    "\n",
    $"Position: {functionalAlien.Position}"));