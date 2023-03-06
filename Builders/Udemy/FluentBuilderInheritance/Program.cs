var consumerBuilder = Consumer.New.AddConsumerName("James")
               .AddOccupation("Fireman")
               .AddOccupation("Truck Driver")
               .AddOccupation("Engineer")
               .AddRecreation("KungFu")
               .AddRecreation("Hockey")
               .AddRecreation("Sky Diving")
               .AddConsumableContent(new Soda())
               .AddConsumableContent(new Chips());

Console.WriteLine(consumerBuilder._consumer.ConsumerInfo());
Console.WriteLine(consumerBuilder._consumer.HealthInfo());
