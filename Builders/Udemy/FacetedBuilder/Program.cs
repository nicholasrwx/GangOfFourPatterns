var pb = new WorkerBuilder();
Worker worker = pb
  .Lives
    .At("8484 Medicine Hat Road")
    .In("Alberta")
    .WithPostcode("A5B2PT")
  .Works
    .At("TowTruckApocalypse")
    .AsA("Worker")
    .Earning(2000000);

Console.WriteLine(worker);
