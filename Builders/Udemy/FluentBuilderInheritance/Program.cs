var consumerBuilder = Consumer.New
                              .AddConsumerName("James")
                              .AddOccupation("Fireman")
                              .AddOccupation("Truck Driver")
                              .AddOccupation("Engineer")
                              .AddRecreation("KungFu")
                              .AddRecreation("Hockey")
                              .AddRecreation("Sky Diving")
                              .AddConsumableContent(new Soda())
                              .AddConsumableContent(new Chips())
                              .Build();

Console.WriteLine(consumerBuilder.ConsumerInfo());
Console.WriteLine(consumerBuilder.HealthInfo());
